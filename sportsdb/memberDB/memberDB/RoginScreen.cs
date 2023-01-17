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
      
        private void button2_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;
            StartScreen startScreen = new StartScreen();
            startScreen.Show();
        }

         private void button1_Click(object sender, EventArgs e)
        {

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
              catch (SQLiteException ex)
              {

              }
             // return false;
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
                          if (id == drCurrent["member_id"].ToString()
                              && pass == drCurrent["member_password"].ToString())
                              return true;
                      }
                  }
                      //メッセージボックスの値の定義

                      //tourokudbの生成
                     // var dataTable = new DataTable();
                      //SQLの実行
                      //member_idと一致したデータを出力する
                     // var adapter = new SQLiteDataAdapter($"SELECT * FROM t_product WHERE member_id = {mi}", con);
                     // adapter.Fill(dataTable);


              }
              //次画面を非表示
             // this.Visible = false;
             // main ma = new main();
             // ma.Show();



          }
        */
    }
}
