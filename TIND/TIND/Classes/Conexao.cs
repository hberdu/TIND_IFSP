using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TIND
{
    class Conexao
    {
        public SqlConnection conexao = new SqlConnection();

        public void conectar()
        {
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gygabyte\Documents\TINDIF.mdf";
            conexao.Open();
        }

        public void desconectar()
        {
            conexao.Close();
        }
    }
}
