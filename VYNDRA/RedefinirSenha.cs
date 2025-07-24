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
            Application.Exit();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
