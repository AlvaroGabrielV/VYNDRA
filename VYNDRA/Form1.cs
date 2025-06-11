
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Windows.Forms;

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
                    lstMensagens.Items.Add($"{usuario}: {mensagem}");
                }));
            });

            try
            {
                await connection.StartAsync();
                lstMensagens.Items.Add("Conectado ao servidor!");
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
            }
        }
    }
}
