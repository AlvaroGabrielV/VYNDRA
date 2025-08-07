using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vyndra.Shared;
using VYNDRA.Classes;

namespace VYNDRA.Cards
{
    public partial class Chat : UserControl
    {
        public Chat()
        {
            InitializeComponent();
        }

        private int idContato;
        private string nomeContato;
        private Image fotoContato;
        public int IdContato
        {
            get { return idContato; }
            set
            {
                idContato = value;
                foto_usuario.Tag = value;
            }
        }
        public string NomeContato
        {
            get { return nomeContato; }
            set
            {
                nomeContato = value;
                contato_nome.Text = value;
            }
        }
        public Image FotoContato
        {
            get { return fotoContato; }
            set
            {
                fotoContato = value;
                foto_usuario.Image = value;
            }
        }

        public void CarregarConversa(int idContato)
        {
            var usuario = Users.BuscarPorId(idContato);
            if (usuario != null)
            {
                IdContato = usuario.Id;
                contato_nome.Text = usuario.NomeExibicao;
                foto_usuario.Image = usuario.FotoPerfil != null ? Bitmap.FromStream(new MemoryStream(usuario.FotoPerfil)) : null;

                chat_layout.Controls.Clear();

                var dao = new ChatDAO();
                var mensagens = dao.ObterMensagensEntre(Sessao.IdUsuario, idContato);

                foreach (var msg in mensagens)
                {
                    AdicionarMensagemNaTela(msg.RemetenteId, msg.Texto, msg.Data);
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void send_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = messageBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(texto))
                    return;

                await SignalRService.Connection.InvokeAsync("EnviarMensagemPrivada", Sessao.IdUsuario, IdContato, texto);

                var dao = new ChatDAO();
                dao.SalvarMensagem(Sessao.IdUsuario, IdContato, texto);

                AdicionarMensagemNaTela(Sessao.IdUsuario, texto, DateTime.UtcNow);

                if (chat_layout.Controls.Count > 0)
                {
                    var lastControl = chat_layout.Controls[chat_layout.Controls.Count - 1];
                    chat_scroll.ScrollControlIntoView(lastControl);
                }

                messageBox.Clear();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro ao enviar mensagem: " + ex);
            }
        }


        private void Chat_Load(object sender, EventArgs e)
        {
            SignalRService.MensagemRecebidaPrivada += OnMensagemRecebida;
        }

        private void OnMensagemRecebida(int remetenteId, string mensagem, DateTime dataHora)
        {
            if (remetenteId == IdContato)
            {
                Invoke(new Action(() =>
                {
                    AdicionarMensagemNaTela(remetenteId, mensagem, dataHora);
                    
                }));
            }
        }


        private void AdicionarMensagemNaTela(int remetenteId, string texto, DateTime data)
        {
            var mensagemcard = new MessageCard();

            if (remetenteId == Sessao.IdUsuario)
            {
                 var usuario = Users.BuscarPorId(Sessao.IdUsuario);

                mensagemcard.Imagem = usuario.FotoPerfil != null ? Bitmap.FromStream(new MemoryStream(usuario.FotoPerfil)) : null;
                mensagemcard.Usuario = Sessao.NomeExibicao;
            }
            else
            {
                var usuario = Users.BuscarPorId(IdContato);

                mensagemcard.Imagem = usuario.FotoPerfil != null ? Bitmap.FromStream(new MemoryStream(usuario.FotoPerfil)) : null;
                mensagemcard.Usuario = usuario.NomeExibicao; 
            }

            mensagemcard.Mensagem = texto;

            mensagemcard.Horario = data.ToLocalTime();

            chat_layout.Controls.Add(mensagemcard);
        }


    }
}
