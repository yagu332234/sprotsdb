using System;
using System.Windows.Forms;

namespace memberDB
{
    public partial class reserve_optionscreen : Form
    {
        public reserve_optionscreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;
            reserve_registerscreen rr = new reserve_registerscreen();
            rr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;
            reserve_delitescreen rd = new reserve_delitescreen();
            rd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;
            main ma = new main();
            ma.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;
            reserve_Update rUpdate = new reserve_Update();
            rUpdate.Show();
        }
    }
}
