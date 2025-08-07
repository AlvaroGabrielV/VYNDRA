<<<<<<< HEAD
﻿using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
=======
﻿using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
>>>>>>> c490c4d4b3909b8118fbe60009dfe57956049685
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            SignalRService.MensagemRecebidaPrivada -= OnMensagemRecebida;
            SignalRService.MensagemRecebidaPrivada += OnMensagemRecebida;
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

        private void Chat_Load(object sender, EventArgs e)
        {
            CarregarConversa(idContato);
        }


        public async void CarregarConversa(int contatoId)
        {
            var usuario = Users.BuscarPorId(contatoId);
            if (usuario == null)
            {
<<<<<<< HEAD
                MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IdContato = usuario.Id;
            NomeContato = usuario.NomeExibicao;
            FotoContato = usuario.FotoPerfil != null
                ? Bitmap.FromStream(new MemoryStream(usuario.FotoPerfil))
                : null;

            chat_layout.Controls.Clear();

            SignalRService.MensagensCarregadas += OnMensagensCarregadas;

            try
            {
                await SignalRService.Connection.InvokeAsync("CarregarMensagensPrivadas", Sessao.IdUsuario, IdContato);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar mensagens: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("Erro ao carregar mensagens: " + ex);
            }

            ScrollUltimaMensagem();
        }

        private async void send_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = messageBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(texto)) return;

                await SignalRService.Connection.InvokeAsync("EnviarMensagemPrivada", Sessao.IdUsuario, IdContato, texto);

                messageBox.Clear();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro ao enviar mensagem: " + ex.Message);
            }
        }

        private void OnMensagemRecebida(int remetenteId, int destinatarioId, string mensagem, DateTime dataHora)
        {
            if ((remetenteId == IdContato && destinatarioId == Sessao.IdUsuario) ||
                (remetenteId == Sessao.IdUsuario && destinatarioId == IdContato))
            {
                Invoke(new Action(() =>
                {
                    AdicionarMensagemNaTela(remetenteId, mensagem, dataHora);
                    Debug.WriteLine($"Mensagem recebida no Chat.cs de {remetenteId} para {destinatarioId}: {mensagem}");

                    ScrollUltimaMensagem();
                }));
            }
        }


        private void OnMensagensCarregadas(List<Mensagem> mensagens)
        {
            SignalRService.MensagensCarregadas -= OnMensagensCarregadas;

            Debug.WriteLine($"[Chat] Carregando {mensagens.Count} mensagens.");

            Invoke(new Action(() =>
            {
                chat_layout.Controls.Clear();

                foreach (var msg in mensagens)
                {
                    Debug.WriteLine($"[Chat] Adicionando mensagem: {msg.Texto} de {msg.RemetenteId}");
                    AdicionarMensagemNaTela(msg.RemetenteId, msg.Texto, msg.Data);
                }

                ScrollUltimaMensagem();
            }));
        }

        private void AdicionarMensagemNaTela(int remetenteId, string texto, DateTime data)
        {
            var mensagemcard = new MessageCard
            {
                Mensagem = texto,
                Horario = data.ToLocalTime()
            };

            if (remetenteId == Sessao.IdUsuario)
            {
                var usuario = Users.BuscarPorId(Sessao.IdUsuario);
                mensagemcard.Imagem = usuario?.FotoPerfil != null
                    ? Bitmap.FromStream(new MemoryStream(usuario.FotoPerfil))
                    : null;

                mensagemcard.Usuario = Sessao.NomeExibicao;
=======
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
>>>>>>> c490c4d4b3909b8118fbe60009dfe57956049685
            }
            else
            {
                mensagemcard.Imagem = FotoContato;
                mensagemcard.Usuario = NomeContato;
            }

            chat_layout.Controls.Add(mensagemcard);
            Debug.WriteLine("[Chat] Mensagem adicionada na tela.");
        }

        private void ScrollUltimaMensagem()
        {
            if (chat_layout.Controls.Count > 0)
            {
                var lastControl = chat_layout.Controls[chat_layout.Controls.Count - 1];
                chat_scroll.ScrollControlIntoView(lastControl);
            }
        }

        private void messageBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                send_btn.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                messageBox.Clear();
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
