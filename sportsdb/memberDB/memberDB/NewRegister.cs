using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace memberDB
{
    public partial class NewRegister : Form
    {
        
        public NewRegister()
        {
            InitializeComponent();
        }
        
       /// <summary>
       /// 戻るボタン
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void BackButtonClick(object sender, EventArgs e)
        {
            
              //次画面を非表示
             /*  this.Visible = false;

              //startscreenを表示
              StartScreen startScreen = new StartScreen();
              //start画面を表示
              startScreen.Show();
            */
           SceneChange(sender, e);
        }

        private void SceneChange(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //startscreenを表示
            StartScreen startScreen = new StartScreen();
            //start画面を表示
            startScreen.Show();
        }
        /// <summary>
        /// 次へボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton(object sender, EventArgs e)
        {
            //排除するための定数
             char space = ' ';
             char hihun = '-';

             char year = '年';
             char month = '月';
             char day = '日';

            //切り分けるための文字の配列
            char[] deleteItem = new char[]
            {
                space,
                hihun,
                year,
                month,
                day

            };

            //空で最初に定義する
            string phoneValue = "";
            string birthValue = "";
            //テキストの値取得
            string phoneDeleteValue = phonebox.Text;
            string birthDeleteValue = birthdaybox.Text;
            //値を切り分ける
            foreach (string phoneInsertValue in phoneDeleteValue.Split(deleteItem))
            {
                //入力された項目を入れる
                phoneValue += phoneInsertValue;
               
            };

            foreach (string birthInsertValue in birthDeleteValue.Split(deleteItem))
            {

                //入力された項目を入れる
                 birthValue += birthInsertValue;

            };

            //ポップアップの表示
            DialogResult result = MessageBox.Show("本当にこの内容でよろしいですか？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                
                //入力項目に空欄がないか調べる
                if (nameBox.Text == string.Empty || housebox.Text == string.Empty || phoneValue== string.Empty  || birthValue == string.Empty || passwordbox.Text == string.Empty )
                {
                    MessageBox.Show("入力事項に不備があります");
                }
                else
                {
                    using (SQLiteConnection con = new SQLiteConnection("Data Source=register.db"))
                    {
                        con.Open();
                        using (SQLiteTransaction trans = con.BeginTransaction())
                        {
                            SQLiteCommand cmd = con.CreateCommand();
                            //インサート
                            cmd.CommandText = "INSERT INTO t_product(memberName, memberHouse, memberPhone, memberBirthday, memberPassword)" +
                                " VALUES(@Membername, @Memberhouse, @Memberphone, @Memberbirthday, @Memberpassword)";
                            //パラメータセット
                            //氏名
                            cmd.Parameters.Add("Membername", System.Data.DbType.String);
                            //住所
                            cmd.Parameters.Add("Memberhouse", System.Data.DbType.String);
                            //電話番号
                            cmd.Parameters.Add("Memberphone", System.Data.DbType.String);
                            //誕生日
                            cmd.Parameters.Add("Memberbirthday", System.Data.DbType.String);
                            //パスワード
                            cmd.Parameters.Add("Memberpassword", System.Data.DbType.String);
                            //データ追加
                            cmd.Parameters["Membername"].Value = nameBox.Text;
                            cmd.Parameters["Memberhouse"].Value = housebox.Text;
                            cmd.Parameters["Memberphone"].Value = phonebox.Text;
                            cmd.Parameters["Memberbirthday"].Value = birthdaybox.Text;
                            cmd.Parameters["Memberpassword"].Value = passwordbox.Text;
                            cmd.ExecuteNonQuery();
                            //コミット
                            trans.Commit();

                        }
                        //登録完了表示
                        DialogResult t_Result = MessageBox.Show("登録完了しました!", "登録完了", MessageBoxButtons.OK);
                        //start画面遷移
                        if (t_Result == DialogResult.OK)
                        {
                            SceneChange(sender, e);
                        }
                    }

         
                }
            }
        }

      
    }
}
