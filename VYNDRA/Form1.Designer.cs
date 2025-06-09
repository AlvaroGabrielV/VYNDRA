namespace VYNDRA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lstMensagens = new ListBox();
            btnEnviar = new Guna.UI2.WinForms.Guna2Button();
            txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            txtMensagem = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // lstMensagens
            // 
            lstMensagens.FormattingEnabled = true;
            lstMensagens.ItemHeight = 25;
            lstMensagens.Location = new Point(629, 70);
            lstMensagens.Name = "lstMensagens";
            lstMensagens.Size = new Size(878, 654);
            lstMensagens.TabIndex = 0;
            // 
            // btnEnviar
            // 
            btnEnviar.CustomizableEdges = customizableEdges1;
            btnEnviar.DisabledState.BorderColor = Color.DarkGray;
            btnEnviar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEnviar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEnviar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEnviar.Font = new Font("Segoe UI", 9F);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(113, 286);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEnviar.Size = new Size(305, 70);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "guna2Button1";
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.CustomizableEdges = customizableEdges3;
            txtUsuario.DefaultText = "";
            txtUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Font = new Font("Segoe UI", 9F);
            txtUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Location = new Point(102, 70);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "";
            txtUsuario.SelectedText = "";
            txtUsuario.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtUsuario.Size = new Size(359, 60);
            txtUsuario.TabIndex = 2;
            // 
            // txtMensagem
            // 
            txtMensagem.CustomizableEdges = customizableEdges5;
            txtMensagem.DefaultText = "";
            txtMensagem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMensagem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMensagem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMensagem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMensagem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMensagem.Font = new Font("Segoe UI", 9F);
            txtMensagem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMensagem.Location = new Point(102, 174);
            txtMensagem.Margin = new Padding(4, 5, 4, 5);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.PlaceholderText = "";
            txtMensagem.SelectedText = "";
            txtMensagem.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtMensagem.Size = new Size(359, 60);
            txtMensagem.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_vyndra;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1519, 749);
            Controls.Add(txtMensagem);
            Controls.Add(txtUsuario);
            Controls.Add(btnEnviar);
            Controls.Add(lstMensagens);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VYNDRA";
            UseWaitCursor = true;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstMensagens;
        private Guna.UI2.WinForms.Guna2Button btnEnviar;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtMensagem;
    }
}
