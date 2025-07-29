using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VYNDRA.Cards;

namespace VYNDRA
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chat_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void contatos_layout_VisibleChanged(object sender, EventArgs e)
        {
            if (contatos_panel.Visible)
            {
                BuscarContato buscarContato = new BuscarContato();
                contatos_layout.Controls.Add(buscarContato);
            }
            else
            {
                contatos_layout.Controls.Clear();
            }
        }
    }
}
