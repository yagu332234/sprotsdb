using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace memberDB
{
    public partial class RoginScreen : Form
    {


        public RoginScreen()
        {
            InitializeComponent();
        }

        protected void btnConfirm_OnClick(object sender, EventArgs e)
        {

            //if(button2_Click(id, pass))
            {

            }

        }

        private void backButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;
            //スタート画面に遷移
            StartScreen startScreen = new StartScreen();
            startScreen.Show();
        }

        private void roginButtonClick(object sender, EventArgs e)
        {
            //入力されたIDを取得
            string id = memberIdBox.Text;
            //入力されたpasswordを取得
            string pass = memberPasswordBox.Text;
            using (SQLiteConnection con = new SQLiteConnection("Data Source=register.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "UPDATE t_product set memberName = @Mname, memberHouse = @Mhouse, memberPhone = @Mphone, memberBirthday=@Mbirth, memberPassword=@Mpass WHERE memberId = @Mid";
                    //パラメータセット
                    using (SQLiteConnection conection = new SQLiteConnection("Data Source=register.db"))
                    {
                        //tourokudbの生成
                        var dataTable = new DataTable();
                        //SQLの実行
                        var adapter = new SQLiteDataAdapter("SELECT memberId memberPassword FROM t_product", conection);



                        if (id == "MemberId" && pass == "MemberPassword")
                        {

                            //現在の画面を非表示
                            this.Visible = false;
                            //スタート画面に遷移
                            Main main = new Main();
                            main.Show();
                        }
                        else
                        {
                            MessageBox.Show("IDかパスワードが違います");
                        }
                    }
                }
                /* using (SQLiteConnection conection = new SQLiteConnection("Data Source=register.db"))
                    {
                        //tourokudbの生成
                        var dataTable = new DataTable();
            //SQLの実行
            var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", conection);
            adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                     /* {
                      id = member_idbox.Text;
                      pass = member_password.Text;
                      try
                      {
                          using (SQLiteConnection con = new SQLiteConnection("Data Source=touroku.db"))
                          {
                              con.Open();
                              using (SQLiteDataAdapter sa = new SQLiteDataAdapter("SELECT * FROM t_product WHERE HASH", con))
                              {
                                  DataSet ds = new DataSet();
                                  sa.Fill(ds);
                                  DataTable dt = ds.Tables["t_product"];

                                  foreach (DataRow drCurrent in dt.Rows)
                                  {
                                  //    if (id == drCurrent["member_id"].ToString()
                                    //      && pass == drCurrent["member_password"].ToString())
                                        //  return true;
                                  }
                              }
                          }
                      }
                       using (SQLiteConnection con = new SQLiteConnection("Data Source=register.db"))
                        {
                            con.Open();
                            using (SQLiteTransaction trans = con.BeginTransaction())
                            {
                                SQLiteCommand cmd = con.CreateCommand();
                                //インサート
                                cmd.CommandText = "UPDATE t_product set memberName = @Mname, memberHouse = @Mhouse, memberPhone = @Mphone, memberBirthday=@Mbirth, memberPassword=@Mpass WHERE memberId = @Mid";
                                //パラメータセット
                */
            }
        }
    }
}
