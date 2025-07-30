using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VYNDRA.Classes;

namespace VYNDRA
{
    public partial class PedidosDeAmizade : Form
    {
        public PedidosDeAmizade()
        {
            InitializeComponent();
        }

        private void PedidosDeAmizade_Load(object sender, EventArgs e)
        {

        }

        private void voltar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void sendadd_btn_Click(object sender, EventArgs e)
        {
            string loginDestino = pesquisa_txt.Text.Trim();

            if (string.IsNullOrWhiteSpace(loginDestino))
            {
                MessageBox.Show("Digite o nome de usuário para enviar a solicitação.");
                return;
            }

            try
            {
                
                Users usuarioDestino = Users.BuscarPorLogin(loginDestino);

                if (usuarioDestino == null)
                {
                    MessageBox.Show("Usuário não encontrado.");
                    return;
                }

                string meuId = Sessao.IdUsuario.ToString();
                string idDestino = usuarioDestino.Id.ToString();

                await HubConnection.InvokeAsync("EnviarSolicitacaoAmizade", idDestino, meuId);
                MessageBox.Show("Solicitação enviada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar solicitação: " + ex.Message);
            }
        }
    }
}
