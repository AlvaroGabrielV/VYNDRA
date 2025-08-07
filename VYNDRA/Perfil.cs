using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data;
using MySql.Data.MySqlClient;
using VYNDRA.Classes;

namespace VYNDRA
{
    public partial class Perfil : Form
    {
        public Perfil(int IdUsuario)
        {
            InitializeComponent();
            IdUsuario = Sessao.IdUsuario;
        }

        private void BtnMudarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecione uma foto de perfil";
                ofd.Filter = "Imagens (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string caminho = ofd.FileName;

                    // Exibe no PictureBox
                    CpFotodePerfil.Image = Image.FromFile(caminho);
                    miniFotoPerfil.Image = Image.FromFile(caminho);

                    // Converte imagem em byte[]
                    byte[] imagemBytes = File.ReadAllBytes(caminho);

                    Users usuario = new Users();
                    usuario.Id = Sessao.IdUsuario;
                    usuario.FotoPerfil = imagemBytes;
                    Sessao.FotoPerfil = imagemBytes;

                    if (usuario.SalvarFotoPerfil())
                    {
                        MessageBox.Show("Foto de perfil salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao salvar a foto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            txtEmail.Text = Sessao.Email;
            txtNomeExibicao.Text = Sessao.NomeExibicao;
            txtUsuario.Text = Sessao.UsuarioLogin;

<<<<<<< HEAD
            Users usuario = Users.CarregarRedesSociaiseFotodePerfil(this.IdUsuario);

            if (usuario != null)
            {
                txtInstagram.Text = usuario.Instagram;
                txtLinkedin.Text = usuario.Linkedin;
                txtWhatsapp.Text = usuario.Telefone;

                if (usuario.FotoPerfil != null)
                {
                    using (MemoryStream ms = new MemoryStream(usuario.FotoPerfil))
                    {
                        CpFotodePerfil.Image = Image.FromStream(ms);
                    }
                }
            }
        }



        private void txtLinkedin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
=======
            Users usuario = new Users();

            if (usuario.CarregarRedesSociais(Sessao.IdUsuario))
>>>>>>> origin/atualizado-2.2
            {
                txtInstagram.Text = usuario.Instagram;
                txtLinkedin.Text = usuario.Linkedin;
                txtWhatsapp.Text = usuario.Telefone;

                if (usuario.FotoPerfil != null && usuario.FotoPerfil.Length > 0)
                {
                    Sessao.FotoPerfil = usuario.FotoPerfil;

                    using (MemoryStream ms = new MemoryStream(usuario.FotoPerfil))
                    {
                        CpFotodePerfil.Image = Image.FromStream(ms);
                        miniFotoPerfil.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    CpFotodePerfil.Image = null;
                    Sessao.FotoPerfil = null;
                }
            }
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            Relatorios relatorios = new Relatorios(Sessao.IdUsuario);
            relatorios.Show();
            this.Close();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(Sessao.IdUsuario);
            menu.Show();
            this.Close();
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
                string telefoneLimpo = Regex.Replace(txtWhatsapp.Text, @"[^\d]", "");
                bool houveAlteracao = false;

                Users usuario = new Users
                {
                    Id = Sessao.IdUsuario,
                    Instagram = txtInstagram.Text.Trim(),
                    Linkedin = txtLinkedin.Text.Trim(),
                    Telefone = telefoneLimpo
                };

                // Instagram
                if (!string.IsNullOrEmpty(usuario.Instagram) && usuario.Instagram != "Digite aqui....")
                {
                    if (usuario.InserirInstagram())
                    {
                        Sessao.Instagram = usuario.Instagram;
                        houveAlteracao = true;
                    }
                }

                // LinkedIn
                if (!string.IsNullOrEmpty(usuario.Linkedin) && usuario.Linkedin != "Digite aqui....")
                {
                    if (usuario.InserirLinkedin())
                    {
                        Sessao.Linkedin = usuario.Linkedin;
                        houveAlteracao = true;
                    }
                }

                // Telefone
                if (!string.IsNullOrEmpty(usuario.Telefone))
                {
                    if (usuario.InserirTelefone())
                    {
                        Sessao.Telefone = usuario.Telefone;
                        houveAlteracao = true;
                    }
                }

                if (houveAlteracao)
                {
                    MessageBox.Show("Redes sociais salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nenhuma alteração válida foi feita.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro - Redes Sociais", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            EsqueciSenha esqueci = new EsqueciSenha();
            esqueci.ShowDialog();
        }

        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {
            AlterarUsuario alteraruser = new AlterarUsuario();
            alteraruser.ShowDialog();

            Perfil_Load(this, EventArgs.Empty);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
