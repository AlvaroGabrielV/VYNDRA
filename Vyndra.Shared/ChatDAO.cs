using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using VYNDRA.Classes;

namespace VYNDRA.Classes
{
    public class ChatDAO
    {

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

            return mensagens;
        }
    }
}
