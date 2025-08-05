namespace VYNDRA
{
    partial class CardAdicionarTarefa
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnAdicionar = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.CustomizableEdges = customizableEdges1;
            btnAdicionar.DisabledState.BorderColor = Color.DarkGray;
            btnAdicionar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdicionar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdicionar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdicionar.Dock = DockStyle.Fill;
            btnAdicionar.FillColor = Color.FromArgb(11, 17, 30);
            btnAdicionar.Font = new Font("Segoe UI", 9F);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Image = Properties.Resources.sinal_de_adicao;
            btnAdicionar.ImageSize = new Size(60, 60);
            btnAdicionar.Location = new Point(0, 0);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdicionar.Size = new Size(242, 160);
            btnAdicionar.TabIndex = 7;
            // 
            // guna2Panel3
            // 
            guna2Panel3.CustomizableEdges = customizableEdges3;
            guna2Panel3.FillColor = Color.FromArgb(75, 75, 75);
            guna2Panel3.Location = new Point(0, 0);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel3.Size = new Size(372, 31);
            guna2Panel3.TabIndex = 6;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BorderRadius = 20;
            guna2Panel2.Controls.Add(guna2Panel3);
            guna2Panel2.CustomizableEdges = customizableEdges5;
            guna2Panel2.Dock = DockStyle.Bottom;
            guna2Panel2.FillColor = Color.FromArgb(75, 75, 75);
            guna2Panel2.Location = new Point(0, 160);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel2.Size = new Size(242, 52);
            guna2Panel2.TabIndex = 5;
            // 
            // CardAdicionarTarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnAdicionar);
            Controls.Add(guna2Panel2);
            Name = "CardAdicionarTarefa";
            Size = new Size(242, 212);
            guna2Panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAdicionar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}
