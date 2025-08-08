namespace VYNDRA.Cards
{
    partial class Contato
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lb_nomedocontato = new Guna.UI2.WinForms.Guna2HtmlLabel();
            fotocontato_box = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            clicar_contato = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)fotocontato_box).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lb_nomedocontato
            // 
            lb_nomedocontato.BackColor = Color.Transparent;
            lb_nomedocontato.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lb_nomedocontato.ForeColor = Color.DarkGray;
            lb_nomedocontato.Location = new Point(59, 3);
            lb_nomedocontato.Name = "lb_nomedocontato";
            lb_nomedocontato.Size = new Size(45, 23);
            lb_nomedocontato.TabIndex = 1;
            lb_nomedocontato.Text = "nome";
            // 
            // fotocontato_box
            // 
            fotocontato_box.BackColor = Color.Transparent;
            fotocontato_box.FillColor = Color.LightGray;
            fotocontato_box.ImageRotate = 0F;
            fotocontato_box.Location = new Point(3, 5);
            fotocontato_box.Name = "fotocontato_box";
            fotocontato_box.ShadowDecoration.CustomizableEdges = customizableEdges1;
            fotocontato_box.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            fotocontato_box.Size = new Size(50, 50);
            fotocontato_box.SizeMode = PictureBoxSizeMode.Zoom;
            fotocontato_box.TabIndex = 0;
            fotocontato_box.TabStop = false;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.Controls.Add(clicar_contato);
            guna2Panel1.Controls.Add(lb_nomedocontato);
            guna2Panel1.Controls.Add(fotocontato_box);
            guna2Panel1.CustomizableEdges = customizableEdges4;
            guna2Panel1.FillColor = Color.FromArgb(17, 23, 34);
            guna2Panel1.Location = new Point(3, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2Panel1.Size = new Size(264, 60);
            guna2Panel1.TabIndex = 2;
            guna2Panel1.UseTransparentBackground = true;
            // 
            // clicar_contato
            // 
            clicar_contato.CustomizableEdges = customizableEdges2;
            clicar_contato.DisabledState.BorderColor = Color.DarkGray;
            clicar_contato.DisabledState.CustomBorderColor = Color.DarkGray;
            clicar_contato.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            clicar_contato.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            clicar_contato.FillColor = Color.Empty;
            clicar_contato.Font = new Font("Segoe UI", 9F);
            clicar_contato.ForeColor = Color.White;
            clicar_contato.Location = new Point(-3, 0);
            clicar_contato.Name = "clicar_contato";
            clicar_contato.ShadowDecoration.CustomizableEdges = customizableEdges3;
            clicar_contato.Size = new Size(267, 60);
            clicar_contato.TabIndex = 2;
            clicar_contato.UseTransparentBackground = true;
            clicar_contato.Click += clicar_contato_Click;
            // 
            // Contato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 39, 50);
            Controls.Add(guna2Panel1);
            Name = "Contato";
            Size = new Size(270, 66);
            ((System.ComponentModel.ISupportInitialize)fotocontato_box).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox fotocontato_box;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_nomedocontato;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button clicar_contato;
    }
}
