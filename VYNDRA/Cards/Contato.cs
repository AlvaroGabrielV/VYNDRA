using System;
using System.Drawing;
using System.Windows.Forms;
using VYNDRA.Classes;
using VYNDRA.Properties; // para StatusUsuarios

namespace VYNDRA.Cards
{
    public partial class Contato : UserControl
    {
        public Contato()
        {
            InitializeComponent();
        }

        public int idContato;
        public string nomeContato;
        public Image fotoContato;

        public int IdContato
        {
            get { return idContato; }
            set
            {
                idContato = value;
                fotocontato_box.Tag = value;

                // Atualiza o status inicial
                SetStatus(StatusUsuarios.EstaOnline(value));

                // Escuta eventos globais
                StatusUsuarios.UsuarioFicouOnline += OnUsuarioOnline;
                StatusUsuarios.UsuarioFicouOffline += OnUsuarioOffline;
            }
        }

        public string NomeContato
        {
            get { return nomeContato; }
            set
            {
                nomeContato = value;
                lb_nomedocontato.Text = value;
            }
        }

        public Image FotoContato
        {
            get { return fotoContato; }
            set
            {
                fotoContato = value;
                fotocontato_box.Image = value;
            }
        }

        public event EventHandler<int> ContatoSelecionado;

        private void clicar_contato_Click(object sender, EventArgs e)
        {
            ContatoSelecionado?.Invoke(this, idContato);
        }

        public void SetStatus(bool online)
        {
            picStatus.Image = online
                ? Properties.Resources.online_status
                : Properties.Resources.offline_status;
        }


        public void OnUsuarioOnline(int id)
        {
            if (id == IdContato)
                SetStatus(true);
        }

        public void OnUsuarioOffline(int id)
        {
            if (id == IdContato)
                SetStatus(false);
        }

        public void AtualizarStatusOnline(bool online)
        {
            if (online)
            {
                picStatus.BackColor = Resources.online_status != null ? Color.Green : Color.Green;
            }
            else
            {
                picStatus.Image = Resources.offline_status != null ? Resources.offline_status : null;
            }
        }

        private void Contato_Load(object sender, EventArgs e)
        {
            lb_nomedocontato.Text = nomeContato;
            fotocontato_box.Image = fotoContato;
            SetStatus(StatusUsuarios.EstaOnline(idContato));

        }
    }
}
