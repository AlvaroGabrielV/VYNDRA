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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtNomeExibicao.Text) || String.IsNullOrWhiteSpace(txtSenha.Text) || String.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Erro - Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                Users usuario = new Users();
                usuario.NomeExibicao = txtNomeExibicao.Text;
                usuario.Email = txtEmail.Text;
                usuario.Usuario = txtUsuario.Text;
                usuario.DefinirSenha(txtSenha.Text);
                DateTime dataNascimento = DataNascimentoPicker.Value.Date;
                DateTime hoje = DateTime.Today;
                DateTime dataMinima = hoje.AddYears(-18);

                if (dataNascimento > dataMinima)
                {
                    MessageBox.Show("Você deve ter pelo menos 18 anos para se cadastrar.", "Erro - Idade inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    usuario.DataNascimento = DataNascimentoPicker.Value.Date;
                }

                if (usuario.CadastrarUsuario())
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso - Cadastrar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();

                    Login login = new Login();
                    login.Show();
                    this.Close();
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
            txtEmail.Clear();
            txtSenha.Clear();
            txtUsuario.Clear();
            txtNomeExibicao.Clear();
            DataNascimentoPicker.ResetText();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOcultarSenha_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;
        }
    }
}
