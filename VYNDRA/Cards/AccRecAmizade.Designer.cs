namespace VYNDRA.Cards
{
    partial class AccRecAmizade
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            foto_user = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            aceitar_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            recusar_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            user_txt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)foto_user).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // foto_user
            // 
            foto_user.ImageRotate = 0F;
            foto_user.Location = new Point(10, 9);
            foto_user.Name = "foto_user";
            foto_user.ShadowDecoration.CustomizableEdges = customizableEdges1;
            foto_user.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            foto_user.Size = new Size(45, 45);
            foto_user.SizeMode = PictureBoxSizeMode.Zoom;
            foto_user.TabIndex = 0;
            foto_user.TabStop = false;
            // 
            // aceitar_btn
            // 
            aceitar_btn.DisabledState.BorderColor = Color.DarkGray;
            aceitar_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            aceitar_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            aceitar_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            aceitar_btn.FillColor = Color.FromArgb(47, 201, 8);
            aceitar_btn.Font = new Font("Segoe UI", 9F);
            aceitar_btn.ForeColor = Color.White;
            aceitar_btn.Image = Properties.Resources.check;
            aceitar_btn.Location = new Point(192, 15);
            aceitar_btn.Name = "aceitar_btn";
            aceitar_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            aceitar_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            aceitar_btn.Size = new Size(35, 35);
            aceitar_btn.TabIndex = 2;
            aceitar_btn.Click += aceitar_btn_Click;
            // 
            // recusar_btn
            // 
            recusar_btn.DisabledState.BorderColor = Color.DarkGray;
            recusar_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            recusar_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            recusar_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            recusar_btn.FillColor = Color.FromArgb(186, 22, 22);
            recusar_btn.Font = new Font("Segoe UI", 9F);
            recusar_btn.ForeColor = Color.White;
            recusar_btn.Image = Properties.Resources.close;
            recusar_btn.Location = new Point(235, 15);
            recusar_btn.Name = "recusar_btn";
            recusar_btn.ShadowDecoration.CustomizableEdges = customizableEdges3;
            recusar_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            recusar_btn.Size = new Size(35, 35);
            recusar_btn.TabIndex = 2;
            recusar_btn.Click += recusar_btn_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 25;
            guna2Panel1.Controls.Add(user_txt);
            guna2Panel1.Controls.Add(recusar_btn);
            guna2Panel1.Controls.Add(aceitar_btn);
            guna2Panel1.Controls.Add(foto_user);
            guna2Panel1.CustomizableEdges = customizableEdges4;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.FillColor = Color.FromArgb(0, 2, 123, 172);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2Panel1.Size = new Size(284, 65);
            guna2Panel1.TabIndex = 3;
            // 
            // user_txt
            // 
            user_txt.BackColor = Color.Transparent;
            user_txt.Font = new Font("Segoe UI", 12F);
            user_txt.ForeColor = Color.White;
            user_txt.Location = new Point(60, 20);
            user_txt.Name = "user_txt";
            user_txt.Size = new Size(37, 23);
            user_txt.TabIndex = 3;
            user_txt.Text = "nada";
            // 
            // AccRecAmizade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 39, 50);
            Controls.Add(guna2Panel1);
            Name = "AccRecAmizade";
            Size = new Size(284, 65);
            ((System.ComponentModel.ISupportInitialize)foto_user).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2CirclePictureBox foto_user;
        public Guna.UI2.WinForms.Guna2CircleButton aceitar_btn;
        public Guna.UI2.WinForms.Guna2CircleButton recusar_btn;
        private Guna.UI2.WinForms.Guna2HtmlLabel user_txt;
    }
}
