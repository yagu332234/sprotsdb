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
        /// <summary>
        /// 戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButtonClick(object sender, EventArgs e)
        {
            //MemberStatus画面を表示
            Program.mainPage.MainForm = new ReserveOption();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }

        private void reservebutton_Click(object sender, EventArgs e)
        {

        }

        private void reserveDliteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
