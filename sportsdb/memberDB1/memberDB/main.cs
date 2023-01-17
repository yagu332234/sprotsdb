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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
  private void NewRegister_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //現在の画面を閉じる
            this.Visible = false;
            reserve_optionscreen ro = new reserve_optionscreen();
            ro.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        //会員登録のテーブル作成
        private void button5_Click(object sender, EventArgs e)
        {
            // コネクションを開いてテーブル作成して閉じる  
            using (var con = new SQLiteConnection("Data Source=register.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText =
                        "create table t_product(member_id INTEGER  PRIMARY KEY AUTOINCREMENT, member_name TEXT, member_house TEXT, member_phone TEXT, member_birthday TEXT, member_password TEXT)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //現在の画面を閉じる
            this.Visible = false;
            //会員削除画面を表示
            Member_Delite md = new Member_Delite();
            md.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //start画面を表示
            startScreen ss = new startScreen();
            //画面表示
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //start画面を表示
            Member_Update mu = new Member_Update();
            //画面表示
            mu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //start画面を表示
            会員情報表示 ms = new 会員情報表示();
            //画面表示
            ms.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
            // コネクションを開いてテーブル作成して閉じる  
            using (var con = new SQLiteConnection("Data Source=reserve.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText =
                        "create table y_product(member_reserve INTEGER  PRIMARY KEY AUTOINCREMENT, member_id INTEGER, day INTEGER, manager TEXT)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
