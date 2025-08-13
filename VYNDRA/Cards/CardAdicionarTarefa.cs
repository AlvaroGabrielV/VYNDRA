using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace VYNDRA
{
    public partial class CardAdicionarTarefa : UserControl
    {
        public event EventHandler BotaoClicado;

        public CardAdicionarTarefa()
        {
            InitializeComponent();
            btnAdicionar.Click += btnAdicionar_Click;
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            BotaoClicado?.Invoke(this, EventArgs.Empty);
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
