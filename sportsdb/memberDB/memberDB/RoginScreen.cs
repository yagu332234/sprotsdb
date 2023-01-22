using System;
using System.Data;
using System.Windows.Forms;
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
        /// パスワードを隠す判定をする変数
        /// </summary>
        private bool passwordcheck = false;
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
            Debug.Print("a");
            Console.WriteLine("a");
                //入力されたIDを取得
                string id = memberIdBox.Text;
            //入力されたpasswordを取得
            string pass = memberPasswordBox.Text;
            using (SQLiteConnection con = new SQLiteConnection("Data Source=register.db"))
            {

                con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                   
                        SQLiteCommand cmd = con.CreateCommand();
                        //条件

                     //   cmd.CommandText = ($"SELECT memberId, memberPassword FROM t_product", con);
                        
                    Debug.Print(cmd.CommandText);
                    if (memberIdBox.Text == cmd.CommandText)
                    {
                        Debug.Print("成功");
                    }
                    else
                    {
                        Debug.Print("失敗");
                    }

                    using (SQLiteConnection conection = new SQLiteConnection("Data Source=register.db"))
                    {
                        //registerdbの生成
                        var dataTable = new DataTable();
                        //SQLの実行
                        var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", conection);
                        adapter.Fill(dataTable);
                        Debug.Print("");
                    }
                        /*
               
                    DialogResult t_Result = MessageBox.Show("登録削除しました", "登録完了", MessageBoxButtons.OK);
                    //start画面遷移
                    if (t_Result == DialogResult.OK)
                    {
                        SceneChange(sender, e);
                    }
                }
                        */
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
            if (passwordcheck == false)
            {
                passwordcheck = true;
                memberPasswordBox.PasswordChar = '*';
            }
            else
            {
                passwordcheck = false;
                memberPasswordBox.PasswordChar = '\0';
            }
        }
    }
}
    
