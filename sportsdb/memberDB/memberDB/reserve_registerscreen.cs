using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;

namespace memberDB
{
    public partial class reserve_registerscreen : Form
    {
        public reserve_registerscreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;
            reserve_optionscreen ro = new reserve_optionscreen();
            ro.Show();
        }

        private void reserve_registerscreen_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Debug.Print(monthCalendar1.SelectionStart.ToShortDateString());
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
                        cmd.CommandText = "INSERT INTO y_product(day)" +
                            " VALUES(@Register_day)";
                        //パラメータセット
                        //日付
                        cmd.Parameters.Add("Register_day", System.Data.DbType.Int64);
                       
                        //データ追加
                        cmd.Parameters["Register_day"].Value = monthCalendar1.SelectionStart.ToShortDateString();
                      
                        cmd.ExecuteNonQuery();
                        //コミット
                        trans.Commit();

                    }
                }

            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Text = monthCalendar1.SelectionStart.ToShortDateString() + " ～" +
                monthCalendar1.SelectionEnd.ToShortDateString();
        }
    }
}
