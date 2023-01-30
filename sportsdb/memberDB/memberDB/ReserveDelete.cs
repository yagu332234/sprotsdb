using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace memberDB
{
    public partial class ReserveDelete : Form
    {
        public ReserveDelete()
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
            //シーン切り替え
            SceneChange(sender, e);
        }
        /// <summary>
        /// シーン切り替えの処理
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
       

        private void reserveDliteButtonClick(object sender, EventArgs e)
        {
            //確認表示
            DialogResult result = MessageBox.Show("本当に削除してよろしいですか？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=reserve.db"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        //条件
                        cmd.CommandText = "DELETE FROM reserveProduct WHERE memberName = @MemberName";
                        //パラメータセット
                        cmd.Parameters.Add("MemberName", System.Data.DbType.String);
                        //削除
                        cmd.Parameters["MemberName"].Value = reserveIdBox.Text;
                        cmd.ExecuteNonQuery();
                        //コミット
                        trans.Commit();
                    }
                }
                DialogResult tResult = MessageBox.Show("予約削除しました", "予約削除完了", MessageBoxButtons.OK);
                //ReserveOption画面遷移
                if (tResult == DialogResult.OK)
                {
                    //シーン切り替え
                    SceneChange(sender, e);
                }
            }
        }
    }
}
