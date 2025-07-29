namespace VYNDRA.Cards
{
    partial class BuscarContato
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            busca_panel = new Guna.UI2.WinForms.Guna2Panel();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            busca_panel.SuspendLayout();
            SuspendLayout();
            // 
            // busca_panel
            // 
            busca_panel.BackColor = Color.Transparent;
            busca_panel.Controls.Add(guna2CircleButton1);
            busca_panel.Controls.Add(guna2TextBox1);
            busca_panel.CustomizableEdges = customizableEdges4;
            busca_panel.Location = new Point(3, 3);
            busca_panel.Name = "busca_panel";
            busca_panel.Padding = new Padding(8);
            busca_panel.ShadowDecoration.CustomizableEdges = customizableEdges5;
            busca_panel.Size = new Size(264, 60);
            busca_panel.TabIndex = 0;
            busca_panel.UseTransparentBackground = true;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderRadius = 22;
            guna2TextBox1.CustomizableEdges = customizableEdges2;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.Dock = DockStyle.Fill;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.ForeColor = Color.Black;
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(8, 8);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderForeColor = Color.Gray;
            guna2TextBox1.PlaceholderText = "Buscar usuario";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2TextBox1.Size = new Size(248, 44);
            guna2TextBox1.TabIndex = 0;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.BackColor = Color.Transparent;
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.Transparent;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Image = Properties.Resources.search;
            guna2CircleButton1.Location = new Point(216, 16);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(30, 30);
            guna2CircleButton1.TabIndex = 1;
            guna2CircleButton1.UseTransparentBackground = true;
            // 
            // BuscarContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(busca_panel);
            Name = "BuscarContato";
            Size = new Size(270, 66);
            busca_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel busca_panel;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}
