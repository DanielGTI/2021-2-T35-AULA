using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Aula6.Models
{
    public class UsuarioModel
    {
        public int id { get; set; }
        public String nome { get; set; }
        public String senha { get; set; }


        readonly String connectionString = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=AVA;Integrated Security=True";

        public bool Login()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                //                    select id from usuario where nome =    'daniel'    and senha =     '123';
                String sqlConsulta = "SELECT id FROM usuario where nome = '" + nome + "' and senha = '" + senha + "' ";
                SqlCommand sqlCmd = new SqlCommand(sqlConsulta, sqlCon);

                SqlDataReader rdLogin = sqlCmd.ExecuteReader();
                rdLogin.Read();

                if (rdLogin.HasRows)
                    return true;
                else
                    return false;
            }


        }
    }
}
