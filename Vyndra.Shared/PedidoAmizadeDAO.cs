using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace VYNDRA.Classes
{
    public class PedidoAmizadeDAO
    {
        private string connString = "server=SEU_SERVIDOR;user=SEU_USUARIO;password=SUA_SENHA;database=SEU_BANCO";

        public void SalvarPedido(PedidoAmizade pedido)
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                string sql = "INSERT INTO PedidosAmizade (DeUsuario, ParaUsuario) VALUES (@de, @para)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@de", pedido.DeUsuario);
                cmd.Parameters.AddWithValue("@para", pedido.ParaUsuario);
                cmd.ExecuteNonQuery();
            }
        }

        public List<PedidoAmizade> BuscarPendentes(string paraUsuario)
        {
            var pedidos = new List<PedidoAmizade>();
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT * FROM PedidosAmizade WHERE ParaUsuario = @para AND Status = 'pendente'";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@para", paraUsuario);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pedidos.Add(new PedidoAmizade
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        DeUsuario = reader["DeUsuario"].ToString(),
                        ParaUsuario = reader["ParaUsuario"].ToString(),
                        Status = reader["Status"].ToString(),
                        DataSolicitacao = Convert.ToDateTime(reader["DataSolicitacao"])
                    });
                }
            }
            return pedidos;
        }

        public void AceitarPedido(int id)
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                string sql = "UPDATE PedidosAmizade SET Status = 'aceito' WHERE Id = @id";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }

}
