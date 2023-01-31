using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace memberDB
{
    public partial class ReserveUpdate : Form
    {
        public ReserveUpdate()
        {
            InitializeComponent();
            reserveEvent.KeyPress += new KeyPressEventHandler(conboBoxKeyPress);
        }
        
        /// <summary>
        /// 戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButtonClick(object sender, EventArgs e)
        {
            SceneChange(sender,e);
        }
        private void SceneChange(object sender, EventArgs e)
        {

            //ReserveOption画面を表示
            Program.mainPage.MainForm = new ReserveOption();
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
            //ダイアログ表示
            DialogResult result = MessageBox.Show("本当にこの内容更新してよろしいですか？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=reserve.db"))
                {

                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        //インサート
                        cmd.CommandText = "UPDATE reserveProduct set memberName=@MemberName,reserveEvent=@ReserveEvent,day = @Day WHERE memberName = @MemberName";
                        //パラメータセット
                        cmd.Parameters.Add("MemberName", System.Data.DbType.String);
                        cmd.Parameters.Add("ReserveEvent", System.Data.DbType.String);
                        cmd.Parameters.Add("Day", System.Data.DbType.String);
                        //データ追加
                        cmd.Parameters["MemberName"].Value = memberNameBox.Text;
                        cmd.Parameters["ReserveEvent"].Value = reserveEvent.Text;
                        cmd.Parameters["Day"].Value = monthCalendar1.SelectionStart.ToShortDateString();

                        cmd.ExecuteNonQuery();
                        //
                        trans.Commit();

                        //登録完了表示
                        DialogResult tResult = MessageBox.Show("予約更新が完了しました!", "予約更新完了", MessageBoxButtons.OK);
                        if (tResult == DialogResult.OK)
                        {
                            SceneChange(sender, e);
                        }
                    }


                }
            }
        }
        /// <summary>
        /// コンボボックスの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void conboBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
