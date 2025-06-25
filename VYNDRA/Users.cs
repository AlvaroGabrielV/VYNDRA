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

namespace VYNDRA
{
    class Users
    {
        private int id;
        private string email;
        private string senha;
        private string usuario;
        private string nomeexibicao;
        private DateTime datanascimento;

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
                    string query = "SELECT id, nomeexibicao, telefone, datanascimento, email, usuario, senha FROM usuarios WHERE email = @Login OR usuario = @Login";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
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
    }
}
