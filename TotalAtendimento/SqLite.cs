using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace TotalAtendimento
{
    class SqLite
    {
        private static SQLiteConnection ioConexao = new SQLiteConnection("Data Source=atendimento.db;");
        private static SQLiteCommand ioComando;

        public SqLite()
        {
        }

        public static void IniciarBancoDados()
        {
            ioConexao.Open();
            ioComando = new SQLiteCommand(ioConexao);
            ExecutaComandos();
        }

        public static int ExecutaComando(string asComando)
        {
            ioComando.CommandText = asComando;
            return ioComando.ExecuteNonQuery();
        }

        public static int ExecutaComando(string asComando, object[] aobParametros)
        {
            ioComando.Parameters.Clear();
            ioComando.CommandText = asComando;

            for (int i = 0; i <= aobParametros.Length - 1; i++)
            {
                SQLiteParameter lpParametro = new SQLiteParameter();

                ioComando.Parameters.Add(lpParametro);

                lpParametro.Value = aobParametros[i];
            }
            
            return ioComando.ExecuteNonQuery();
        }

        public static SQLiteDataReader ExecutaSelect(string asSelect)
        {
            ioComando.CommandText = asSelect;
            return ioComando.ExecuteReader();
        }

        public static SQLiteDataReader ExecutaSelect(string asSelect, object[] aobParametros)
        {
            ioComando.Parameters.Clear();
            ioComando.CommandText = asSelect;

            for (int i = 0; i <= aobParametros.Length -1; i++)
            {
                SQLiteParameter lpParametro = new SQLiteParameter();

                ioComando.Parameters.Add(lpParametro);

                lpParametro.Value = aobParametros[i];
            }

            return ioComando.ExecuteReader();
        }

        public static object ExecutaSelectUnicoResultado(string asSelect)
        {
            ioComando.CommandText = asSelect;
            return ioComando.ExecuteScalar();
        }

        public static object ExecutaSelectUnicoResultado(string asSelect, object[] aobParametros)
        {
            ioComando.Parameters.Clear();
            ioComando.CommandText = asSelect;

            for (int i = 0; i <= aobParametros.Length - 1; i++)
            {
                SQLiteParameter lpParametro = new SQLiteParameter();

                ioComando.Parameters.Add(lpParametro);

                lpParametro.Value = aobParametros[i];
            }

            return ioComando.ExecuteScalar();
        }

        public static DataTable ExecutaSelectGrid(string asSelect)
        {
            return ExecutaSelectGrid(asSelect, new object[0]);
        }

        public static DataTable ExecutaSelectGrid(string asSelect, object[] aobParametros)
        {
            DataTable ldtConsulta = new DataTable();
            SQLiteDataAdapter ldaConsulta = new SQLiteDataAdapter(asSelect, ioConexao);

            for (int i = 0; i <= aobParametros.Length - 1; i++)
            {
                SQLiteParameter lpParametro = new SQLiteParameter();

                ldaConsulta.SelectCommand.Parameters.Add(lpParametro);

                lpParametro.Value = aobParametros[i];
            }

            ldaConsulta.Fill(ldtConsulta);

            return ldtConsulta;
        }

        public static void Finaliza()
        {
            ioConexao.Close();
        }

        private static void ExecutaComandos()
        {
            ExecutaArquivo("Tabelas.sql");
        }

        private static bool ExecutaArquivo(string asArquivo)
        {
            try
            {
                using (StreamReader lsrArquivo = new StreamReader(asArquivo))
                {
                    string lsComando = lsrArquivo.ReadToEnd();

                    ExecutaComando(lsComando);
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
