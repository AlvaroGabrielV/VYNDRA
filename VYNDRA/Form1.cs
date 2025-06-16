
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace VYNDRA
{
    public partial class Form1 : Form
    {
        HubConnection connection;

        public Form1()
        {
            InitializeComponent();
            InicializarSignalR();
        }

        private async void InicializarSignalR()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("http://15.228.232.243:80/chatHub")
                .WithAutomaticReconnect()
                .Build();

            connection.On<string, string>("ReceberMensagem", (usuario, mensagem) =>
            {
                this.Invoke((Action)(() =>
                {
                    criarCard(usuario, mensagem);
                }));
            });

            try
            {
                await connection.StartAsync();
                criarCard("Sistema", "Conectado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (connection.State == HubConnectionState.Connected)
            {
                string usuario = "Alvaro" +
                    "";
                string mensagem = txtMensagem.Text.Trim();

                if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(mensagem))
                {
                    await connection.InvokeAsync("EnviarMensagem", usuario, mensagem);
                    txtMensagem.Clear();
                }
            }
            else
            {
                MessageBox.Show("Não conectado ao servidor.");
                InicializarSignalR();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void criarCard(string usuario, string mensagem)
        {
            MessageCard msg = new MessageCard();
            msg.SetDados("https://cdn3.emoji.gg/emojis/7636-steve.png", usuario, mensagem);

            msg_flow.Controls.Add(msg);
        }

        private void txtMensagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnEnviar.PerformClick();
            }
        }   
    }
}
