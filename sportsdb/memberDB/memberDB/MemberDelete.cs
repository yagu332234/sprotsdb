using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace memberDB
{
    public partial class MemberDelete : Form
    {
        public MemberDelete()
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
            SceneChange(sender, e);
        }

        /// <summary>
        /// メイン画面に行く処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SceneChange(object sender, EventArgs e)
        {
            //Main画面を表示
            Program.mainPage.MainForm = new Main();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
        /// <summary>
        /// 会員削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void memberDeleteButtonClick(object sender, EventArgs e)
        {
            //確認表示
            DialogResult result = MessageBox.Show("本当に消してよろしいですか？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=register.db"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        //条件
                        cmd.CommandText = "DELETE FROM t_product WHERE memberId = @Mid";
                        //パラメータセット
                        cmd.Parameters.Add("Mid", System.Data.DbType.Int64);
                        //削除
                        cmd.Parameters["Mid"].Value = int.Parse(memberDeleteBox.Text);
                        cmd.ExecuteNonQuery();
                        //コミット
                        trans.Commit();
                    }
                }
                DialogResult t_Result = MessageBox.Show("登録削除しました", "登録完了", MessageBoxButtons.OK);
                //start画面遷移
                if (t_Result == DialogResult.OK)
                {
                    SceneChange(sender, e);
                }
            }
        }

      
    }
}
