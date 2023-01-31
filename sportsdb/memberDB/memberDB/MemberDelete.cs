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
            //画面切り替え
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
                        cmd.CommandText = "DELETE FROM t_product WHERE memberName = @MemberName";
                        //  型設定
                        cmd.Parameters.Add("MemberName", System.Data.DbType.String);
                        //パラメータセット
                        cmd.Parameters["MemberName"].Value = memberDeleteBox.Text;
                        cmd.ExecuteNonQuery();
                        //コミット
                        trans.Commit();
                    }
                }
                DialogResult tResult = MessageBox.Show("登録削除しました", "登録完了", MessageBoxButtons.OK);
                //画面遷移
                if (tResult == DialogResult.OK)
                {
                    //画面切り替え
                    SceneChange(sender, e);
                }
            }
        }
    }
}
