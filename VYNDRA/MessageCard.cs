﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VYNDRA
{
    public partial class MessageCard : UserControl
    {
        public MessageCard()
        {
            InitializeComponent();
        }

        public void SetDados(string Imagem,String Usuario, String Mensagem)
        {
            user_picture.ImageLocation = Imagem;
            
            lblUser.Text = Usuario;
            lblMessage.Text = Mensagem;
            lblHoras.Text = DateTime.Now.ToShortTimeString();
        }        
    }
}
