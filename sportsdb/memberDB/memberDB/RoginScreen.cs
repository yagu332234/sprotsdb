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
            if (memberIdBox.Text==null || memberPasswordBox==null)
            {
                MessageBox.Show("パスワードか名前が一致しません");
            }
            else
            {
                bool fault = true;
                StreamReader sr = new StreamReader(@"c:\memberDB\" + "password.csv");
                while (sr.Peek() > -1)
                {
                    string s = sr.ReadLine();
                    string[] sArray = s.Split(",");

                    if(sArray[1]==memberPasswordBox.Text && sArray[0] == memberIdBox.Text)
                    {
                        fault = false;
                        
                    }
                }
                sr.Close();

                if (fault == true)
                {
                    MessageBox.Show("パスワードが一致しませんでした");
                    //テキストの値を空白にする
                    memberIdBox.Text = "";
                    //テキストの値を空白にする
                    memberPasswordBox.Text = "";

                }
                else
                {
                    //main画面を表示
                    Program.mainPage.MainForm = new Main();
                    Program.mainPage.MainForm.Show();
                    //現在の画面を消す
                    this.Close();
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
            memberPasswordBox.UseSystemPasswordChar = !memberPasswordBox.UseSystemPasswordChar;
        }
    }
}
    
