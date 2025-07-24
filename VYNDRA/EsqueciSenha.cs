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
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;


namespace VYNDRA
{

    public partial class EsqueciSenha : Form
    {
        public EsqueciSenha()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string email = txtEmailRecuperacao.Text.Trim();

            int id = CodigosRecuperacao.BuscarIdPorEmail(email);

            if (id <= 0)
            {
                MessageBox.Show("Email não encontrado", "Erro - Não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; ;
            }

            string codigo = CodigosRecuperacao.GerarCodigo();
            CodigosRecuperacao.SalvarNoBanco(id, codigo);
            CodigosRecuperacao.EnviarPorEmail(email, codigo);

            MessageBox.Show("Email enviado com sucesso", "Sucesso - Envio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            CodigoEmail cod = new CodigoEmail(email);
            cod.ShowDialog();
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
    }
}
