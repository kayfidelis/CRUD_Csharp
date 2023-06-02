using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    internal class UsuarioDAO
    {
        Banco db = new Banco();
        public void Insert(Usuario objUsiario) { 

        string strInsert = string.Format("insert into tbUsuario(NomeUsu, Cargo, DataNasc)" +
            "values('{0}','{1}',  STR_TO_DATE('{2}','%d/%m/%Y %H:%i:%s'));", objUsiario.NomeUsu, objUsiario.Cargo, objUsiario.DataNac);
            db.Open(); 
            db.SQLinsert(strInsert);
            db.Close();
        }

        public void Delete(int Id)
        {
            string drop =  string.Format("delete from  tbUsuario where idUsu = {0} ;",Id);
            db.Open();
            db.SQLinsert(drop);
            db.Close();

        }

        public void UpDate(Usuario objUsiario) 
        {


            string uptade = string.Format( "update tbUsuario set NomeUsu = '{0}', Cargo = '{1}', DataNasc = str_to_date('{2}' ,'%d/%m/%Y %H:%i:%s')  where idUsu = '{3}';", objUsiario.NomeUsu, objUsiario.Cargo, objUsiario.DataNac, objUsiario.IdUsu);
            db.Open();
            db.SQLinsert(uptade);
            db.Close();
        }

        public List<Usuario> SelectList()
        {
            string strSelect = "Select * from tbUsuario;";            
            db.Open();
            MySqlDataReader DR = db.ExecuteReadSql(strSelect);
          
            return ListUsuario(DR);
        }

        private List<Usuario> ListUsuario(MySqlDataReader leitor) 
        {

            var usuarios = new List<Usuario>();


            while (leitor.Read())
            {
                var TempUsuario = new Usuario()
                {
                    IdUsu = int.Parse(leitor["IdUsu"].ToString()),
                    NomeUsu = leitor["NomeUsu"].ToString(),
                    Cargo = leitor["Cargo"].ToString(),
                    DataNac = DateTime.Parse(leitor["DataNasc"].ToString())
                };
                usuarios.Add(TempUsuario);

            };
            
            leitor.Close();
            db.Close();
            return usuarios;
        }


        public  string SelectScalar(int id)
        {
            db.Open();
            string strDado = db.ExecuteScalarSql("Select NomeUsu from tbUsuario where IdUsu = "+id+";"); ;
            db.Close();
            return strDado;
        }

    }
}
