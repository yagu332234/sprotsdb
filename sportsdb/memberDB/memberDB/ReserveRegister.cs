using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;

namespace memberDB
{
    public partial class ReserveRegister : Form
    {
        public ReserveRegister()
        {
            InitializeComponent();
            reserveEvent.KeyPress += new KeyPressEventHandler(conboBoxKeyPress);
        }

       
        /// <summary>
        /// 戻る処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButtonClick(object sender, EventArgs e)
        {
            SceneChange(sender, e);
        }
        /// <summary>
        /// 画面遷移の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SceneChange(object sender, EventArgs e)
        {
            //ReserveOption画面を表示
            Program.mainPage.MainForm = new ReserveOption();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }

        /// <summary>
        /// 予約登録
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButtonClick(object sender, EventArgs e)
        {
            //日付を入れる変数
            string day1 = monthCalendar1.SelectionStart.ToShortDateString();
            //確認用
            
            DialogResult result = MessageBox.Show("本当にこの内容登録しますがよろしいですか？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=reserve.db"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        //インサート
                        cmd.CommandText = "INSERT INTO reserveProduct(memberName,reserveEvent,day)" +
                            " VALUES(@MemberName,@ReserveEvent,@ReserveDay)";
                        //パラメータセット
                        //予約氏名
                        cmd.Parameters.Add("MemberName",System.Data.DbType.String);
                        //予約種目
                        cmd.Parameters.Add("ReserveEvent",System.Data.DbType.String);
                        //日付
                        cmd.Parameters.Add("ReserveDay",System.Data.DbType.String);

                        //データ追加
                        cmd.Parameters["MemberName"].Value = memberNameBox.Text;
                        cmd.Parameters["ReserveEvent"].Value = reserveEvent.Text;
                        cmd.Parameters["ReserveDay"].Value = day1;
                        cmd.ExecuteNonQuery();
                        //コミット
                        trans.Commit();

                        //登録完了表示
                        DialogResult tResult = MessageBox.Show("登録完了しました!", "登録完了", MessageBoxButtons.OK);
                        //start画面遷移
                        if (tResult == DialogResult.OK)
                        {
                            //画面切り替え
                            SceneChange(sender, e);
                        }
                    }
                }

            }
        }
      
        private void conboBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
