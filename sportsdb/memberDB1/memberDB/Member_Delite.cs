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
    public partial class Member_Delite : Form
    {
        public Member_Delite()
        {
            InitializeComponent();
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //main画面を表示
            main ma = new main();
            ma.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("本当に消してよろしいですか？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=register.db"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        //条件
                        cmd.CommandText = "DELETE FROM t_product WHERE member_id = @Mid";
                        //パラメータセット
                        cmd.Parameters.Add("Mid", System.Data.DbType.Int64);
                        //削除
                        cmd.Parameters["Mid"].Value = int.Parse(m_deletebox.Text);
                        cmd.ExecuteNonQuery();
                        //コミット
                        trans.Commit();
                    }
                }
                DialogResult t_Result = MessageBox.Show("登録削除しました", "登録完了", MessageBoxButtons.OK);
                //start画面遷移
                if (t_Result == DialogResult.OK)
                {
                    //次画面を非表示
                    this.Visible = false;

                    //Form2を表示
                    main mScreen = new main();
                    //start画面を表示
                    mScreen.Show();
                }
            }
        }

      
    }
}
