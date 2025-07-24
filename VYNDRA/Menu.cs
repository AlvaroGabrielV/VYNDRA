using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VYNDRA
{
    public partial class Menu : Form
    {
        private int idUsuario;
        public Menu(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            Sessao.IdUsuario = idUsuario;
            Relatorios rel = new Relatorios(idUsuario);
            rel.Show();
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }
    }
}
