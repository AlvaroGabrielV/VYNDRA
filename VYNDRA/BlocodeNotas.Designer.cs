namespace VYNDRA
{
    partial class BlocodeNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            txtDescricao = new Guna.UI2.WinForms.Guna2TextBox();
            btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.CustomizableEdges = customizableEdges7;
            txtTitulo.DefaultText = "Título";
            txtTitulo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTitulo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTitulo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTitulo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTitulo.FillColor = Color.FromArgb(11, 17, 30);
            txtTitulo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTitulo.Font = new Font("Segoe UI", 14F);
            txtTitulo.ForeColor = Color.White;
            txtTitulo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTitulo.Location = new Point(0, 4);
            txtTitulo.Margin = new Padding(6);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "";
            txtTitulo.SelectedText = "";
            txtTitulo.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtTitulo.Size = new Size(800, 50);
            txtTitulo.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.CustomizableEdges = customizableEdges9;
            txtDescricao.DefaultText = "Texto...";
            txtDescricao.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDescricao.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDescricao.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDescricao.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDescricao.FillColor = Color.FromArgb(11, 17, 30);
            txtDescricao.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescricao.Font = new Font("Segoe UI", 8F);
            txtDescricao.ForeColor = Color.White;
            txtDescricao.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescricao.Location = new Point(0, 64);
            txtDescricao.Margin = new Padding(4);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "";
            txtDescricao.SelectedText = "";
            txtDescricao.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtDescricao.Size = new Size(800, 325);
            txtDescricao.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.BorderRadius = 15;
            btnSalvar.CustomizableEdges = customizableEdges11;
            btnSalvar.DisabledState.BorderColor = Color.DarkGray;
            btnSalvar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalvar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalvar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(302, 396);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnSalvar.Size = new Size(161, 37);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // BlocodeNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 17, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(txtDescricao);
            Controls.Add(txtTitulo);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "BlocodeNotas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BlocodeNotas";
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtDescricao;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
    }
}