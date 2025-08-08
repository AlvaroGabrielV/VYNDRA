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

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            user_picture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            lblUser = new Label();
            lblMessage = new Label();
            lblHoras = new Label();
            guna2Panel1.SuspendLayout();
            ((ISupportInitialize)user_picture).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 35;
            guna2Panel1.Controls.Add(lblHoras);
            guna2Panel1.Controls.Add(lblMessage);
            guna2Panel1.Controls.Add(lblUser);
            guna2Panel1.Controls.Add(user_picture);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.FillColor = Color.Silver;
            guna2Panel1.Location = new Point(24, 20);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(1108, 128);
            guna2Panel1.TabIndex = 0;
            // 
            // user_picture
            // 
            user_picture.BackColor = Color.Transparent;
            user_picture.ImageRotate = 0F;
            user_picture.Location = new Point(34, 18);
            user_picture.Name = "user_picture";
            user_picture.ShadowDecoration.CustomizableEdges = customizableEdges4;
            user_picture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            user_picture.Size = new Size(96, 96);
            user_picture.TabIndex = 0;
            user_picture.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Location = new Point(158, 18);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(72, 25);
            lblUser.TabIndex = 1;
            lblUser.Text = "Usuario";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Location = new Point(158, 89);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(100, 25);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Mensagem";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.BackColor = Color.Transparent;
            lblHoras.Location = new Point(968, 18);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(100, 25);
            lblHoras.TabIndex = 3;
            lblHoras.Text = "Mensagem";
            // 
            // MessageCard
            // 
            Controls.Add(guna2Panel1);
            Name = "MessageCard";
            Size = new Size(1160, 177);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((ISupportInitialize)user_picture).EndInit();
            ResumeLayout(false);

        }
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblHoras;
        private Label lblMessage;
        private Label lblUser;
        private Guna.UI2.WinForms.Guna2CirclePictureBox user_picture;
    }
}
