using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;

namespace memberDB
{
    public partial class DataBasePage : Form
    {
        public DataBasePage()
        {
            InitializeComponent();
        }

        private void memberDBClick(object sender, EventArgs e)
        {
            // コネクションを開いてテーブル作成して閉じる  
            using (SQLiteConnection con = new SQLiteConnection("Data Source=register.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText =
                        "create table t_product(memberId INTEGER  PRIMARY KEY AUTOINCREMENT, memberName TEXT, memberHouse TEXT, memberPhone TEXT, memberBirthday TEXT, memberPassword TEXT)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
            DialogResult = MessageBox.Show("会員データベースを作成しました", "作成完了", MessageBoxButtons.OK);
        }

        private void reserveDBClick(object sender, EventArgs e)
        {
            // コネクションを開いてテーブル作成して閉じる  
            using (var con = new SQLiteConnection("Data Source=reserve.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText =
                        "create table reserveProduct(memberReserveId INTEGER  PRIMARY KEY AUTOINCREMENT, memberId INTEGER, day TEXT)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private void memberDBDeleteClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("本当に会員データベースを削除してよろしいですか？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=register.db"))
                {
                    con.Open();
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {

                        cmd.CommandText = "drop table t_product";
                        cmd.ExecuteNonQuery();

                    }
                    con.Close();
                }
                DialogResult = MessageBox.Show("会員データベースを削除しました", "削除完了", MessageBoxButtons.OK);
                
            }
        }

        private void reserveDBDeleteClick(object sender, EventArgs e)
        {

        }

        private void backButtonClick(object sender, EventArgs e)
        {

        }
    }
}
