using System;
using System.Windows.Forms;

namespace memberDB
{
    public partial class ReserveOption : Form
    {
        public ReserveOption()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 予約登録
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reserveOptionButtonClick(object sender, EventArgs e)
        {
            //ReserveRegister画面を表示
            Program.mainPage.MainForm = new ReserveRegister();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
        /// <summary>
        /// 予約削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reserveDeleteButtonClick(object sender, EventArgs e)
        {
            //ReserveDelete画面を表示
            Program.mainPage.MainForm = new ReserveDelete();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
        /// <summary>
        /// 戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButtonClick(object sender, EventArgs e)
        {
            //Main画面を表示
            Program.mainPage.MainForm = new Main();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
        /// <summary>
        /// 予約更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reserveUpdateButtonClick(object sender, EventArgs e)
        {
            //ReserveUpdate画面を表示
            Program.mainPage.MainForm = new ReserveUpdate();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
        /// <summary>
        /// 予約確認画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reserveStatusButtonClick(object sender, EventArgs e)
        {
            //ReserveUpdate画面を表示
            Program.mainPage.MainForm = new ReserveStatus();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
    }
}
