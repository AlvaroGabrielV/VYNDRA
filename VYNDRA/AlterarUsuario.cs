using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VYNDRA.Classes;

namespace VYNDRA
{
    public partial class AlterarUsuario : Form
    {
        public AlterarUsuario()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNovoNomeExibicao.Text) && string.IsNullOrWhiteSpace(txtNovoUsuario.Text))
                {
                    lblError.Text = "Preencha pelo menos um campo para realizar a alteração!*";
                    return;
                }

                Users usuario = new Users();
                usuario.Id = Sessao.IdUsuario;

                string NovoNomeExibicao = txtNovoNomeExibicao.Text;
                string NovoUsuario = txtNovoUsuario.Text;

                if (!string.IsNullOrWhiteSpace(NovoNomeExibicao) && string.IsNullOrWhiteSpace(NovoUsuario))
                {
                    usuario.NomeExibicao = NovoNomeExibicao;

                    if (usuario.AtualizarNomeExibicao())
                    {
                        Sessao.NomeExibicao = NovoNomeExibicao;
                        this.Close();
                    }
                }

                if (!string.IsNullOrWhiteSpace(NovoUsuario) && string.IsNullOrWhiteSpace(NovoNomeExibicao))
                {
                    usuario.verificarUsuario(NovoUsuario);

                    usuario.Usuario = NovoUsuario;

                    if (usuario.AtualizarUsuario())
                    {
                        Sessao.UsuarioLogin = NovoUsuario;
                        this.Close();
                    }
                }

                if (!string.IsNullOrWhiteSpace(NovoUsuario) && !string.IsNullOrWhiteSpace(NovoNomeExibicao))
                {
                    usuario.verificarUsuario(NovoUsuario);

                    usuario.Usuario = NovoUsuario;
                    usuario.NomeExibicao = NovoNomeExibicao;

                    if (usuario.AtualizarUsuario() && usuario.AtualizarNomeExibicao())
                    {
                        Sessao.UsuarioLogin = NovoUsuario;
                        Sessao.NomeExibicao = NovoNomeExibicao;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar: " + ex.Message, "Erro - Cadastrar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
