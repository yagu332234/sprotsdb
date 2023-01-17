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

        private void backButtonClick(object sender, EventArgs e)
        {
            SceneChange(sender, e);
        }


        private void SceneChange(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //main画面を表示
            Main main = new Main();
            main.Show();
        }
        private void memberDeleteButtonClick(object sender, EventArgs e)
        {
            
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
