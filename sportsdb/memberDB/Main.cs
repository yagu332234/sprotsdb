using System;
using System.Windows.Forms;

namespace memberDB
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 予約画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reserveButtonClick(object sender, EventArgs e)
        {
            
            //ReserveOption画面を表示
            Program.mainPage.MainForm = new ReserveOption();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }

        /// <summary>
        /// 会員削除画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void memberDeleteButtonClick(object sender, EventArgs e)
        {
            //MemberDelete画面を表示
            Program.mainPage.MainForm = new MemberDelete();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
        /// <summary>
        /// スタート画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButtonClick(object sender, EventArgs e)
        {
            //start画面を表示
            Program.mainPage.MainForm = new StartScreen();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
        /// <summary>
        /// 会員更新画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void memberUpdateButtonClick(object sender, EventArgs e)
        {
           
            //memberUpdate画面を表示
            Program.mainPage.MainForm = new MemberUpdate();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
        /// <summary>
        /// 会員情報画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void memberStatusButtonClick(object sender, EventArgs e)
        {
            //MemberStatus画面を表示
            Program.mainPage.MainForm = new MemberStatus ();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
       
        /// <summary>
        /// データベース作成画面へ遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dbCriateClick(object sender, EventArgs e)
        {
            //DataBasePage画面を表示
            Program.mainPage.MainForm = new DataBasePage();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
    }
}
