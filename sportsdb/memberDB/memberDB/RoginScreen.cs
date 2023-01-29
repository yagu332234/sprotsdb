using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Diagnostics;

namespace memberDB
{
    public partial class RoginScreen : Form
    {


        public RoginScreen()
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
            //start画面を表示
            Program.mainPage.MainForm = new StartScreen();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
        /// <summary>
        /// ログイン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roginButtonClick(object sender, EventArgs e)
        {
            //もしIDかパスワードが入力されてなかったら
            if (memberNameBox.Text==null || memberPasswordBox==null)
            {
                MessageBox.Show("パスワードか名前が一致しません");
            }
            //IDとパスワードが一致したら
            else
            {
                //氏名とパスワードが合ってるか確認する用の変数
                bool fault = false;
                //パス指定
                StreamReader streamRender = new StreamReader(@"C:\Users\Gx563\OneDrive\デスクトップ\G2A227矢口元輝\memberDB\" + "password.csv");

                //テキスト内に文字があったら
                while (streamRender.Peek() > -1)
                {
                    //テキストの氏名とパスワードを読み取り
                    string passwordCheck = streamRender.ReadLine();
                    //カンマをなくす
                    string[] sArray = passwordCheck.Split(",");
                    //もしパスワードと氏名が一致していたら
                    if(sArray[1]==memberPasswordBox.Text && sArray[0] == memberNameBox.Text)
                    {
                        //変数をtrueに変更            
                        fault = true;
                        
                    }
                }
                //処理の終了
                streamRender.Close();

                //パスワードか氏名が一致しなかったら
                if (fault == false)
                {
                    MessageBox.Show("氏名かパスワードが一致しませんでした");
                    //テキストの値を空白にする
                    memberNameBox.Text = "";
                    //テキストの値を空白にする
                    memberPasswordBox.Text = "";

                }
                //パスワードか氏名が一致したら
                else
                {
                    DialogResult tResult = MessageBox.Show("ログイン成功しました!", "ログイン成功", MessageBoxButtons.OK);
                  
                    if (tResult == DialogResult.OK)
                    {
                      //main画面を表示
                    Program.mainPage.MainForm = new Main();
                    Program.mainPage.MainForm.Show();
                    //現在の画面を消す
                    this.Close();
                    }
                    
                }
            }
        }
        /// <summary>
        /// パスワードを隠すボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maskButtonClick(object sender, EventArgs e)
        {
            //パスワードを隠す処理
            memberPasswordBox.UseSystemPasswordChar = !memberPasswordBox.UseSystemPasswordChar;
        }
    }
}
    
