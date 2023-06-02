using MySql.Data.MySqlClient;
using System;
using System.Configuration;

 

namespace AppBanco
{
    internal class Banco
    {

        private readonly MySqlConnection Conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["Aula5"].ConnectionString);
        MySqlCommand cmd = new MySqlCommand();
        public void Open()
        {
            if(Conexao.State == System.Data.ConnectionState.Closed) { }
            Conexao.Open();

        }

        public MySqlDataReader ExecuteReadSql(string strQuery)
        {

            cmd.CommandText = strQuery;
            cmd.Connection = Conexao;
            MySqlDataReader leitor = cmd.ExecuteReader();
            return leitor;
        }

        public void SQLinsert(string strQuery)
        {

            cmd.CommandText = strQuery;
            cmd.Connection = Conexao;
            cmd.ExecuteNonQuery();


        }
        public string ExecuteScalarSql (string strQuery)
            {
            cmd.CommandText = strQuery;
            cmd.Connection = Conexao;
            string strRetorno = Convert.ToString (cmd.ExecuteScalar());
            if (strRetorno.Length < 1)
            {
               
                return strRetorno = "";
            }
            return strRetorno;

           
        }
        public void Close()
        {

            if (Conexao.State == System.Data.ConnectionState.Open) { }
            Conexao.Close();
        
        }
    }
}
