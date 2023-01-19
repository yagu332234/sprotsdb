using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            //日付を入れる変数（いらないかも）
            string day1 = monthCalendar1.SelectionStart.ToShortDateString();
            //確認用
            Debug.Print(day1);
            DialogResult result = MessageBox.Show("本当にこの内容でよろしいですか？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=reserve.db"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        //インサート
                        cmd.CommandText = "INSERT INTO reserveProduct(day)" +
                            " VALUES(@ReserveDay)";
                        //パラメータセット
                        //日付
                        cmd.Parameters.Add("ReserveDay", System.Data.DbType.String);

                        //データ追加
                        cmd.Parameters["ReserveDay"].Value = day1;
                      
                        cmd.ExecuteNonQuery();
                        //コミット
                        trans.Commit();

                        //登録完了表示
                        DialogResult t_Result = MessageBox.Show("予約完了しました!", "予約完了", MessageBoxButtons.OK);
                        /*
                          command.CommandText =
                        "create table reserveProduct(memberReserveId INTEGER  PRIMARY KEY AUTOINCREMENT, memberId INTEGER, day TEXT)";
                    command.ExecuteNonQuery();
                         */
                    }
                }

            }
        }
      
    }
}
