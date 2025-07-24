using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VYNDRA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtLogin.Text) || String.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Erro - Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string login = txtLogin.Text.Trim();
                string senha = txtSenha.Text;

                Users usuarioLogado = Users.LoginUser(login, senha);

                if (usuarioLogado != null)
                {
                    MessageBox.Show("Login realizado com sucesso!", "Sucesso - Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Sessao.IdUsuario = usuarioLogado.Id;
                    Sessao.NomeExibicao = usuarioLogado.NomeExibicao;
                    Sessao.Email = usuarioLogado.Email;
                    Sessao.UsuarioLogin = usuarioLogado.Usuario;
                    Sessao.DataNascimento = usuarioLogado.DataNascimento;

                    Menu menu = new Menu(Sessao.IdUsuario);
                    menu.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!", "Erro - Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimparCampos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar cadastro" + ex.Message, "Erro - Cadastrar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
            }
        }
        public void LimparCampos()
        {
            txtLogin.Clear();
            txtSenha.Clear();
        }

        private void btnOcultarSenha_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueciSenha esq = new EsqueciSenha();
            esq.ShowDialog();
        }
    }
}
