using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VYNDRA.Cards
{
    public partial class AccRecAmizade : UserControl
    {
        public string username
        {
            get { return user_txt.Text; }
            set { user_txt.Text = value; }
        }
        public AccRecAmizade()
        {
            InitializeComponent();
        }

        private void recusar_btn_Click(object sender, EventArgs e)
        {

        }

        private void aceitar_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
