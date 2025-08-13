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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            chat_panel = new Guna.UI2.WinForms.Guna2Panel();
            chat_scroll = new Guna.UI2.WinForms.Guna2VScrollBar();
            chat_layout = new FlowLayoutPanel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            cor_status = new Guna.UI2.WinForms.Guna2PictureBox();
            contato_status = new Guna.UI2.WinForms.Guna2HtmlLabel();
            contato_nome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            foto_usuario = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            chatcard_panel = new Guna.UI2.WinForms.Guna2Panel();
            send_btn = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            messageBox = new Guna.UI2.WinForms.Guna2TextBox();
            perfil_panel = new Guna.UI2.WinForms.Guna2Panel();
            chat_panel.SuspendLayout();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cor_status).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foto_usuario).BeginInit();
            chatcard_panel.SuspendLayout();
            SuspendLayout();
            // 
            // chat_panel
            // 
            chat_panel.BackColor = Color.Transparent;
            chat_panel.BorderRadius = 25;
            chat_panel.Controls.Add(chat_scroll);
            chat_panel.Controls.Add(chat_layout);
            chat_panel.Controls.Add(guna2Panel1);
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
            chat_panel.Size = new Size(1004, 720);
            chat_panel.TabIndex = 2;
            chat_panel.UseTransparentBackground = true;
            // 
            // chat_scroll
            // 
            chat_scroll.BindingContainer = chat_layout;
            chat_scroll.BorderRadius = 8;
            chat_scroll.InUpdate = false;
            chat_scroll.LargeChange = 10;
            chat_scroll.Location = new Point(978, 115);
            chat_scroll.Margin = new Padding(4, 5, 4, 5);
            chat_scroll.Name = "chat_scroll";
            chat_scroll.ScrollbarSize = 26;
            chat_scroll.Size = new Size(26, 507);
            chat_scroll.TabIndex = 0;
            chat_scroll.ThumbSize = 3F;
            chat_scroll.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // chat_layout
            // 
            chat_layout.AutoScroll = true;
            chat_layout.BackColor = Color.FromArgb(17, 23, 34);
            chat_layout.Dock = DockStyle.Fill;
            chat_layout.Location = new Point(0, 115);
            chat_layout.Margin = new Padding(4, 5, 4, 5);
            chat_layout.Name = "chat_layout";
            chat_layout.Size = new Size(1004, 507);
            chat_layout.TabIndex = 2;
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
            guna2Panel1.Margin = new Padding(4, 5, 4, 5);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2Panel1.Size = new Size(1004, 115);
            guna2Panel1.TabIndex = 3;
            // 
            // cor_status
            // 
            cor_status.BorderRadius = 5;
            cor_status.CustomizableEdges = customizableEdges1;
            cor_status.FillColor = Color.Transparent;
            cor_status.ImageRotate = 0F;
            cor_status.Location = new Point(99, 77);
            cor_status.Margin = new Padding(4, 5, 4, 5);
            cor_status.Name = "cor_status";
            cor_status.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cor_status.Size = new Size(23, 27);
            cor_status.SizeMode = PictureBoxSizeMode.StretchImage;
            cor_status.TabIndex = 3;
            cor_status.TabStop = false;
            // 
            // contato_status
            // 
            contato_status.BackColor = Color.Transparent;
            contato_status.Enabled = false;
            contato_status.ForeColor = Color.FromArgb(0, 217, 255);
            contato_status.Location = new Point(121, 77);
            contato_status.Margin = new Padding(4, 5, 4, 5);
            contato_status.Name = "contato_status";
            contato_status.Size = new Size(54, 27);
            contato_status.TabIndex = 2;
            contato_status.TabStop = false;
            contato_status.Text = "Online";
            contato_status.TextAlignment = ContentAlignment.MiddleRight;
            // 
            // contato_nome
            // 
            contato_nome.BackColor = Color.Transparent;
            contato_nome.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contato_nome.ForeColor = Color.White;
            contato_nome.IsSelectionEnabled = false;
            contato_nome.Location = new Point(99, 17);
            contato_nome.Margin = new Padding(4, 5, 4, 5);
            contato_nome.Name = "contato_nome";
            contato_nome.Size = new Size(223, 47);
            contato_nome.TabIndex = 1;
            contato_nome.Text = "Nome Contato";
            contato_nome.Click += abrirPefil_btn_Click;
            // 
            // foto_usuario
            // 
            foto_usuario.ImageRotate = 0F;
            foto_usuario.Location = new Point(11, 10);
            foto_usuario.Margin = new Padding(4, 5, 4, 5);
            foto_usuario.Name = "foto_usuario";
            foto_usuario.ShadowDecoration.CustomizableEdges = customizableEdges3;
            foto_usuario.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            foto_usuario.Size = new Size(79, 92);
            foto_usuario.SizeMode = PictureBoxSizeMode.Zoom;
            foto_usuario.TabIndex = 0;
            foto_usuario.TabStop = false;
            foto_usuario.Click += abrirPefil_btn_Click;
            // 
            // chatcard_panel
            // 
            chatcard_panel.BackColor = Color.Transparent;
            chatcard_panel.BorderColor = Color.Transparent;
            chatcard_panel.BorderRadius = 20;
            chatcard_panel.Controls.Add(send_btn);
            chatcard_panel.Controls.Add(guna2Button1);
            chatcard_panel.Controls.Add(messageBox);
            customizableEdges12.TopLeft = false;
            customizableEdges12.TopRight = false;
            chatcard_panel.CustomizableEdges = customizableEdges12;
            chatcard_panel.Dock = DockStyle.Bottom;
            chatcard_panel.FillColor = Color.FromArgb(25, 34, 50);
            chatcard_panel.Location = new Point(0, 622);
            chatcard_panel.Margin = new Padding(21, 25, 21, 25);
            chatcard_panel.Name = "chatcard_panel";
            chatcard_panel.Padding = new Padding(14, 17, 14, 17);
            chatcard_panel.ShadowDecoration.CustomizableEdges = customizableEdges13;
            chatcard_panel.Size = new Size(1004, 98);
            chatcard_panel.TabIndex = 1;
            // 
            // send_btn
            // 
            send_btn.BackColor = Color.Transparent;
            send_btn.CustomizableEdges = customizableEdges6;
            send_btn.DisabledState.BorderColor = Color.DarkGray;
            send_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            send_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            send_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            send_btn.Dock = DockStyle.Right;
            send_btn.FillColor = Color.Transparent;
            send_btn.Font = new Font("Segoe UI", 9F);
            send_btn.ForeColor = Color.White;
            send_btn.Image = Properties.Resources.message1;
            send_btn.ImageSize = new Size(25, 25);
            send_btn.Location = new Point(940, 17);
            send_btn.Margin = new Padding(4, 5, 4, 5);
            send_btn.Name = "send_btn";
            send_btn.ShadowDecoration.CustomizableEdges = customizableEdges7;
            send_btn.Size = new Size(50, 64);
            send_btn.TabIndex = 5;
            send_btn.UseTransparentBackground = true;
            send_btn.Click += send_btn_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.CustomizableEdges = customizableEdges8;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = Properties.Resources.plus;
            guna2Button1.ImageSize = new Size(25, 25);
            guna2Button1.Location = new Point(14, 22);
            guna2Button1.Margin = new Padding(4, 5, 4, 5);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2Button1.Size = new Size(50, 58);
            guna2Button1.TabIndex = 2;
            guna2Button1.UseTransparentBackground = true;
            // 
            // messageBox
            // 
            messageBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            messageBox.BorderRadius = 20;
            messageBox.CustomizableEdges = customizableEdges10;
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
            messageBox.Location = new Point(14, 17);
            messageBox.Margin = new Padding(0);
            messageBox.Name = "messageBox";
            messageBox.PlaceholderForeColor = Color.Black;
            messageBox.PlaceholderText = "Digite sua mensagem...";
            messageBox.SelectedText = "";
            messageBox.ShadowDecoration.CustomizableEdges = customizableEdges11;
            messageBox.Size = new Size(976, 64);
            messageBox.TabIndex = 4;
            messageBox.TextOffset = new Point(36, 0);
            messageBox.KeyPress += messageBox_KeyPress;
            // 
            // perfil_panel
            // 
            perfil_panel.CustomizableEdges = customizableEdges16;
            perfil_panel.Dock = DockStyle.Fill;
            perfil_panel.Location = new Point(0, 0);
            perfil_panel.Margin = new Padding(4, 5, 4, 5);
            perfil_panel.Name = "perfil_panel";
            perfil_panel.ShadowDecoration.CustomizableEdges = customizableEdges17;
            perfil_panel.Size = new Size(1004, 720);
            perfil_panel.TabIndex = 0;
            perfil_panel.Visible = false;
            // 
            // Chat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 23, 34);
            Controls.Add(chat_panel);
            Controls.Add(perfil_panel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Chat";
            Size = new Size(1004, 720);
            Load += Chat_Load;
            chat_panel.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cor_status).EndInit();
            ((System.ComponentModel.ISupportInitialize)foto_usuario).EndInit();
            chatcard_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel chat_panel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel contato_status;
        private Guna.UI2.WinForms.Guna2HtmlLabel contato_nome;
        private Guna.UI2.WinForms.Guna2CirclePictureBox foto_usuario;
        private FlowLayoutPanel chat_layout;
        private Guna.UI2.WinForms.Guna2Panel chatcard_panel;
        private Guna.UI2.WinForms.Guna2TextBox messageBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2VScrollBar chat_scroll;
        private Guna.UI2.WinForms.Guna2Button send_btn;
        private Guna.UI2.WinForms.Guna2PictureBox cor_status;
        private Guna.UI2.WinForms.Guna2Panel perfil_panel;
    }
}
