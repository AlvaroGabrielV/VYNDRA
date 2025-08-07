using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using VYNDRA.Classes;

namespace VYNDRA
{
    public partial class RedefinirSenha : Form
    {
        private string EmailUsuario;
        public RedefinirSenha(string email)
        {
            InitializeComponent();
            EmailUsuario = email;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string senhaNova = txtSenha.Text.Trim();
            string senhaConfirma = txtConfirmarSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(senhaNova) || string.IsNullOrWhiteSpace(senhaConfirma))
            {
                MessageBox.Show("Preencha os dois campos.", "Aviso");
                return;
            }

            if (senhaNova != senhaConfirma)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro");
                return;
            }

            string senhaCriptografada = CodigosRecuperacao.CriptografarSenha(senhaNova);

            int id = CodigosRecuperacao.BuscarIdPorEmail(EmailUsuario);
            if (id <= 0)
            {
                MessageBox.Show("Usuário não encontrado.");
                return;
            }

            bool atualizado = CodigosRecuperacao.AtualizarSenha(id, senhaCriptografada);

            if (atualizado)
            {
                MessageBox.Show("Senha atualizada com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar senha.");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOcultarSenha_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;

        }

        private void btnOcultarSenha1_Click(object sender, EventArgs e)
        {
            txtConfirmarSenha.UseSystemPasswordChar = !txtConfirmarSenha.UseSystemPasswordChar;
        }

        // Permite mover a janela clicando e arrastando um painel
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private void RedefinirSenha_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
