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

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conection = new SQLiteConnection("Data Source=reserve.db"))
            {
                //reservedbの生成
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
            ReserveOption reserveOption = new ReserveOption();
            reserveOption.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*  DialogResult result = MessageBox.Show("本当にこの内容でよろしいですか？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
              if (result == DialogResult.Yes)
              {
                  using (SQLiteConnection con = new SQLiteConnection("Data Source=register.db"))
                  {
                      con.Open();
                      using (SQLiteTransaction trans = con.BeginTransaction())
                      {
                          SQLiteCommand cmd = con.CreateCommand();
                          //インサート
                          cmd.CommandText = "UPDATE t_product set memberName = @Mname, memberHouse = @Mhouse, memberPhone = @Mphone, memberBirthday=@Mbirth, memberPassword=@Mpass WHERE memberId = @Mid";
                          //パラメータセット
                          cmd.Parameters.Add("Mid", System.Data.DbType.Int64);
                          cmd.Parameters.Add("Mname", System.Data.DbType.String);
                          cmd.Parameters.Add("Mhouse", System.Data.DbType.String);
                          cmd.Parameters.Add("Mphone", System.Data.DbType.String);
                          cmd.Parameters.Add("Mbirth", System.Data.DbType.String);
                          cmd.Parameters.Add("Mpass", System.Data.DbType.String);
                          //データ追加
                          cmd.Parameters["Mid"].Value = int.Parse(memberIdBox.Text);
                          cmd.Parameters["Mname"].Value = memberNameBox.Text;
                          cmd.Parameters["Mhouse"].Value = memberHouseBox.Text;
                          cmd.Parameters["Mphone"].Value = memberPhoneBox.Text;
                          cmd.Parameters["Mbirth"].Value = memberBirthBox.Text;
                          cmd.Parameters["Mpass"].Value = memberPassBox.Text;
                          cmd.ExecuteNonQuery();
                          //
                          trans.Commit();

                      }
            */

        }
    }
}
