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

        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public bool SalvoComSucesso { get; private set; } = false;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Titulo = txtTitulo.Text;
            Descricao = txtDescricao.Text;

            SalvoComSucesso = true;
            this.Close();
        }
    }
}
