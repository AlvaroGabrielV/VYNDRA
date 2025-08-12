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
            get { return lblUsuario.Text; }
            set { lblUsuario.Text = value; }
        }

        public string Mensagem
        {
            get { return lblMensagem.Text; }
            set { lblMensagem.Text = value; }
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
            get { return FotoUsuario.Image; }
            set { FotoUsuario.Image = value; }
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            lblMensagem = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblHoras = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            FotoUsuario = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2Panel2.SuspendLayout();
            ((ISupportInitialize)FotoUsuario).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel2
            // 
            guna2Panel2.AutoSize = true;
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.BorderRadius = 35;
            guna2Panel2.Controls.Add(lblMensagem);
            guna2Panel2.Controls.Add(lblHoras);
            guna2Panel2.Controls.Add(lblUsuario);
            guna2Panel2.Controls.Add(FotoUsuario);
            guna2Panel2.CustomizableEdges = customizableEdges5;
            guna2Panel2.FillColor = Color.Silver;
            guna2Panel2.Location = new Point(5, 6);
            guna2Panel2.Margin = new Padding(10, 9, 10, 9);
            guna2Panel2.MaximumSize = new Size(643, 0);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel2.Size = new Size(643, 66);
            guna2Panel2.TabIndex = 1;
            // 
            // lblMensagem
            // 
            lblMensagem.BackColor = Color.Transparent;
            lblMensagem.Location = new Point(88, 34);
            lblMensagem.Margin = new Padding(2, 2, 2, 15);
            lblMensagem.MaximumSize = new Size(546, 0);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(56, 17);
            lblMensagem.TabIndex = 2;
            lblMensagem.Text = "mensagm";
            // 
            // lblHoras
            // 
            lblHoras.BackColor = Color.Transparent;
            lblHoras.Location = new Point(561, 7);
            lblHoras.Margin = new Padding(2);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(34, 17);
            lblHoras.TabIndex = 1;
            lblHoras.Text = "Horas\r\n";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Location = new Point(88, 7);
            lblUsuario.Margin = new Padding(2);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(43, 17);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // FotoUsuario
            // 
            FotoUsuario.ImageRotate = 0F;
            FotoUsuario.Location = new Point(11, 5);
            FotoUsuario.Margin = new Padding(2);
            FotoUsuario.Name = "FotoUsuario";
            FotoUsuario.ShadowDecoration.CustomizableEdges = customizableEdges4;
            FotoUsuario.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            FotoUsuario.Size = new Size(62, 56);
            FotoUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            FotoUsuario.TabIndex = 0;
            FotoUsuario.TabStop = false;
            // 
            // MessageCard
            // 
            Controls.Add(guna2Panel2);
            Margin = new Padding(15);
            Name = "MessageCard";
            Padding = new Padding(15);
            Size = new Size(657, 79);
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ((ISupportInitialize)FotoUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMensagem;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHoras;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsuario;
        private Guna.UI2.WinForms.Guna2CirclePictureBox FotoUsuario;
    }
}
