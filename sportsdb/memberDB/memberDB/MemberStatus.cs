using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace memberDB
{
    public partial class 会員情報表示 : Form
    {
        public 会員情報表示()
        {
            InitializeComponent();
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //main画面を表示
            Main main = new Main();
            //画面表示
            main.Show();
        }

        private void memberStatusButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection conection = new SQLiteConnection("Data Source=register.db"))
            {
                //registerdbの生成
                var dataTable = new DataTable();
                //SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", conection);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
