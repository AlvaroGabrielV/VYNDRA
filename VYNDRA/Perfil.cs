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

                    CpFotodePerfil.Image = Image.FromFile(caminho);
                    miniFotoPerfil.Image = Image.FromFile(caminho);

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
            CarregarDados();
        }
        public void CarregarDados()
        {
            var usuario = Users.BuscarPorId(Sessao.IdUsuario);

            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtEmail.Text = usuario.Email;
            txtNomeExibicao.Text = usuario.NomeExibicao;
            txtUsuario.Text = usuario.Usuario;
            lblDataDeNascimento.Text = usuario.DataNascimento.ToString("dd/MM/yyyy");

            if (usuario.CarregarRedesSociais(Sessao.IdUsuario))
            {
                txtInstagram.Text = usuario.Instagram;
                txtLinkedin.Text = usuario.Linkedin;
                txtWhatsapp.Text = usuario.Telefone;

                if (usuario.FotoPerfil != null)
                {
                    using (MemoryStream ms = new MemoryStream(usuario.FotoPerfil))
                    {
                        CpFotodePerfil.Image = Image.FromStream(ms);
                        miniFotoPerfil.Image = Image.FromStream(ms);
                    }
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
            TelaPrincipal telaPrincipal = new TelaPrincipal(Sessao.IdUsuario);
            telaPrincipal.Show();
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

        private void btnMenssagem_Click(object sender, EventArgs e)
        {
            TelaPrincipal conversas = new TelaPrincipal(Sessao.IdUsuario);
            conversas.Show();
            this.Close();
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
