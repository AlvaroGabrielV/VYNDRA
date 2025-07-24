using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace VYNDRA
{
    public partial class CardTarefas : UserControl
    {
        public CardTarefas()
        {
            InitializeComponent();

            btnExcluir.Click += btnExcluir_Click;
            TxtTitulo.ReadOnly = true;
            txtDescricao.ReadOnly = true;
            TxtTitulo.BackColor = this.BackColor;
            txtDescricao.BackColor = this.BackColor;

            TxtTitulo.DoubleClick += TxtTitulo_DoubleClick;
            TxtTitulo.Leave += TxtTitulo_Leave;

            txtDescricao.DoubleClick += txtDescricao_DoubleClick;
            txtDescricao.Leave += txtDescricao_Leave;

        }

        public event EventHandler EditarTarefaClicada;

        public event EventHandler<int> ExlcuirTarefasClicado;
        public int IdRelatorio { get; set; }
        public string Titulo
        {
            get => TxtTitulo.Text;
            set => TxtTitulo.Text = value;
        }

        public string Descricao
        {
            get => txtDescricao.Text;
            set => txtDescricao.Text = value;
        }

        public DateTime DataCriacao
        {
            get => DateTime.TryParse(lblDataCriacao.Text, out var data) ? data : DateTime.MinValue;
            set => lblDataCriacao.Text = value.ToString("dd/MM/yyyy HH:mm");
        }

        private void txtDescricao_DoubleClick(object sender, EventArgs e)
        {
            txtDescricao.ReadOnly = false;
            txtDescricao.BackColor = Color.White;
            txtDescricao.Focus();
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            txtDescricao.ReadOnly = true;
            txtDescricao.BackColor = this.BackColor;
        }

        private void TxtTitulo_DoubleClick(object sender, EventArgs e)
        {
            TxtTitulo.ReadOnly = false;
            TxtTitulo.BackColor = Color.White;
            TxtTitulo.Focus();
        }

        private void TxtTitulo_Leave(object sender, EventArgs e)
        {
            TxtTitulo.ReadOnly = true;
            TxtTitulo.BackColor = this.BackColor;
        }

        private void TxtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
                ExlcuirTarefasClicado?.Invoke(this, IdRelatorio);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarTarefaClicada?.Invoke(this, EventArgs.Empty);
        }
    }
}
