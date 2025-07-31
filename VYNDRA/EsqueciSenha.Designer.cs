namespace VYNDRA
{
    partial class EsqueciSenha
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtEmailRecuperacao = new TextBox();
            label1 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            btnEnviar = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            bntFechar = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            SuspendLayout();
            // 
            // txtEmailRecuperacao
            // 
            txtEmailRecuperacao.BackColor = Color.FromArgb(80, 80, 80);
            txtEmailRecuperacao.BorderStyle = BorderStyle.None;
            txtEmailRecuperacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmailRecuperacao.ForeColor = Color.White;
            txtEmailRecuperacao.Location = new Point(148, 181);
            txtEmailRecuperacao.Name = "txtEmailRecuperacao";
            txtEmailRecuperacao.Size = new Size(269, 18);
            txtEmailRecuperacao.TabIndex = 18;
            txtEmailRecuperacao.Text = "Ex: seuemail@gmail.com";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 4, 40, 242);
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 62);
            label1.Name = "label1";
            label1.Size = new Size(282, 25);
            label1.TabIndex = 19;
            label1.Text = "Informe seu E-mal ou Usuário:\r\n";
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 5;
            guna2Button1.CustomizableEdges = customizableEdges19;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(80, 80, 80);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.FromArgb(80, 80, 80);
            guna2Button1.HoverState.BorderColor = Color.Black;
            guna2Button1.HoverState.CustomBorderColor = Color.FromArgb(80, 80, 80);
            guna2Button1.HoverState.FillColor = Color.FromArgb(80, 80, 80);
            guna2Button1.HoverState.ForeColor = Color.FromArgb(80, 80, 80);
            guna2Button1.Location = new Point(138, 167);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.FromArgb(80, 80, 80);
            guna2Button1.PressedDepth = 0;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2Button1.Size = new Size(292, 45);
            guna2Button1.TabIndex = 21;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.Transparent;
            btnEnviar.BorderRadius = 15;
            btnEnviar.CustomizableEdges = customizableEdges21;
            btnEnviar.DisabledState.BorderColor = Color.DarkGray;
            btnEnviar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEnviar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEnviar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEnviar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(213, 236);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnEnviar.Size = new Size(134, 36);
            btnEnviar.TabIndex = 22;
            btnEnviar.Text = "Enviar";
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(90, 96);
            label3.Name = "label3";
            label3.Size = new Size(380, 19);
            label3.TabIndex = 23;
            label3.Text = "Enviaremos um código para para redefinir sua senha.";
            // 
            // bntFechar
            // 
            bntFechar.BackColor = Color.Transparent;
            bntFechar.CustomizableEdges = customizableEdges23;
            bntFechar.DisabledState.BorderColor = Color.DarkGray;
            bntFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            bntFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntFechar.FillColor = Color.Transparent;
            bntFechar.Font = new Font("Segoe UI", 9F);
            bntFechar.ForeColor = Color.FromArgb(0, 4, 40, 242);
            bntFechar.Image = Properties.Resources.Inserir_um_título__1_;
            bntFechar.ImageSize = new Size(30, 30);
            bntFechar.Location = new Point(6, 6);
            bntFechar.Name = "bntFechar";
            bntFechar.ShadowDecoration.CustomizableEdges = customizableEdges24;
            bntFechar.Size = new Size(39, 39);
            bntFechar.TabIndex = 46;
            bntFechar.TextAlign = HorizontalAlignment.Right;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Dock = DockStyle.Fill;
            guna2ShadowPanel1.FillColor = Color.FromArgb(39, 38, 38);
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(582, 386);
            guna2ShadowPanel1.TabIndex = 47;
            // 
            // EsqueciSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 23, 34);
            ClientSize = new Size(582, 386);
            Controls.Add(bntFechar);
            Controls.Add(label3);
            Controls.Add(btnEnviar);
            Controls.Add(txtEmailRecuperacao);
            Controls.Add(label1);
            Controls.Add(guna2Button1);
            Controls.Add(guna2ShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EsqueciSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EsqueciSenha";
            MouseDown += EsqueciSenha_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmailRecuperacao;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnEnviar;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button bntFechar;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
    }
}