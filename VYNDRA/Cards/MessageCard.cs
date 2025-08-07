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

<<<<<<< HEAD
        public string Usuario
        {
=======
        public Image Imagem 
        {
            get { return user_picture.Image; }
            set { user_picture.Image = value; }
        }

        public string Usuario
        {
>>>>>>> c490c4d4b3909b8118fbe60009dfe57956049685
            get { return lblUser.Text; }
            set { lblUser.Text = value; }
        }

        public string Mensagem
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }
<<<<<<< HEAD

        public DateTime Horario
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(lblHoras.Text, out dt))
                    return dt;
                return DateTime.MinValue;
            }
            set
            {
                lblHoras.Text = value.ToString("HH:mm");
            }
        }

        public Image Imagem
        {
            get { return user_picture.Image; }
            set { user_picture.Image = value; }
        }       
=======
        
        public DateTime Horario
        {
            get { return Convert.ToDateTime(lblHoras.Text); }
            set { lblHoras.Text = value.ToString("HH:mm"); }
        }

>>>>>>> c490c4d4b3909b8118fbe60009dfe57956049685
    }
}
