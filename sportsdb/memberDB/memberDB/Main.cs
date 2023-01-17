using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace memberDB
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
  private void NewRegister_Load(object sender, EventArgs e)
        {
            
        }
        private void reserveButtonClick(object sender, EventArgs e)
        {
            //現在の画面を閉じる
            this.Visible = false;
            ReserveOption ro = new ReserveOption();
            ro.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        //会員登録のテーブル作成
        private void button5_Click(object sender, EventArgs e)
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
        }

        private void memberDeleteButtonClick(object sender, EventArgs e)
        {
            //現在の画面を閉じる
            this.Visible = false;
            //会員削除画面を表示
            MemberDelete md = new MemberDelete();
            md.Show();
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //start画面を表示
            StartScreen startScreen = new StartScreen();
            //画面表示
            startScreen.Show();
        }

        private void memberUpdateButtonClick(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //start画面を表示
            MemberUpdate mu = new MemberUpdate();
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
                        "create table y_product(memberReserve INTEGER  PRIMARY KEY AUTOINCREMENT, memberId INTEGER, day TEXT, manager TEXT)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
