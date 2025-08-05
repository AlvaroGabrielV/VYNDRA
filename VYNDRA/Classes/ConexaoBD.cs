using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYNDRA.Classes
{
    class ConexaoBD
    {
        private string conexaoBanco = "server=localhost; database=tcc; uid=root; pwd=''";//" server=bd-vyndra.clay4aqaqt45.sa-east-1.rds.amazonaws.com; database=vyndra_bd; uid=admin_vyndra; pwd='vyndrabd'";






        public MySqlConnection Conectar()
        {
            MySqlConnection conexao = new MySqlConnection(conexaoBanco);

            conexao.Open();

            return conexao;
        }
    }
}
