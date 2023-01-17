using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace memberDB
{
    public partial class reserve_delitescreen : Form
    {
        public reserve_delitescreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;
            reserve_optionscreen ro = new reserve_optionscreen();
            ro.Show();
        }

        private void reservebutton_Click(object sender, EventArgs e)
        {

        }
    }
}
