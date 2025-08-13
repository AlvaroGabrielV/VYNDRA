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
            btnAdicionar = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.BorderRadius = 20;
            btnAdicionar.CustomizableEdges = customizableEdges1;
            btnAdicionar.DisabledState.BorderColor = Color.DarkGray;
            btnAdicionar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdicionar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdicionar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdicionar.FillColor = Color.FromArgb(11, 17, 30);
            btnAdicionar.Font = new Font("Segoe UI", 9F);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Image = Properties.Resources.sinal_de_adicao;
            btnAdicionar.ImageSize = new Size(60, 60);
            btnAdicionar.Location = new Point(0, 0);
            btnAdicionar.Margin = new Padding(4, 5, 4, 5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdicionar.Size = new Size(300, 300);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // CardAdicionarTarefa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnAdicionar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CardAdicionarTarefa";
            Size = new Size(346, 353);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAdicionar;
    }
}
