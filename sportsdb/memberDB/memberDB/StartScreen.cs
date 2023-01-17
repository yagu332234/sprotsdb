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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void memberRegisterButtonClick(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;
            Main main = new Main();
            main.Show();
        }

        private void roginButtonClick(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;
            RoginScreen rs = new RoginScreen();
            rs.Show();
        }

        private void newRegisterButtonClick(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;
            NewRegister nr = new NewRegister();
            nr.Show();
        }

        private void exitButtonClick(object sender, EventArgs e)
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
