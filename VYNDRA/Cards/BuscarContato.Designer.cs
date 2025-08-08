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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            busca_panel = new Guna.UI2.WinForms.Guna2Panel();
            search_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            add_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            busca_panel.SuspendLayout();
            SuspendLayout();
            // 
            // busca_panel
            // 
            busca_panel.BackColor = Color.Transparent;
            busca_panel.Controls.Add(search_btn);
            busca_panel.Controls.Add(guna2TextBox1);
            busca_panel.CustomizableEdges = customizableEdges4;
            busca_panel.Location = new Point(3, 3);
            busca_panel.Name = "busca_panel";
            busca_panel.Padding = new Padding(8);
            busca_panel.ShadowDecoration.CustomizableEdges = customizableEdges5;
            busca_panel.Size = new Size(230, 60);
            busca_panel.TabIndex = 0;
            busca_panel.UseTransparentBackground = true;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.Transparent;
            search_btn.DisabledState.BorderColor = Color.DarkGray;
            search_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            search_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            search_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            search_btn.FillColor = Color.Transparent;
            search_btn.Font = new Font("Segoe UI", 9F);
            search_btn.ForeColor = Color.White;
            search_btn.Image = Properties.Resources.search;
            search_btn.Location = new Point(180, 16);
            search_btn.Name = "search_btn";
            search_btn.ShadowDecoration.CustomizableEdges = customizableEdges1;
            search_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            search_btn.Size = new Size(30, 30);
            search_btn.TabIndex = 1;
            search_btn.UseTransparentBackground = true;
            search_btn.Click += search_btn_Click;
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
            guna2TextBox1.Size = new Size(214, 44);
            guna2TextBox1.TabIndex = 0;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.Transparent;
            add_btn.DisabledState.BorderColor = Color.DarkGray;
            add_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            add_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            add_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            add_btn.FillColor = Color.Transparent;
            add_btn.Font = new Font("Segoe UI", 9F);
            add_btn.ForeColor = Color.White;
            add_btn.Image = Properties.Resources.add_user;
            add_btn.ImageSize = new Size(25, 25);
            add_btn.Location = new Point(236, 21);
            add_btn.Name = "add_btn";
            add_btn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            add_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            add_btn.Size = new Size(28, 30);
            add_btn.TabIndex = 2;
            add_btn.UseTransparentBackground = true;
            add_btn.Click += add_btn_Click;
            // 
            // BuscarContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(add_btn);
            Controls.Add(busca_panel);
            Name = "BuscarContato";
            Size = new Size(270, 66);
            busca_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel busca_panel;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2CircleButton search_btn;
        private Guna.UI2.WinForms.Guna2CircleButton add_btn;
    }
}
