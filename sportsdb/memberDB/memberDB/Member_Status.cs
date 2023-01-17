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
    public partial class 会員情報表示 : Form
    {
        public 会員情報表示()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //start画面を表示
            main ma = new main();
            //画面表示
            ma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conection = new SQLiteConnection("Data Source=register.db"))
            {
                //tourokudbの生成
                var dataTable = new DataTable();
                //SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", conection);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
