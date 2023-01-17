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
    public partial class Member_Update : Form
    {
        public Member_Update()
        {
            InitializeComponent();
        }
      /*  bool M_namechange = false;
        bool M_housechange = false;
        bool M_phone = false;
        bool M_birth = false;
        bool M_pass = false;
      
        private void Member_Update_Load(object sender, EventArgs e)
        {
          
        }
      */
        private void button1_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //main画面を表示
            main ma = new main();
            ma.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=register.db"))
            {
               
                if (member_idbox.Text == string.Empty)
                {

                    MessageBox.Show("数字を入力してください");
                }

                else
                {
                    //メッセージボックスの値の定義
                    int mi = int.Parse(member_idbox.Text);
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

        private void button3_Click(object sender, EventArgs e)
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
                        cmd.Parameters["Mid"].Value = int.Parse(member_idbox.Text);
                        cmd.Parameters["Mname"].Value = m_name_box.Text;
                        cmd.Parameters["Mhouse"].Value = m_housebox.Text;
                        cmd.Parameters["Mphone"].Value = m_phonebox.Text;
                        cmd.Parameters["Mbirth"].Value = m_birthbox.Text;
                        cmd.Parameters["Mpass"].Value = m_passbox.Text;
                        cmd.ExecuteNonQuery();
                        //
                        trans.Commit();

                    }
                }
            }
        }
    }
}
