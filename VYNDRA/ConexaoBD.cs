using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYNDRA
{
    class ConexaoBD
    {
        private string conexaoBanco = "server=localhost; database=tcc; uid=root; pwd=''";

        public MySqlConnection Conectar()
        {
            MySqlConnection conexao = new MySqlConnection(conexaoBanco);

            conexao.Open();

            return conexao;
        }
    }
}
