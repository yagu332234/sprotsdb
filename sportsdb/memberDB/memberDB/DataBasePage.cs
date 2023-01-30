using System;
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
        /// <summary>
        /// 会員データベースの作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void memberDBClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("本当に会員データベースを作成してよろしいですか？（すでに作成している場合は作成できません）", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // コネクションを開いてテーブル作成して閉じる  
                using (SQLiteConnection con = new SQLiteConnection("Data Source=register.db"))
                {
                    con.Open();
                    using (SQLiteCommand command = con.CreateCommand())
                    {
                        command.CommandText =
                            "create table t_product(memberId INTEGER  PRIMARY KEY AUTOINCREMENT, memberName　TEXT, memberHouse TEXT, memberPhone TEXT, memberBirthday TEXT, memberPassword TEXT)";
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
                DialogResult = MessageBox.Show("会員データベースを作成しました", "作成完了", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// 予約データベースの作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reserveDBClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("本当に予約データベースを作成してよろしいですか？（すでに作成してる場合は作成できません）", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // コネクションを開いてテーブル作成して閉じる  
                using (var con = new SQLiteConnection("Data Source=reserve.db"))
                {
                    con.Open();
                    using (SQLiteCommand command = con.CreateCommand())
                    {
                        command.CommandText =
                            "create table reserveProduct(memberReserveId INTEGER  PRIMARY KEY AUTOINCREMENT, memberName TEXT, reserveEvent TEXT, day TEXT)";
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    DialogResult = MessageBox.Show("予約データベースを作成しました", "作成完了", MessageBoxButtons.OK);
                }
            }
        }
        /// <summary>
        /// 会員データベース削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void memberDBDeleteClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("本当に会員データベースを削除してよろしいですか？（すでにない場合は削除できません）", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
        /// <summary>
        /// 予約データベースの削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reserveDBDeleteClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("本当に予約データベースを削除してよろしいですか？（すでにない場合は削除できません）", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=reserve.db"))
                {
                    con.Open();
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {

                        cmd.CommandText = "drop table reserveProduct";
                        cmd.ExecuteNonQuery();

                    }
                    con.Close();
                }
                DialogResult = MessageBox.Show("予約データベースを削除しました", "削除完了", MessageBoxButtons.OK);

            }
        }
        /// <summary>
        /// 戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButtonClick(object sender, EventArgs e)
        {
            //start画面を表示
            Program.mainPage.MainForm = new StartScreen();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
    }
}
