using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using VYNDRA.Classes;

namespace VYNDRA.Classes
{
    public class ChatDAO
    {
        private readonly string _connStr = "server=bd-vyndra.clay4aqaqt45.sa-east-1.rds.amazonaws.com; database=vyndra_bd; uid=admin_vyndra; pwd='vyndrabd'";

        public void SalvarMensagem(int remetenteId, int destinatarioId, string mensagem)
        {
            try
            {
                using var conn = new MySqlConnection(_connStr);
                conn.Open();

                string sql = @"INSERT INTO mensagens_privadas (remetente_id, destinatario_id, mensagem)
                       VALUES (@rem, @dest, @msg)";
                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@rem", remetenteId);
                cmd.Parameters.AddWithValue("@dest", destinatarioId);
                cmd.Parameters.AddWithValue("@msg", mensagem);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    throw new Exception("Mensagem não salva.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Erro ao salvar mensagem: {ex.Message}");
            }
        }

        public List<Mensagem> BuscarMensagens(int usuario1Id, int usuario2Id)
        {
            var mensagens = new List<Mensagem>();

            try
            {
                using var conn = new MySqlConnection(_connStr);
                conn.Open();

                string sql = @"
            SELECT * FROM mensagens_privadas 
            WHERE (remetente_id = @u1 AND destinatario_id = @u2)
               OR (remetente_id = @u2 AND destinatario_id = @u1)
            ORDER BY data_envio ASC";

                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u1", usuario1Id);
                cmd.Parameters.AddWithValue("@u2", usuario2Id);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    mensagens.Add(new Mensagem
                    {
                        RemetenteId = Convert.ToInt32(reader["remetente_id"]),
                        DestinatarioId = Convert.ToInt32(reader["destinatario_id"]),
                        Texto = reader["mensagem"].ToString(),
                        Data = Convert.ToDateTime(reader["data_envio"])
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Erro ao buscar mensagens: {ex.Message}");
            }

            return mensagens;
        }
    }
}
