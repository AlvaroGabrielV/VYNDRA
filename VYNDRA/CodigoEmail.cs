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
    public partial class CodigoEmail : Form
    {
        private string EmailUsuario;
        public CodigoEmail(string email)
        {
            InitializeComponent();
            EmailUsuario = email;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string codigoDigitado = txtCodigo.Text.Trim();

            if (string.IsNullOrEmpty(codigoDigitado))
            {
                MessageBox.Show("Digite o código.", "Aviso");
                return;
            }

            int id = CodigosRecuperacao.BuscarIdPorEmail(EmailUsuario);
            if (id <= 0)
            {
                MessageBox.Show("Usuário não encontrado.");
                return;
            }

            bool valido = CodigosRecuperacao.VerificarCodigo(id, codigoDigitado);

            if (valido)
            {
                MessageBox.Show("Código válido! Redefina sua senha.");
                this.Hide();
                new RedefinirSenha(EmailUsuario).ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Código inválido ou expirado.");
            }
        }
        // Permite mover a janela clicando e arrastando um painel
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private void CodigoEmail_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

