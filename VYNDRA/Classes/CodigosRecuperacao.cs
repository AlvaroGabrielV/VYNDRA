using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace VYNDRA.Classes
{
    class CodigosRecuperacao
    {
        private int id;
        private int id_usuario;
        private string codigo;
        private DateTime criado_em;
        private DateTime expiracao;
        private bool usado;
        private static string bd_location = "Server=bd-vyndra.clay4aqaqt45.sa-east-1.rds.amazonaws.com;Database=vyndra_bd;Uid=admin_vyndra;Pwd=vyndrabd;";

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Id_Usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        public string Codigo      
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public DateTime Criado_em
        {
            get { return criado_em; }
            set { criado_em = value; }
        }
        public DateTime Expiracao
        {
            get { return expiracao; }
            set { expiracao = value; }
        }
        public bool Usado
        {
            get { return usado; }
            set { usado = value; }
        }

        public static string GerarCodigo()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }


        public static int BuscarIdPorEmail(string email)
        {
            using (MySqlConnection conn = new MySqlConnection(bd_location))
            {
                conn.Open();
                string query = "SELECT id_usuario FROM usuarios WHERE email = @Email";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        public static void SalvarNoBanco(int idUsuario, string codigo)
        {
            using (MySqlConnection conn = new MySqlConnection(bd_location))
            {
                conn.Open();
                string query = @"INSERT INTO codigos_recuperacao (id_usuario, codigo, expiracao)
                             VALUES (@id_usuario, @codigo, DATE_ADD(NOW(), INTERVAL 3 MINUTE))";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void EnviarPorEmail(string destino, string codigo)
        {
            string remetente = "suportevyndra@gmail.com";
            string senhaApp = "sdkc jnhj vgnq njla"; 

            try
            {
                MailMessage msg = new MailMessage(remetente, destino);
                msg.Subject = "Código de Recuperação";
                msg.Body = $"Seu código de recuperação é: {codigo}\nEle expira em 3 minutos.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(remetente, senhaApp);
                smtp.EnableSsl = true;

                smtp.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message);
            }
        }

        public static bool VerificarCodigo(int idUsuario, string codigo)
        {
            using (MySqlConnection conn = new MySqlConnection(bd_location))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM codigos_recuperacao 
                         WHERE id_usuario = @id AND codigo = @codigo 
                         AND expiracao >= NOW()";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public static bool AtualizarSenha(int idUsuario, string novaSenha)
        {
            using (MySqlConnection conn = new MySqlConnection(bd_location))
            {
                conn.Open();
                string query = "UPDATE usuarios SET senha = @senha WHERE id_usuario = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@senha", novaSenha);
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public static string CriptografarSenha(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }
    }
}
