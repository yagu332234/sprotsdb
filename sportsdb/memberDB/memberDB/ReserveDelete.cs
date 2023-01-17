using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace memberDB
{
    public partial class ReserveDelete : Form
    {
        public ReserveDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;
            ReserveOption ro = new ReserveOption();
            ro.Show();
        }

        private void reservebutton_Click(object sender, EventArgs e)
        {

        }

        private void reserveDliteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
