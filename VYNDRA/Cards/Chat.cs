using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VYNDRA.Classes;

namespace VYNDRA.Cards
{
    public partial class Chat : UserControl
    {
        public Chat()
        {
            InitializeComponent();
        }

    private int idContato;
    private string nomeContato;
        private Image fotoContato;
        public int IdContato
        {
            get { return idContato; }
            set
            {
                idContato = value;
                foto_usuario.Tag = value;
            }
        }
        public string NomeContato
        {
            get { return nomeContato; }
            set
            {
                nomeContato = value;
                contato_nome.Text = value;
            }
        }
        public Image FotoContato
        {
            get { return fotoContato; }
            set
            {
                fotoContato = value;
                foto_usuario.Image = value; 
            }
        }

        public void CarregarConversa(int idContato)
        {
            var usuario = Users.BuscarPorId(idContato);
            if (usuario != null)
            {
                IdContato = usuario.Id;
                contato_nome.Text = usuario.NomeExibicao;
                foto_usuario.Image = usuario.FotoPerfil != null ? Bitmap.FromStream(new MemoryStream(usuario.FotoPerfil)) : null;
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
