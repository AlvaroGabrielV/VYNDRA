using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Data;
using System.Diagnostics;
=======
>>>>>>> c490c4d4b3909b8118fbe60009dfe57956049685
using VYNDRA.Classes;

namespace VYNDRA.Classes
{
    public class ChatDAO
    {
<<<<<<< HEAD
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
=======

        public void SalvarMensagem(int remetenteId, int destinatarioId, string mensagem)
        {
            using (var conexao = new ConexaoBD().Conectar())
            {

                string query = @"
                    INSERT INTO mensagens_privadas (remetente_id, destinatario_id, mensagem)
                    VALUES (@remetente, @destinatario, @mensagem)
                ";

                using (var cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@remetente", remetenteId);
                    cmd.Parameters.AddWithValue("@destinatario", destinatarioId);
                    cmd.Parameters.AddWithValue("@mensagem", mensagem);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public List<(int RemetenteId, string Texto, DateTime Data)> ObterMensagensEntre(int usuario1, int usuario2)
        {
            var mensagens = new List<(int, string, DateTime)>();

            using (var conexao = new ConexaoBD().Conectar())
            {

                string query = @"
                    SELECT remetente_id, mensagem, data_envio
                    FROM mensagens_privadas
                    WHERE (remetente_id = @u1 AND destinatario_id = @u2)
                       OR (remetente_id = @u2 AND destinatario_id = @u1)
                    ORDER BY data_envio
                ";

                using (var cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@u1", usuario1);
                    cmd.Parameters.AddWithValue("@u2", usuario2);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int remetenteId = reader.GetInt32("remetente_id");
                            string texto = reader.GetString("mensagem");
                            DateTime data = reader.GetDateTime("data_envio");

                            mensagens.Add((remetenteId, texto, data));
                        }
                    }
                }
            }
>>>>>>> c490c4d4b3909b8118fbe60009dfe57956049685

            return mensagens;
        }
    }
}
