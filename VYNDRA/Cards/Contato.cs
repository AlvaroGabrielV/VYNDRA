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

        private void lb_mensagem_Click(object sender, EventArgs e)
        {

        }
    }
}
