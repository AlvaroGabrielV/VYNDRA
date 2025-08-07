using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            }
        }
<<<<<<< HEAD
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


=======

        private void lb_mensagem_Click(object sender, EventArgs e)
        {

        }
>>>>>>> 13f7adbbca1df4a99c3f2065578f22ef31759b92
    }
}
