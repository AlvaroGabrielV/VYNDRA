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
<<<<<<< HEAD
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
=======
            panel1 = new Panel();
            lb_mensagem = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lb_quemescreveuporultimo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lb_nomedocontato = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 39, 50);
            panel1.Controls.Add(lb_mensagem);
            panel1.Controls.Add(lb_quemescreveuporultimo);
            panel1.Controls.Add(lb_nomedocontato);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 60);
            panel1.TabIndex = 0;
            // 
            // lb_mensagem
            // 
            lb_mensagem.BackColor = Color.Transparent;
            lb_mensagem.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_mensagem.ForeColor = Color.DarkGray;
            lb_mensagem.Location = new Point(101, 32);
            lb_mensagem.Name = "lb_mensagem";
            lb_mensagem.Size = new Size(60, 15);
            lb_mensagem.TabIndex = 3;
            lb_mensagem.Text = "mensagem";
            lb_mensagem.Click += lb_mensagem_Click;
>>>>>>> 13f7adbbca1df4a99c3f2065578f22ef31759b92
            // 
            // fotocontato_box
            // 
<<<<<<< HEAD
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
=======
            lb_quemescreveuporultimo.BackColor = Color.Transparent;
            lb_quemescreveuporultimo.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_quemescreveuporultimo.ForeColor = Color.DarkGray;
            lb_quemescreveuporultimo.Location = new Point(59, 25);
            lb_quemescreveuporultimo.Name = "lb_quemescreveuporultimo";
            lb_quemescreveuporultimo.Size = new Size(41, 39);
            lb_quemescreveuporultimo.TabIndex = 2;
            lb_quemescreveuporultimo.Text = "nome:";
            // 
            // lb_nomedocontato
            // 
            lb_nomedocontato.BackColor = Color.Transparent;
            lb_nomedocontato.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_nomedocontato.ForeColor = Color.DarkGray;
            lb_nomedocontato.Location = new Point(59, 6);
            lb_nomedocontato.Name = "lb_nomedocontato";
            lb_nomedocontato.Size = new Size(43, 22);
            lb_nomedocontato.TabIndex = 1;
            lb_nomedocontato.Text = "nome";
            lb_nomedocontato.Click += guna2HtmlLabel1_Click;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackColor = Color.Transparent;
            guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.None;
            guna2CirclePictureBox1.ErrorImage = null;
            guna2CirclePictureBox1.FillColor = Color.LightGray;
            guna2CirclePictureBox1.Image = Properties.Resources.do_utilizador__1_2;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.InitialImage = null;
            guna2CirclePictureBox1.Location = new Point(7, 7);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(47, 47);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
>>>>>>> 13f7adbbca1df4a99c3f2065578f22ef31759b92
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
