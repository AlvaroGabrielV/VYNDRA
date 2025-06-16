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
            btnEnviar = new Guna.UI2.WinForms.Guna2Button();
            txtMensagem = new Guna.UI2.WinForms.Guna2TextBox();
            msg_flow = new FlowLayoutPanel();
            SuspendLayout();
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
            btnEnviar.Location = new Point(1268, 687);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEnviar.Size = new Size(229, 54);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseWaitCursor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtMensagem
            // 
            txtMensagem.BackColor = Color.Transparent;
            txtMensagem.BorderRadius = 25;
            txtMensagem.CustomizableEdges = customizableEdges3;
            txtMensagem.DefaultText = "";
            txtMensagem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMensagem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMensagem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMensagem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMensagem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMensagem.Font = new Font("Segoe UI", 9F);
            txtMensagem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMensagem.Location = new Point(283, 686);
            txtMensagem.Margin = new Padding(6, 8, 6, 8);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.PlaceholderText = "";
            txtMensagem.SelectedText = "";
            txtMensagem.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtMensagem.Size = new Size(976, 55);
            txtMensagem.TabIndex = 2;
            txtMensagem.UseWaitCursor = true;
            txtMensagem.KeyDown += txtMensagem_KeyDown;
            // 
            // msg_flow
            // 
            msg_flow.AutoScroll = true;
            msg_flow.Location = new Point(283, 12);
            msg_flow.Name = "msg_flow";
            msg_flow.Size = new Size(1224, 663);
            msg_flow.TabIndex = 3;
            msg_flow.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_vyndra;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1519, 748);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensagem);
            Controls.Add(msg_flow);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VYNDRA";
            UseWaitCursor = true;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnEnviar;
        private Guna.UI2.WinForms.Guna2TextBox txtMensagem;
        private FlowLayoutPanel msg_flow;
    }
}
