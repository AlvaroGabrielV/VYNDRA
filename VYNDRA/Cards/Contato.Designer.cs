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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            // 
            // lb_quemescreveuporultimo
            // 
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
            lb_nomedocontato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_nomedocontato.ForeColor = Color.DarkGray;
            lb_nomedocontato.Location = new Point(59, 2);
            lb_nomedocontato.Name = "lb_nomedocontato";
            lb_nomedocontato.Size = new Size(38, 19);
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
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(47, 47);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // Contato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(panel1);
            Name = "Contato";
            Size = new Size(270, 66);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_nomedocontato;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_mensagem;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_quemescreveuporultimo;
    }
}
