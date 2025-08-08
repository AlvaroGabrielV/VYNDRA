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

        }

        private void contatos_btn_Click(object sender, EventArgs e)
        {
            contatos_panel.Visible = !contatos_panel.Visible;
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

                card.ContatoSelecionado += ContatoSelecionado;

                Debug.WriteLine("Adicionando card de contato: " + amigo.Nome);
                contatos_layout.Controls.Add(card);
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

            var chat = new Chat();
            chat.Dock = DockStyle.Fill;
            chat.CarregarConversa(idContato);
            Debug.WriteLine("Carregando conversa para o contato com ID: " + idContato);

            chat_panel.Controls.Add(chat);
        }

        private void contatos_layout_DoubleClick(object sender, EventArgs e)
        {
            CarregarCardsDeChat();
        }
    }
}
