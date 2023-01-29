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
        /// <summary>
        /// 予約表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reservebuttonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=reserve.db"))
            {
                /*
                 *  "create table reserveProduct(memberReserveId INTEGER  PRIMARY KEY AUTOINCREMENT, memberId INTEGER, day TEXT)";
                */
                if (reserveIdBox.Text == string.Empty)
                {

                    MessageBox.Show("数字を入力してください");
                }

                else
                {
                    //メッセージボックスの値の定義
                    int mi = int.Parse(reserveIdBox.Text);
                    //reservedbの生成
                    var dataTable = new DataTable();
                    //SQLの実行
                    //member_idと一致したデータを出力する
                    var adapter = new SQLiteDataAdapter($"SELECT * FROM reserveProduct WHERE memberReserveId = {mi}", con);
                    adapter.Fill(dataTable);
                    //データの表示
                    reserveGridView.DataSource = dataTable;
                }
            }
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
                        cmd.CommandText = "DELETE FROM reserveProduct WHERE reserveId = @reserveid";
                        //パラメータセット
                        cmd.Parameters.Add("reserveid", System.Data.DbType.Int64);
                        //削除
                        cmd.Parameters["reserveid"].Value = int.Parse(reserveIdBox.Text);
                        cmd.ExecuteNonQuery();
                        //コミット
                        trans.Commit();
                    }
                }
                DialogResult t_Result = MessageBox.Show("予約削除しました", "予約削除完了", MessageBoxButtons.OK);
                //ReserveOption画面遷移
                if (t_Result == DialogResult.OK)
                {
                    //シーン切り替え
                    SceneChange(sender, e);
                }
            }
        }
    }
}
