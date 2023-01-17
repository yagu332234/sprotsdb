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
    public partial class reserve_Update : Form
    {
        public reserve_Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conection = new SQLiteConnection("Data Source=reserve.db"))
            {
                //tourokudbの生成
                var dataTable = new DataTable();
                //SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM y_product", conection);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //現在の画面を閉じる
            this.Visible = false;
            reserve_optionscreen rOption = new reserve_optionscreen();
            rOption.Show();
        }
    }
}
