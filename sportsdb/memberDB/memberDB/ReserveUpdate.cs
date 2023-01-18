using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace memberDB
{
    public partial class ReserveUpdate : Form
    {
        public ReserveUpdate()
        {
            InitializeComponent();
        }
        /// <summary>
        /// データベース表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conection = new SQLiteConnection("Data Source=reserve.db"))
            {
                //reservedbの生成
                var dataTable = new DataTable();
                //SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM reserveProduct", conection);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        /// <summary>
        /// 戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButtonClick(object sender, EventArgs e)
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
                        cmd.CommandText = "UPDATE reserveProduct set day = @Day memberId=@MemberId WHERE memberReserveId = @MemberReserveId";
                        //パラメータセット
                        cmd.Parameters.Add("MemberReserveId", System.Data.DbType.Int64);
                        cmd.Parameters.Add("Day", System.Data.DbType.String);
                        //データ追加
                        cmd.Parameters["MemberReserveId"].Value = int.Parse(memberIdBox.Text);
                        cmd.Parameters["Day"].Value = monthCalendar1.SelectionStart.ToShortDateString();

                        cmd.ExecuteNonQuery();
                        //
                        trans.Commit();
                        /*
                         create table reserveProduct(memberReserveId INTEGER  PRIMARY KEY AUTOINCREMENT, memberId INTEGER, day TEXT)";
                  command.ExecuteNonQuery();
                        monthCalendar1.SelectionStart.ToShortDateString();
                         */
                    }


                }
            }
        }
    }
}
