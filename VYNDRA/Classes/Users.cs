using BCrypt.Net;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VYNDRA.Classes
{
    public class Users
    {
        private int id;
        private string email;
        private string senha;
        private string usuario_field;
        private string nomeexibicao;
        private DateTime datanascimento;
        private string telefone;
        private string instagram;
        private string linkedin;
        private byte[] fotoperfil;
<<<<<<< HEAD

=======
>>>>>>> origin/atualizado-2.2
        public byte[] FotoPerfil
        {
            get { return fotoperfil; }
            set { fotoperfil = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Instagram
        {
            get { return instagram; }
            set { instagram = value; }
        }
        public string Linkedin
        {
            get { return linkedin; }
            set { linkedin = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
      
        }
        public string SenhaHash
        {
            get { return senha; }
            set { senha = value; }
        }
        public string Usuario
        {
            get { return usuario_field; }
            set { usuario_field = value; }
        }
        public string NomeExibicao
        {
            get { return nomeexibicao; }
            set { nomeexibicao = value; }
        }
        public DateTime DataNascimento
        {
            get { return datanascimento; }
            set { datanascimento = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public static Users LoginUser(string Login, string senhaDigitada)
        {
            using (MySqlConnection conexao = new ConexaoBD().Conectar())
            {
<<<<<<< HEAD
                string query = "SELECT id_usuario,nomeexibicao, telefone, datanascimento, email, usuario, senha FROM usuarios WHERE email = @Login OR usuario = @Login";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
=======
                string select = "SELECT id_usuario,nomeexibicao, telefone, datanascimento, email, usuario, senha FROM usuarios WHERE email = @Login OR usuario = @Login";
                MySqlCommand cmd = new MySqlCommand(select, conexao);
>>>>>>> origin/atualizado-2.2
                cmd.Parameters.AddWithValue("@Login", Login);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string senhaHash = reader.GetString("senha");

                        if (BCrypt.Net.BCrypt.Verify(senhaDigitada, senhaHash))
                        {
                            return new Users
                            {
                                Id = reader.GetInt32("id_usuario"),
                                NomeExibicao = reader.GetString("nomeexibicao"),
                                SenhaHash = senhaHash,
                                datanascimento = reader.GetDateTime("datanascimento"),
                                Email = reader.GetString("email"),
                                Usuario = reader.GetString("usuario")
                            };
                        }
                    }
                }
            }

            return null; // usuário não encontrado
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public bool CadastrarUsuario()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string insert = "INSERT INTO usuarios (nomeexibicao, email, senha, usuario, datanascimento) values (@nomeexibicao, @email, @senha, @usuario, @datanascimento)";
                    MySqlCommand cmd = new MySqlCommand(insert, conexao);

                    cmd.Parameters.AddWithValue("@nomeexibicao", NomeExibicao);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@senha", SenhaHash);
                    cmd.Parameters.AddWithValue("@usuario", Usuario);
                    cmd.Parameters.AddWithValue("@datanascimento", DataNascimento);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar cadastro -> Método" + ex.Message, "Erro - Cadastrar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public bool InserirLinkedin()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
<<<<<<< HEAD
                    string query = "UPDATE usuarios SET fotoperfil = @fotoperfil WHERE id_usuario = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);

                    cmd.Parameters.AddWithValue("@fotoperfil", fotoemBytes);
                    cmd.Parameters.AddWithValue("@id", Sessao.IdUsuario);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível adicionar a foto -> Método" + ex.Message, "Erro - Adicionar Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public static Users? CarregarRedesSociaiseFotodePerfil(int id)
        {
            using (MySqlConnection conexao = new ConexaoBD().Conectar())
            {
                string select = "SELECT * FROM usuarios WHERE id_usuario = @id";
                MySqlCommand cmd = new MySqlCommand(select, conexao);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader.Read())
                        {
                            byte[] fotoPerfil = null;

                            // Verifica se o campo fotoperfil não é nulo
                            if (!reader.IsDBNull(reader.GetOrdinal("fotoperfil")))
                            {
                                // Lê o Stream do BLOB e converte para byte[]
                                using (var stream = reader.GetStream("fotoperfil"))
                                {
                                    using (var ms = new MemoryStream())
                                    {
                                        stream.CopyTo(ms);  // Copia o Stream para o MemoryStream
                                        fotoPerfil = ms.ToArray();  // Converte para byte[]
                                    }
                                }
                            }

                            Users usuario = new Users
                            {
                                Id = reader.GetInt32("id"),
                                Linkedin = reader.IsDBNull(reader.GetOrdinal("linkedin")) ? "" : reader.GetString("linkedin"),
                                Instagram = reader.IsDBNull(reader.GetOrdinal("instagram")) ? "" : reader.GetString("instagram"),
                                Telefone = reader.IsDBNull(reader.GetOrdinal("telefone")) ? "" : reader.GetString("telefone"),
                                FotoPerfil = fotoPerfil,
                            };




                            return usuario;
                        }
                    }

                }
                return null;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public void InserirLinkedin(string linkedin)
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string update = "UPDATE usuarios set linkedin = @linkedin WHERE id_usuario = @id";
                    MySqlCommand updatecmd = new MySqlCommand(update, conexao);

                    updatecmd.Parameters.AddWithValue("@linkedin", linkedin);
                    updatecmd.Parameters.AddWithValue("@id", Id);
                    updatecmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível adicionar a foto -> Método" + ex.Message, "Erro - Adicionar Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------//

        public bool InserirInstagram()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "UPDATE usuarios set instagram = @instagram WHERE id_usuario = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);

                    cmd.Parameters.AddWithValue("@instagram", Instagram);
                    cmd.Parameters.AddWithValue("@id", Id);
=======
                    string update = "UPDATE usuarios SET linkedin = @linkedin WHERE id_usuario = @id_usuario";
                    MySqlCommand cmd = new MySqlCommand(update, conexao);

                    cmd.Parameters.AddWithValue("@id_usuario", Id);
                    cmd.Parameters.AddWithValue("@linkedin", Linkedin);
>>>>>>> origin/atualizado-2.2

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar cadastro -> Método" + ex.Message, "Erro - Cadastrar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public bool InserirInstagram()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
<<<<<<< HEAD
                    string query = "UPDATE usuarios set telefone = @telefone WHERE id_usuario = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
=======
                    string update = "UPDATE usuarios SET instagram = @instagram WHERE id_usuario = @id_usuario";
                    MySqlCommand cmd = new MySqlCommand(update, conexao);
>>>>>>> origin/atualizado-2.2

                    cmd.Parameters.AddWithValue("@id_usuario", this.Id);
                    cmd.Parameters.AddWithValue("@instagram", Instagram);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar cadastro -> Método" + ex.Message, "Erro - Cadastrar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------//

        public bool InserirTelefone()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string update = "UPDATE usuarios SET telefone = @telefone WHERE id_usuario = @id_usuario";
                    MySqlCommand cmd = new MySqlCommand(update, conexao);

                    cmd.Parameters.AddWithValue("@id_usuario", this.Id);
                    cmd.Parameters.AddWithValue("@telefone", Telefone);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar cadastro -> Método" + ex.Message, "Erro - Cadastrar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//

        public bool CarregarRedesSociais(int IdUsuario)
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "SELECT instagram, linkedin, telefone, fotoperfil FROM usuarios WHERE id_usuario = @id_usuario";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@id_usuario", IdUsuario);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            this.Instagram = reader["instagram"].ToString();
                            this.Linkedin = reader["linkedin"].ToString();
                            this.Telefone = reader["telefone"].ToString();

                            if (reader["fotoperfil"] != DBNull.Value)
                            {
                                this.FotoPerfil = (byte[])reader["fotoperfil"];
                            }
                            else
                            {
                                this.FotoPerfil = null;
                            }
                            return true;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao carregar a foto e as redes sociais. Motivo: " + ex.Message, "Erro - Método", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public bool SalvarFotoPerfil()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "UPDATE usuarios SET fotoperfil = @fotoperfil WHERE id_usuario = @id_usuario";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.Add("@fotoperfil", MySqlDbType.Blob).Value = FotoPerfil;
                    cmd.Parameters.AddWithValue("@id_usuario", Id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public bool AtualizarNomeExibicao()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string update = "UPDATE usuarios SET nomeexibicao = @nomeexibicao WHERE id_usuario = @id_usuario";
                    MySqlCommand cmd = new MySqlCommand(update, conexao);

                    cmd.Parameters.AddWithValue("@id_usuario", this.Id);
                    cmd.Parameters.AddWithValue("@nomeexibicao", NomeExibicao);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar cadastro -> Método" + ex.Message, "Erro - Cadastrar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public bool AtualizarUsuario()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string update = "UPDATE usuarios SET usuario = @usuario WHERE id_usuario = @id_usuario";
                    MySqlCommand cmd = new MySqlCommand(update, conexao);

                    cmd.Parameters.AddWithValue("@id_usuario", this.Id);
                    cmd.Parameters.AddWithValue("@usuario", Usuario);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar cadastro -> Método" + ex.Message, "Erro - Cadastrar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public void DefinirSenha(string senhaPura)
        {
            SenhaHash = BCrypt.Net.BCrypt.HashPassword(senhaPura);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public bool verificarEmail(string email)
        {
            string emailValido = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailValido);
            return regex.IsMatch(email);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public void verificarUsuario(string usuario)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario");
            cmd.Parameters.AddWithValue("@usuario", usuario);
            using (MySqlConnection conexao = new ConexaoBD().Conectar())
            {
                cmd.Connection = conexao;
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    throw new Exception("Usuário já existe!");
                }
            }
        }
<<<<<<< HEAD

        public static Users BuscarPorLogin(string login)
        {
            using (MySqlConnection conn = new ConexaoBD().Conectar())
            {
                string query = "SELECT * FROM usuarios WHERE usuario = @login";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@login", login);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Users
                    {
                        Id = Convert.ToInt32(reader["id_usuario"]),
                        Usuario = reader["usuario"].ToString(),
                        NomeExibicao = reader["nomeexibicao"].ToString()
                        
                    };
                }
            }

            return null;
        }

        public static Users BuscarPorId(int id)
        {
            using (MySqlConnection conn = new ConexaoBD().Conectar())
            {
                string query = "SELECT * FROM usuarios WHERE id_usuario = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            string usuario = reader["usuario"].ToString();
                            UsuarioSession.AdicionarUsuario(id, usuario);


                            byte[] fotoPerfil = null;

                            if (!reader.IsDBNull(reader.GetOrdinal("fotoperfil")))
                            {
                                
                                using (var stream = reader.GetStream("fotoperfil"))
                                {
                                    using (var ms = new MemoryStream())
                                    {
                                        stream.CopyTo(ms); 
                                        fotoPerfil = ms.ToArray();  
                                    }
                                }
                            }

                            return new Users
                            {
                                Id = Convert.ToInt32(reader["id_usuario"]),
                                Usuario = usuario,
                                NomeExibicao = reader["nomeexibicao"].ToString(),
                                FotoPerfil = fotoPerfil
                            };

                        }
                        else
                        {
                            Debug.WriteLine($"[BuscarPorId] Nenhum usuário encontrado para o ID: {id}");
                        }
                    }
                }
                
                catch (Exception ex)
                {
                    Debug.WriteLine($"[BuscarPorId] Erro ao buscar usuário: {ex.Message}");
                }
            }

            return null;
        }

        public static void SincronizarAmizadesAceitas()
        {
            using (var conexao = new ConexaoBD().Conectar())
            {
                var cmd = conexao.CreateCommand();
                cmd.CommandText = @"
            INSERT INTO Amigos (Usuario1, Usuario2)
            SELECT 
                CASE 
                    WHEN DeUsuario < ParaUsuario THEN DeUsuario 
                    ELSE ParaUsuario 
                END AS Usuario1,
                CASE 
                    WHEN DeUsuario > ParaUsuario THEN DeUsuario 
                    ELSE ParaUsuario 
                END AS Usuario2
            FROM PedidosAmizade
            WHERE Status = 'aceito'
            AND NOT EXISTS (
                SELECT 1 FROM Amigos a
                WHERE 
                    (a.Usuario1 = CASE WHEN DeUsuario < ParaUsuario THEN DeUsuario ELSE ParaUsuario END AND
                     a.Usuario2 = CASE WHEN DeUsuario > ParaUsuario THEN DeUsuario ELSE ParaUsuario END)
            );
        ";

                cmd.ExecuteNonQuery();
            }
        }

        public static List<(int Id, string Nome, byte[] FotoPerfil)> CarregarChats()
        {
            var amigos = new List<(int, string, byte[])>();

            using (var conexao = new ConexaoBD().Conectar())
            {
                string sql = @"
            SELECT u.id_usuario, u.nomeexibicao, u.fotoperfil
            FROM Amigos a
            JOIN usuarios u ON 
                (u.id_usuario = a.Usuario1 AND a.Usuario2 = @idUsuario) OR
                (u.id_usuario = a.Usuario2 AND a.Usuario1 = @idUsuario)
        ";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", Sessao.IdUsuario);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id_usuario");
                            string nome = reader.GetString("nomeexibicao");

                            byte[] fotoPerfil = null;

                            if (!reader.IsDBNull(reader.GetOrdinal("fotoperfil")))
                            {
                                using (var stream = reader.GetStream("fotoperfil"))
                                using (var ms = new MemoryStream())
                                {
                                    stream.CopyTo(ms);
                                    fotoPerfil = ms.ToArray();
                                }
                            }

                            amigos.Add((id, nome, fotoPerfil));
                        }
                    }
                }
            }

            return amigos;
        }

=======
>>>>>>> origin/atualizado-2.2
    }
}
