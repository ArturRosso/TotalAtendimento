using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TotalAtendimento
{
    public delegate void Nova_Mensagem(string asEndereco, string asMensagem);
    public delegate void Fim_Conexao(string asEndereco);

    class CentralTCP
    {
        private static Thread itCentralTCP;
        private static TcpListener itlEscutaConexao;
        private static Dictionary<string, Conexao> Conexoes = new Dictionary<string, Conexao>();

        private static bool ibEscutaConexoes = false;
        public static bool IbEscutaConexoes { get => ibEscutaConexoes; set => ibEscutaConexoes = value; }

        public static event Nova_Mensagem Nova_Mensagem;
        public static event Fim_Conexao Fim_Conexao;

        public static void IniciaCentralTCP()
        {
            IPAddress lipLocal = IPAddress.Parse("192.168.101.193");

            itlEscutaConexao = new TcpListener(lipLocal, 11000);
            itlEscutaConexao.Start();

            IbEscutaConexoes = true;

            itCentralTCP = new Thread(EscutaSolicitacoes);
            itCentralTCP.Start();
        }

        private static void EscutaSolicitacoes()
        {
            TcpClient ltcConexao;
            Conexao lcConexao;
            string asEndereco;

            try
            {
                while (IbEscutaConexoes)
                {
                    ltcConexao = itlEscutaConexao.AcceptTcpClient();
                    asEndereco = ltcConexao.Client.RemoteEndPoint.ToString();

                    lcConexao = new Conexao(ltcConexao, asEndereco);


                    Conexoes.Add(asEndereco, lcConexao);
                }
            }
            catch (System.Exception)
            {
                
            }
            
        }

        public static bool EnviarNovaMensagem(string asEndereco, string asMensagem)
        {
            if (Conexoes.ContainsKey(asEndereco))
            {
                return Conexoes[asEndereco].EnviarMensagem(asMensagem);
            }

            return false;
        }

        public static bool ExisteConexao(string asEndereco)
        {
            return Conexoes.ContainsKey(asEndereco);
        }

        public static void FecharConexao(string asEndereco)
        {
            if (Conexoes.ContainsKey(asEndereco))
            {
                Conexoes[asEndereco].FechaConexao();
            }
        }

        public static void NovaMensagem(Conexao atcCliente, string asMensagem)
        {
            On_Nova_Mensagem(atcCliente.IsEndereco, asMensagem);
        }

        public static void FimConexao(Conexao atcCliente)
        {
            Conexoes.Remove(atcCliente.IsEndereco);
            On_Fim_Conexao(atcCliente.IsEndereco);
        }

        public static void Encerrar()
        {
            itlEscutaConexao.Stop();

            foreach (var conexao in Conexoes)
            {
                Conexao cn = conexao.Value;

                cn.FechaConexao();
            }
        }

        protected static void On_Nova_Mensagem(string asEndereco, string asMensagem)
        {
            if (Nova_Mensagem != null)
                Nova_Mensagem(asEndereco, asMensagem);
        }

        protected static void On_Fim_Conexao(string asEndereco)
        {
            if (Fim_Conexao != null)
                Fim_Conexao(asEndereco);
        }
    }

    class Conexao
    {
        private StreamReader isrRecebe;
        private StreamWriter iswEnvia;
        private TcpClient itcConexao;

        private string isEndereco;
        public string IsEndereco { get => isEndereco; }
        
        private Thread itConexao;

        private bool ibEscutaMensagens = false;
        public bool IbEscutaMensagens { get => ibEscutaMensagens; set => ibEscutaMensagens = value; }

        public Conexao(TcpClient atcConexao, string asEndereco)
        {
            isrRecebe = new StreamReader(atcConexao.GetStream());
            iswEnvia = new StreamWriter(atcConexao.GetStream());

            itcConexao = atcConexao;
            isEndereco = asEndereco;

            IbEscutaMensagens = true;

            itConexao = new Thread(EscutaMensagens);
            itConexao.Start();
        }

        private void EscutaMensagens()
        {
            string lsMensagem;

            try
            {
                while (IbEscutaMensagens)
                {
                    lsMensagem = isrRecebe.ReadLine();
                    if (lsMensagem == null)
                    {
                        IbEscutaMensagens = false;
                        CentralTCP.FimConexao(this);
                    }
                    else
                    {
                        if(lsMensagem != "")
                            CentralTCP.NovaMensagem(this, lsMensagem);
                    }
                }
            }
            catch (System.Exception)
            {
                IbEscutaMensagens = false;
                CentralTCP.FimConexao(this);
            }
        }

        public bool EnviarMensagem(string asMensagem)
        {
            try
            {
                iswEnvia.WriteLine(asMensagem);
                iswEnvia.Flush();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public void FechaConexao()
        {
            itcConexao.Close();

            isrRecebe.Close();
            isrRecebe.Dispose();

            iswEnvia.Close();
            iswEnvia.Dispose();
        }
    }
}