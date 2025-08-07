using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VYNDRA
{
    public partial class MessageCard : UserControl
    {
        public MessageCard()
        {
            InitializeComponent();
        }

        public Image Imagem 
        {
            get { return user_picture.Image; }
            set { user_picture.Image = value; }
        }

        public string Usuario
        {
            get { return lblUser.Text; }
            set { lblUser.Text = value; }
        }

        public string Mensagem
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }
        
        public DateTime Horario
        {
            get { return Convert.ToDateTime(lblHoras.Text); }
            set { lblHoras.Text = value.ToString("HH:mm"); }
        }

    }
}
