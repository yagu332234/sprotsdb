using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Diagnostics;


namespace memberDB
{
    public partial class MemberUpdate : Form
    {
        public MemberUpdate()
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
            //main画面を表示
            Program.mainPage.MainForm = new Main();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }

       
        /// <summary>
        /// 更新処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateButtonClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("本当にこの内容で更新しますか？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //パス指定
                StreamWriter streamWriter = new StreamWriter(@"C:\Users\Gx563\OneDrive\デスクトップ\G2A227矢口元輝\memberDB\" + "password.csv", true);
                //氏名とパスワード取得
                string idPassword = memberNameBox.Text + "," + memberPassBox.Text;
                //氏名とパスワードをテキストに書く
                streamWriter.WriteLine(idPassword);
                //書くのを終了
                streamWriter.Close();
                using (SQLiteConnection con = new SQLiteConnection("Data Source=register.db"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        //アップデート
                        cmd.CommandText = "UPDATE t_product set memberName = @MemberName, memberHouse = @MemberHouse, memberPhone = @MemberPhone, memberBirthday=@MemberBirth, memberPassword=@MemberPass WHERE memberName = @MemberName";
                        //パラメータセット
                     
                        cmd.Parameters.Add("MemberName", System.Data.DbType.String);
                        cmd.Parameters.Add("MemberHouse", System.Data.DbType.String);
                        cmd.Parameters.Add("MemberPhone", System.Data.DbType.String);
                        cmd.Parameters.Add("MemberBirth", System.Data.DbType.String);
                        cmd.Parameters.Add("MemberPass", System.Data.DbType.String);
                        //データ追加
                        cmd.Parameters["MemberName"].Value = memberNameBox.Text;
                        cmd.Parameters["MemberHouse"].Value = memberHouseBox.Text;
                        cmd.Parameters["MemberPhone"].Value = memberPhoneBox.Text;
                        cmd.Parameters["MemberBirth"].Value = memberBirthBox.Text;
                        cmd.Parameters["MemberPass"].Value = memberPassBox.Text;
                        cmd.ExecuteNonQuery();
                        //
                        trans.Commit();


                        //登録完了表示
                        DialogResult　tResult = MessageBox.Show("更新完了しました!", "更新完了", MessageBoxButtons.OK);
                        //start画面遷移
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
        }
    }
}
