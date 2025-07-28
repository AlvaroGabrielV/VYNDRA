using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VYNDRA.Classes;

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

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil(idUsuario);
            perfil.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Close();
        }
    }
}
