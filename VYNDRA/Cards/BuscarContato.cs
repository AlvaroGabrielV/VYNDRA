using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VYNDRA.Cards
{
    public partial class BuscarContato : UserControl
    {
        public BuscarContato()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            PedidosDeAmizade pedidosDeAmizade = new PedidosDeAmizade();
            pedidosDeAmizade.Show();
            pedidosDeAmizade.BringToFront();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
