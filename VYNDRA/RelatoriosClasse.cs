using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYNDRA
{
    class RelatoriosClasse
    {
        public int IdRelatorio { get; set; }
        public int IdUsuario { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }

        public void Inserir()
        {
            try
            {

                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "INSERT INTO relatorios (id_usuario, titulo, descricao, datacriacao) VALUES (@id_usuario, @titulo, @descricao, @datacriacao)";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);

                    cmd.Parameters.AddWithValue("@id_usuario", IdUsuario);
                    cmd.Parameters.AddWithValue("@titulo", Titulo);
                    cmd.Parameters.AddWithValue("@descricao", Descricao);
                    cmd.Parameters.AddWithValue("@datacriacao", DataCriacao);

                    cmd.ExecuteNonQuery();
                }
            }   
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro - Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<RelatoriosClasse> ListarPorUsuario(int IdUsuario)
        {
            List<RelatoriosClasse> lista = new List<RelatoriosClasse>();

            using(MySqlConnection conexao = new ConexaoBD().Conectar())
            {
                string query = "SELECT * FROM relatorios WHERE id_usuario = @id_usuario";
                MySqlCommand cmd = new MySqlCommand(query, conexao);

                cmd.Parameters.AddWithValue("@id_usuario", IdUsuario);

                using (var reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        lista.Add(new RelatoriosClasse
                        {
                            IdRelatorio = reader.GetInt32("id"),
                            IdUsuario = reader.GetInt32("id_usuario"),
                            Titulo = reader.GetString("titulo"),
                            Descricao = reader.GetString("descricao"),
                            DataCriacao = reader.GetDateTime("datacriacao")

                        });

                    }
                }
            }
            return lista;
        }

        public bool Atualizar()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "UPDATE relatorios SET titulo=@titulo, descricao=@descricao WHERE id=@id AND id_usuario=@id_usuario";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@titulo", this.Titulo);
                    cmd.Parameters.AddWithValue("@descricao", this.Descricao);
                    cmd.Parameters.AddWithValue("@id", this.IdRelatorio);
                    cmd.Parameters.AddWithValue("@id_usuario", this.IdUsuario);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message, "Erro - Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool Excluir(int idRelatorio)
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "DELETE FROM relatorios WHERE id=@id and id_usuario=@id_usuario";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@id", idRelatorio);
                    cmd.Parameters.AddWithValue("@id_usuario", this.IdUsuario);
                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado>0)
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
                MessageBox.Show("Erro: " + ex.Message, "Erro - Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}

