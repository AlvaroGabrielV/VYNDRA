
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

            connection.On<string, string, string>("ReceberMensagem", (imagem, usuario, mensagem) =>
            {
                this.Invoke((Action)(() =>
                {
                    criarCard(imagem, usuario, mensagem);
                }));
            });

            try
            {
                await connection.StartAsync();
                criarCard("https://icons.veryicon.com/png/o/miscellaneous/logo-design-of-lingzhuyun/icon-correct-24-1.png", "Sistema", "Conectado com sucesso!");
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

                string user_image = "https://i.pinimg.com/originals/a9/a4/ec/a9a4ec03fa9afc407028ca40c20ed774.jpg";

                if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(mensagem))
                {
                    await connection.InvokeAsync("EnviarMensagem",user_image, usuario, mensagem);
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

        public void criarCard(string imagem, string usuario, string mensagem)
        {
            MessageCard msg = new MessageCard();
            msg.SetDados(imagem, usuario, mensagem);

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
