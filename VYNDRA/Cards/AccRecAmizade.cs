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
    public partial class AccRecAmizade : UserControl
    {
        public string Username
        {
            get { return user_txt.Text; }
            set { user_txt.Text = value; }
        }

        public Image UserPhoto
        {
            get { return foto_user.Image; }
            set { foto_user.Image = value; }
        }

        
        public int UsuarioId { get; set; }

        public Guna.UI2.WinForms.Guna2CircleButton BtnAceitar => aceitar_btn;
        public Guna.UI2.WinForms.Guna2CircleButton BtnRecusar => recusar_btn;
        public AccRecAmizade()
        {
            InitializeComponent();
        }

        private void recusar_btn_Click(object sender, EventArgs e)
        {

        }

        private void aceitar_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
