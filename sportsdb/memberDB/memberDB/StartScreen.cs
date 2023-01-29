using System;
using System.Windows.Forms;

namespace memberDB
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }
       
        /// <summary>
        /// ログイン画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roginButtonClick(object sender, EventArgs e)
        {
            //ログイン画面を表示
            Program.mainPage.MainForm = new RoginScreen();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
        /// <summary>
        /// 新規登録画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newRegisterButtonClick(object sender, EventArgs e)
        {
            //新規登録画面を表示
            Program.mainPage.MainForm = new NewRegister();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
        /// <summary>
        /// 終了ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButtonClick(object sender, EventArgs e)
        {
            //ポップアップの表示
            DialogResult result = MessageBox.Show("本当に終了してよろしいですか？","警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dbCriateClick(object sender, EventArgs e)
        {
            //データベース作成画面を表示
            Program.mainPage.MainForm = new DataBasePage();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
    }
}
