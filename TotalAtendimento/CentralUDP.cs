using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.ComponentModel;

namespace TotalAtendimento
{
    class CentralUDP
    {
        private static int iiPortaServidor = 9611;
        private static bool ibConectado;
        private static string isIpServidor = GetLocalIPAddress();

        private static Thread TheadUDP;
        private static UdpClient udpServer;
        
        public static void IniciarServidor()
        {
            udpServer = new UdpClient(iiPortaServidor);
            ibConectado = true;
            
            TheadUDP = new Thread(() =>
            {
                while (ibConectado)
                {
                    var remoteEP = new IPEndPoint(IPAddress.Any, iiPortaServidor);
                    try
                    {
                        var data = udpServer.Receive(ref remoteEP);
                        MensagemRecebida(remoteEP.ToString(), Encoding.ASCII.GetString(data, 0, data.Length));
                    }
                    catch (Exception e)
                    {
                        var w32ex = e as Win32Exception;
                        if (w32ex == null)
                        {
                            w32ex = e.InnerException as Win32Exception;
                        }
                        if (w32ex != null)
                        {
                            int code = w32ex.ErrorCode;
                            switch (code)
                            {
                                case 10004:
                                    continue;
                            }
                        }
                    }
                }
            });

            TheadUDP.IsBackground = true;
            TheadUDP.Start();
        }

        private static void MensagemRecebida(string asEndereco, string asMensagem)
        {
            string lsIP = asEndereco.Substring(0, asEndereco.IndexOf(":"));
            int liPorta = int.Parse(asEndereco.Substring(asEndereco.IndexOf(":") + 1));

            if (asMensagem == "SOLICITACAO_SERVIDOR")
            {
                EnviarMensagem(lsIP, liPorta, isIpServidor + ":" + iiPortaServidor.ToString());
            }else if(asMensagem == "close")
            {
                DesconectarServidor();
            }
        }

        public static void EnviarMensagem(string asIP, string asMensagem)
        {
            EnviarMensagem(asIP, iiPortaServidor, asMensagem);
        }

        public static void EnviarMensagem(string asIP, int aiPorta, string asMensagem)
        {
            UdpClient udpClientEnviar = new UdpClient();
            udpClientEnviar.Connect(asIP, aiPorta);
            Byte[] senddata = Encoding.ASCII.GetBytes(asMensagem);
            udpClientEnviar.Send(senddata, senddata.Length);
            udpClientEnviar.Close();
        }

        public static void DesconectarServidor()
        {
            ibConectado = false;
            TheadUDP.Suspend();
            udpServer.Close();
        }

        private static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }
    }

}