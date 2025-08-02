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
        private string connString = "server=bd-vyndra.clay4aqaqt45.sa-east-1.rds.amazonaws.com;user=admin_vyndra;password=vyndrabd;database=vyndra_bd";

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
                        DeUsuario = reader.GetInt32("DeUsuario"),
                        ParaUsuario = reader.GetInt32("ParaUsuario"),
                        Status = reader["Status"].ToString(),
                        DataSolicitacao = Convert.ToDateTime(reader["DataSolicitacao"])
                    });
                }
            }
            return pedidos;
        }

        public async Task AceitarPedido(int id)
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                string sql = "UPDATE PedidosAmizade SET Status = 'aceito' WHERE ParaUsuario = @id_aprovante AND DeUsuario = @id_solicitante";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_aprovante", Sessao.IdUsuario);
                cmd.Parameters.AddWithValue("@id_solicitante",id);
                cmd.ExecuteNonQuery();
            }
        }

        public async Task RemoverPedido(int deIdUsuario, int paraIdUsuario)
        {
            using (MySqlConnection conn = new ConexaoBD().Conectar())
            {
                string query = "DELETE FROM PedidosAmizade WHERE de_id = @de AND para_id = @para";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@de", deIdUsuario);
                cmd.Parameters.AddWithValue("@para", paraIdUsuario);

                cmd.ExecuteNonQuery();
            }
        }

        public List<PedidoAmizade> ListarPendentes(int idUsuario)
        {
            var pedidos = new List<PedidoAmizade>();

            using (var conn = new ConexaoBD().Conectar())
            { 

                string query = "SELECT DeUsuario, ParaUsuario FROM PedidosAmizade WHERE ParaUsuario = @idUsuario AND status = 'pendente'";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pedido = new PedidoAmizade
                            {
                                DeUsuario = reader.GetInt32("DeUsuario"),
                                ParaUsuario = reader.GetInt32("ParaUsuario"),
                            };

                            pedidos.Add(pedido);
                        }
                    }
                }
            }

            return pedidos;
        }

    }
}
