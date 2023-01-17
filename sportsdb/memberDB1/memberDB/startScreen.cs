using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace memberDB
{
    public partial class startScreen : Form
    {
        public startScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;
            main ma = new main();
            ma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;
            RoginScreen rs = new RoginScreen();
            rs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;
            NewRegister nr = new NewRegister();
            nr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ポップアップの表示
            DialogResult result = MessageBox.Show("本当に終了してよろしいですか？","警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
