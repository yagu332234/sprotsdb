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
            //MemberStatus画面を表示
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

        private void reserveDliteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
