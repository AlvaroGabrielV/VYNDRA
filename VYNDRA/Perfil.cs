using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using VYNDRA.Classes;

namespace VYNDRA
{
    public partial class Perfil : Form
    {
        private int IdUsuario;
        public Perfil(int IdUsuario)
        {
            InitializeComponent();
            IdUsuario = this.IdUsuario;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(IdUsuario);
            menu.Show();
            this.Close();
        }

        private void BtnMudarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecione uma imagem PNG";
            openFileDialog.Filter = "Imagens PNG (*.png)|*.png";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = openFileDialog.FileName;
                byte[] imagembytes = File.ReadAllBytes(caminhoArquivo);

                Users usuario = new Users();
                usuario.Id = this.IdUsuario;
                usuario.CarregarFotodePerfil(imagembytes);
            }
        }
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            Relatorios relatorios = new Relatorios(IdUsuario);
            relatorios.Show();
            this.Close();
        }


        private void Perfil_Load(object sender, EventArgs e)
        {
            txtEmail.Text = Sessao.Email;
            txtNomeExibicao.Text = Sessao.NomeExibicao;
            txtUsuario.Text = Sessao.UsuarioLogin;

            // Users usuario = Users.CarregarRedesSociaiseFotodePerfil(this.IdUsuario);

            // if (usuario != null)
            // {
            // txtInstagram.Text = usuario.Instagram;
            // txtLinkedin.Text = usuario.Linkedin;
            // txtWhatsapp.Text = usuario.Telefone;

            // if (usuario.FotoPerfil != null)
            // {
            //  using (MemoryStream ms = new MemoryStream(usuario.FotoPerfil))
            // {
            //CpFotodePerfil.Image = Image.FromStream(ms);
        }



        private void txtLinkedin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                string linkedin = txtLinkedin.Text;
                Users usuario = new Users();
                usuario.InserirLinkedin(linkedin);
                usuario.Id = this.IdUsuario;
            }
        }

        private void txtWhatsapp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                txtWhatsapp.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                string telefone = txtWhatsapp.Text;
                Users usuario = new Users();
                usuario.InserirWhatsapp(telefone);
                usuario.Id = this.IdUsuario;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalvarRedesSociais_Click(object sender, EventArgs e)
        {
            try
            {

                Users usuario = new Users();
                usuario.Instagram = txtInstagram.Text;
                usuario.Id = IdUsuario;

                if (usuario.InserirInstagram())
                {
                    MessageBox.Show("Cadastro sucesso");
                }
                else
                {
                    MessageBox.Show("Erro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void txtInstagram_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
