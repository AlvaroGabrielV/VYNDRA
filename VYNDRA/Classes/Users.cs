using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BCrypt.Net;
using MySql.Data.MySqlClient;
using System.CodeDom;
using System.Data;

namespace VYNDRA.Classes
{
    class Users
    {
        private int id;
        private string email;
        private string senha;
        private string usuario;
        private string nomeexibicao;
        private DateTime datanascimento;
        private string telefone;
        private string instagram;
        private string linkedin;
        private byte[] fotoperfil;
        private byte[] minifotoperfil;
        public byte[] FotoPerfil
        {
            get { return fotoperfil; }
            set { fotoperfil = value; }
        }
        public byte[] MiniFotoPerfil
        {
            get { return minifotoperfil; }
            set { minifotoperfil = value; }
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
            set
            {
                if (!verificarEmail(value))
                    throw new Exception("Email inválido");
                email = value;
            }
        }
        public string SenhaHash
        {
            get { return senha; }
            set { senha = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
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
                string select = "SELECT id,nomeexibicao, telefone, datanascimento, email, usuario, senha FROM usuarios WHERE email = @Login OR usuario = @Login";
                MySqlCommand cmd = new MySqlCommand(select, conexao);
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
                                Id = reader.GetInt32("id"),
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
                    string update = "UPDATE usuarios SET linkedin = @linkedin WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(update, conexao);

                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@linkedin", Linkedin);

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
                    string update = "UPDATE usuarios SET instagram = @instagram WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(update, conexao);

                    cmd.Parameters.AddWithValue("@id", this.Id);
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
                    string update = "UPDATE usuarios SET telefone = @telefone WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(update, conexao);

                    cmd.Parameters.AddWithValue("@id", this.Id);
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

        public bool CarregarRedesSociais()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "SELECT instagram, linkedin, telefone, fotoperfil, minifotoperfil FROM usuarios WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@id", this.Id);

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

                            if (reader["minifotoperfil"] != DBNull.Value)
                            {
                                this.MiniFotoPerfil = (byte[])reader["minifotoperfil"];
                            }
                            else
                            {
                                this.MiniFotoPerfil = null;
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
                    string query = "UPDATE usuarios SET fotoperfil = @fotoperfil, minifotoperfil = @minifotoperfil WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.Add("@fotoperfil", MySqlDbType.Blob).Value = FotoPerfil;
                    cmd.Parameters.Add("@minifotoperfil", MySqlDbType.Blob).Value = MiniFotoPerfil;
                    cmd.Parameters.AddWithValue("@id", Id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public void DefinirSenha(string senhaPura)
        {
            SenhaHash = BCrypt.Net.BCrypt.HashPassword(senhaPura);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public static bool verificarEmail(string email)
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
    }
}
