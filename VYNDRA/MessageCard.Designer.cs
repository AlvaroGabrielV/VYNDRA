namespace VYNDRA
{
    partial class MessageCard
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblHoras = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            user_picture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_picture).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.AutoSize = true;
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 35;
            guna2Panel1.Controls.Add(lblMessage);
            guna2Panel1.Controls.Add(lblHoras);
            guna2Panel1.Controls.Add(lblUser);
            guna2Panel1.Controls.Add(user_picture);
            guna2Panel1.CustomizableEdges = customizableEdges2;
            guna2Panel1.FillColor = Color.Silver;
            guna2Panel1.Location = new Point(14, 8);
            guna2Panel1.Margin = new Padding(10, 9, 10, 9);
            guna2Panel1.MaximumSize = new Size(643, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Panel1.Size = new Size(643, 66);
            guna2Panel1.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Location = new Point(88, 34);
            lblMessage.Margin = new Padding(2, 2, 2, 15);
            lblMessage.MaximumSize = new Size(546, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(56, 17);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "mensagm";
            // 
            // lblHoras
            // 
            lblHoras.BackColor = Color.Transparent;
            lblHoras.Location = new Point(561, 7);
            lblHoras.Margin = new Padding(2, 2, 2, 2);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(34, 17);
            lblHoras.TabIndex = 1;
            lblHoras.Text = "Horas\r\n";
            // 
            // lblUser
            // 
            lblUser.BackColor = Color.Transparent;
            lblUser.Location = new Point(88, 7);
            lblUser.Margin = new Padding(2, 2, 2, 2);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(43, 17);
            lblUser.TabIndex = 1;
            lblUser.Text = "Usuario";
            // 
            // user_picture
            // 
            user_picture.ImageRotate = 0F;
            user_picture.Location = new Point(11, 5);
            user_picture.Margin = new Padding(2, 2, 2, 2);
            user_picture.Name = "user_picture";
            user_picture.ShadowDecoration.CustomizableEdges = customizableEdges1;
            user_picture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            user_picture.Size = new Size(62, 56);
            user_picture.SizeMode = PictureBoxSizeMode.Zoom;
            user_picture.TabIndex = 0;
            user_picture.TabStop = false;
            // 
            // MessageCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(guna2Panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MessageCard";
            Size = new Size(672, 83);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)user_picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMessage;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUser;
        private Guna.UI2.WinForms.Guna2CirclePictureBox user_picture;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHoras;
    }
}
