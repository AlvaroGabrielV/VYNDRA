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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}

