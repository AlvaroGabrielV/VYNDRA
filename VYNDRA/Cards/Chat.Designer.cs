namespace VYNDRA.Cards
{
    partial class Chat
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            chat_panel = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            cor_status = new Guna.UI2.WinForms.Guna2Button();
            contato_status = new Guna.UI2.WinForms.Guna2HtmlLabel();
            contato_nome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            foto_usuario = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            chat_layout = new FlowLayoutPanel();
            chatcard_panel = new Guna.UI2.WinForms.Guna2Panel();
            messageBox = new Guna.UI2.WinForms.Guna2TextBox();
            send_btn = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            chat_panel.SuspendLayout();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)foto_usuario).BeginInit();
            chatcard_panel.SuspendLayout();
            SuspendLayout();
            // 
            // chat_panel
            // 
            chat_panel.BackColor = Color.Transparent;
            chat_panel.BorderRadius = 25;
            chat_panel.Controls.Add(guna2Panel1);
            chat_panel.Controls.Add(chat_layout);
            chat_panel.Controls.Add(chatcard_panel);
            customizableEdges14.BottomLeft = false;
            customizableEdges14.TopLeft = false;
            chat_panel.CustomizableEdges = customizableEdges14;
            chat_panel.Dock = DockStyle.Fill;
            chat_panel.FillColor = Color.FromArgb(22, 39, 50);
            chat_panel.Location = new Point(0, 0);
            chat_panel.Margin = new Padding(0);
            chat_panel.Name = "chat_panel";
            chat_panel.ShadowDecoration.CustomizableEdges = customizableEdges15;
            chat_panel.Size = new Size(966, 706);
            chat_panel.TabIndex = 2;
            chat_panel.UseTransparentBackground = true;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 20;
            guna2Panel1.Controls.Add(cor_status);
            guna2Panel1.Controls.Add(contato_status);
            guna2Panel1.Controls.Add(contato_nome);
            guna2Panel1.Controls.Add(foto_usuario);
            customizableEdges4.BottomLeft = false;
            customizableEdges4.BottomRight = false;
            guna2Panel1.CustomizableEdges = customizableEdges4;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.FillColor = Color.FromArgb(23, 31, 46);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2Panel1.Size = new Size(966, 69);
            guna2Panel1.TabIndex = 3;
            // 
            // cor_status
            // 
            cor_status.BorderColor = Color.BlanchedAlmond;
            cor_status.BorderRadius = 5;
            cor_status.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            cor_status.CustomizableEdges = customizableEdges1;
            cor_status.DisabledState.BorderColor = Color.DarkGray;
            cor_status.DisabledState.CustomBorderColor = Color.DarkGray;
            cor_status.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            cor_status.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            cor_status.Enabled = false;
            cor_status.FillColor = Color.FromArgb(192, 192, 0);
            cor_status.Font = new Font("Segoe UI", 9F);
            cor_status.ForeColor = Color.White;
            cor_status.Location = new Point(69, 47);
            cor_status.Name = "cor_status";
            cor_status.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cor_status.Size = new Size(14, 14);
            cor_status.TabIndex = 3;
            cor_status.TabStop = false;
            // 
            // contato_status
            // 
            contato_status.BackColor = Color.Transparent;
            contato_status.Enabled = false;
            contato_status.ForeColor = Color.FromArgb(192, 192, 0);
            contato_status.Location = new Point(85, 46);
            contato_status.Name = "contato_status";
            contato_status.Size = new Size(45, 17);
            contato_status.TabIndex = 2;
            contato_status.TabStop = false;
            contato_status.Text = "ONLINE";
            contato_status.TextAlignment = ContentAlignment.MiddleRight;
            // 
            // contato_nome
            // 
            contato_nome.BackColor = Color.Transparent;
            contato_nome.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contato_nome.ForeColor = Color.White;
            contato_nome.IsSelectionEnabled = false;
            contato_nome.Location = new Point(69, 10);
            contato_nome.Name = "contato_nome";
            contato_nome.Size = new Size(146, 32);
            contato_nome.TabIndex = 1;
            contato_nome.Text = "Nome Contato";
            // 
            // foto_usuario
            // 
            foto_usuario.ImageRotate = 0F;
            foto_usuario.Location = new Point(8, 6);
            foto_usuario.Name = "foto_usuario";
            foto_usuario.ShadowDecoration.CustomizableEdges = customizableEdges3;
            foto_usuario.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            foto_usuario.Size = new Size(55, 55);
            foto_usuario.SizeMode = PictureBoxSizeMode.Zoom;
            foto_usuario.TabIndex = 0;
            foto_usuario.TabStop = false;
            // 
            // chat_layout
            // 
            chat_layout.BackColor = Color.FromArgb(17, 23, 34);
            chat_layout.Dock = DockStyle.Fill;
            chat_layout.Location = new Point(0, 0);
            chat_layout.Name = "chat_layout";
            chat_layout.Size = new Size(966, 647);
            chat_layout.TabIndex = 2;
            // 
            // chatcard_panel
            // 
            chatcard_panel.BackColor = Color.Transparent;
            chatcard_panel.BorderColor = Color.Transparent;
            chatcard_panel.BorderRadius = 20;
            chatcard_panel.Controls.Add(messageBox);
            chatcard_panel.Controls.Add(send_btn);
            chatcard_panel.Controls.Add(guna2Button1);
            customizableEdges12.TopLeft = false;
            customizableEdges12.TopRight = false;
            chatcard_panel.CustomizableEdges = customizableEdges12;
            chatcard_panel.Dock = DockStyle.Bottom;
            chatcard_panel.FillColor = Color.FromArgb(25, 34, 50);
            chatcard_panel.Location = new Point(0, 647);
            chatcard_panel.Margin = new Padding(15);
            chatcard_panel.Name = "chatcard_panel";
            chatcard_panel.Padding = new Padding(10);
            chatcard_panel.ShadowDecoration.CustomizableEdges = customizableEdges13;
            chatcard_panel.Size = new Size(966, 59);
            chatcard_panel.TabIndex = 1;
            // 
            // messageBox
            // 
            messageBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            messageBox.BorderRadius = 20;
            messageBox.CustomizableEdges = customizableEdges6;
            messageBox.DefaultText = "";
            messageBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            messageBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            messageBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            messageBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            messageBox.Dock = DockStyle.Fill;
            messageBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            messageBox.Font = new Font("Segoe UI", 9F);
            messageBox.ForeColor = Color.Black;
            messageBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            messageBox.Location = new Point(10, 10);
            messageBox.Margin = new Padding(0);
            messageBox.Name = "messageBox";
            messageBox.PlaceholderForeColor = Color.Black;
            messageBox.PlaceholderText = "Digite sua mensagem...";
            messageBox.SelectedText = "";
            messageBox.ShadowDecoration.CustomizableEdges = customizableEdges7;
            messageBox.Size = new Size(946, 39);
            messageBox.TabIndex = 4;
            messageBox.TextOffset = new Point(33, 0);
            // 
            // send_btn
            // 
            send_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            send_btn.BackColor = Color.Transparent;
            send_btn.CustomizableEdges = customizableEdges8;
            send_btn.DisabledState.BorderColor = Color.DarkGray;
            send_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            send_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            send_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            send_btn.FillColor = Color.Transparent;
            send_btn.Font = new Font("Segoe UI", 9F);
            send_btn.ForeColor = Color.White;
            send_btn.Image = Properties.Resources.message1;
            send_btn.ImageSize = new Size(25, 25);
            send_btn.Location = new Point(1649, 23);
            send_btn.Name = "send_btn";
            send_btn.ShadowDecoration.CustomizableEdges = customizableEdges9;
            send_btn.Size = new Size(35, 0);
            send_btn.TabIndex = 3;
            send_btn.UseTransparentBackground = true;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.CustomizableEdges = customizableEdges10;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = Properties.Resources.plus;
            guna2Button1.ImageSize = new Size(25, 25);
            guna2Button1.Location = new Point(16, 11);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges11;
            guna2Button1.Size = new Size(35, 35);
            guna2Button1.TabIndex = 2;
            guna2Button1.UseTransparentBackground = true;
            // 
            // Chat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 23, 34);
            Controls.Add(chat_panel);
            Name = "Chat";
            Size = new Size(966, 706);
            chat_panel.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)foto_usuario).EndInit();
            chatcard_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel chat_panel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button cor_status;
        private Guna.UI2.WinForms.Guna2HtmlLabel contato_status;
        private Guna.UI2.WinForms.Guna2HtmlLabel contato_nome;
        private Guna.UI2.WinForms.Guna2CirclePictureBox foto_usuario;
        private FlowLayoutPanel chat_layout;
        private Guna.UI2.WinForms.Guna2Panel chatcard_panel;
        private Guna.UI2.WinForms.Guna2TextBox messageBox;
        private Guna.UI2.WinForms.Guna2Button send_btn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
