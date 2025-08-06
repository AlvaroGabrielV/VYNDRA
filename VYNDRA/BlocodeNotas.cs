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
    public partial class BlocodeNotas : Form
    {
        public BlocodeNotas()
        {
            InitializeComponent();
        }

        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public bool SalvoComSucesso { get; private set; } = false;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Titulo = txtTitulo.Text;
            Descricao = txtDescricao.Text;

            SalvoComSucesso = true;
            this.Close();
        }

        private void BlocodeNotas_Load(object sender, EventArgs e)
        {
            txtTitulo.Text = Titulo;
            txtDescricao.Text = Descricao;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
