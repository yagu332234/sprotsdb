﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace memberDB
{
    public partial class MemberUpdate : Form
    {
        public MemberUpdate()
        {
            InitializeComponent();
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //main画面を表示
            Main main = new Main();
            main.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=register.db"))
            {
               
                if (memberIdBox.Text == string.Empty)
                {

                    MessageBox.Show("数字を入力してください");
                }

                else
                {
                    //メッセージボックスの値の定義
                    int mi = int.Parse(memberIdBox.Text);
                    //tourokudbの生成
                    var dataTable = new DataTable();
                    //SQLの実行
                    //member_idと一致したデータを出力する
                    var adapter = new SQLiteDataAdapter($"SELECT * FROM t_product WHERE member_id = {mi}", con);
                    adapter.Fill(dataTable);
                    //データの表示
                    dataGridView1.DataSource = dataTable;
                }
            }
           
        }

        private void updateButtonClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("本当にこの内容でよろしいですか？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                }
            }
        }
    }
}