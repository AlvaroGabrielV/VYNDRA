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
using VYNDRA.Cards;
using VYNDRA.Classes;

namespace VYNDRA
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal(int IdUsuario)
        {
            InitializeComponent();
            IdUsuario = Sessao.IdUsuario;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            CarregarCardsDeChat();
            CarregarCards();
            miniFotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;

            var usuario = Users.BuscarPorId(Sessao.IdUsuario);

            if (usuario != null && usuario.FotoPerfil != null && usuario.FotoPerfil.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(usuario.FotoPerfil))
                {
                    miniFotoPerfil.Image = Image.FromStream(ms);
                }
            }
            else
            {
                miniFotoPerfil.Image = null;
            }
        }


        private void contatos_btn_Click(object sender, EventArgs e)
        {
            contatos_panel.Visible = !contatos_panel.Visible;

            if (contatos_panel.Visible)
            {
                contatos_panel.Size = new Size(300, 706);
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void CarregarCardsDeChat()
        {
            var listaAmigos = Users.CarregarChats();

            foreach (var amigo in listaAmigos)
            {
                var card = new Contato
                {
                    IdContato = amigo.Id,
                    NomeContato = amigo.Nome
                };

                if (amigo.FotoPerfil != null && amigo.FotoPerfil.Length > 0)
                {
                    using (var ms = new MemoryStream(amigo.FotoPerfil))
                    {
                        card.FotoContato = Bitmap.FromStream(ms);
                    }
                }

                bool estaOnline = StatusUsuarios.EstaOnline(amigo.Id);
                card.AtualizarStatusOnline(estaOnline);

                if (estaOnline)
                {
                    if (ativos_flow.InvokeRequired)
                    {
                        ativos_flow.Invoke(new Action(() =>
                        {
                            if (!ativos_flow.Controls.Contains(card))
                                ativos_flow.Controls.Add(card);
                        }));
                    }
                    else
                    {
                        if (!ativos_flow.Controls.Contains(card))
                            ativos_flow.Controls.Add(card);
                    }
                }
                else
                {

                    if (contatos_layout.InvokeRequired)
                    {
                        contatos_layout.Invoke(new Action(() =>
                        {
                            if (!contatos_layout.Controls.Contains(card))
                                contatos_layout.Controls.Add(card);
                        }));
                    }
                    else
                    {
                        if (!contatos_layout.Controls.Contains(card))
                            contatos_layout.Controls.Add(card);
                    }
                }

                StatusUsuarios.UsuarioFicouOnline += (id) =>
                {
                    if (id == amigo.Id)
                    {
                        if (ativos_flow.InvokeRequired)
                        {
                            ativos_flow.Invoke(new Action(() =>
                            {
                                card.AtualizarStatusOnline(true);
                                if (!ativos_flow.Controls.Contains(card))
                                    ativos_flow.Controls.Add(card);

                                if (contatos_layout.Controls.Contains(card))
                                    contatos_layout.Controls.Remove(card);
                            }));
                        }
                        else
                        {
                            card.AtualizarStatusOnline(true);
                            if (!ativos_flow.Controls.Contains(card))
                                ativos_flow.Controls.Add(card);

                            if (contatos_layout.Controls.Contains(card))
                                contatos_layout.Controls.Remove(card);
                        }
                    }
                };

                StatusUsuarios.UsuarioFicouOffline += (id) =>
                {
                    if (id == amigo.Id)
                    {
                        if (contatos_layout.InvokeRequired)
                        {
                            contatos_layout.Invoke(new Action(() =>
                            {
                                card.AtualizarStatusOnline(false);
                                if (!contatos_layout.Controls.Contains(card))
                                    contatos_layout.Controls.Add(card);

                                if (ativos_flow.Controls.Contains(card))
                                    ativos_flow.Controls.Add(card);
                            }));
                        }
                        else
                        {
                            card.AtualizarStatusOnline(false);
                            if (!contatos_layout.Controls.Contains(card))
                                contatos_layout.Controls.Add(card);

                            if (ativos_flow.Controls.Contains(card))
                                ativos_flow.Controls.Remove(card);
                        }
                    }
                };

                card.ContatoSelecionado += ContatoSelecionado;
            }
        }





        private void contatos_layout_VisibleChanged(object sender, EventArgs e)
        {
            if (contatos_panel.Visible)
            {
                BuscarContato buscarContato = new BuscarContato();
                contatos_layout.Controls.Clear();
                contatos_layout.Controls.Add(buscarContato);

                CarregarCardsDeChat();

            }
        }

        private void ContatoSelecionado(object sender, int idContato)
        {
            chat_panel.Controls.Clear();

            principal_panel.Visible = false;
            chat_panel.Visible = true;
            chat_panel.Dock = DockStyle.Fill;

            var chat = new Chat();
            chat.CarregarConversa(idContato);

            Debug.WriteLine($"Carregando conversa para o contato com ID: {idContato}");

            chat_panel.Controls.Add(chat);
            chat.Focus();
        }


        private void contatos_layout_DoubleClick(object sender, EventArgs e)
        {
            CarregarCardsDeChat();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal(Sessao.IdUsuario);
            telaPrincipal.Show();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Relatorios relatorio = new Relatorios(Sessao.IdUsuario);
            relatorio.Show();
            this.Close();
        }

        private void miniFotoPerfil_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil(Sessao.IdUsuario);
            perfil.Show();
            this.Close();
        }

        private void CarregarCards()
        {
            relatorios_flow.Controls.Clear();

            List<RelatoriosClasse> relatorios = RelatoriosClasse.ListarPorUsuario(Sessao.IdUsuario);

            foreach (var rel in relatorios)
            {
                CardTarefas card = new CardTarefas();
                card.IdRelatorio = rel.IdRelatorio;
                card.Titulo = rel.Titulo;
                card.Descricao = rel.Descricao;
                card.DataCriacao = rel.DataCriacao;

                relatorios_flow.Controls.Add(card);
                relatorios_flow.Controls.SetChildIndex(card, relatorios_flow.Controls.Count - 1);
            }
        }
    }
}

