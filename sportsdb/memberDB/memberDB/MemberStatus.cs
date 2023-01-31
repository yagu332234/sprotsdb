using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace memberDB
{
    public partial class MemberStatus : Form
    {
        public MemberStatus()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButtonClick(object sender, EventArgs e)
        {
            //MemberStatus画面を表示
            Program.mainPage.MainForm = new Main();
            Program.mainPage.MainForm.Show();
            //現在の画面を消す
            this.Close();
        }
        /// <summary>
        /// データベース表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void memberStatusButtonClick(object sender, EventArgs e)
        {
            string MemberName = memberNameBox.Text;
            using (SQLiteConnection conection = new SQLiteConnection("Data Source=register.db"))
            {
                //registerdbの生成
                DataTable dataTable = new DataTable();
                //条件
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE t_product.memberName" + " LIKE  '" + MemberName + "'",conection);
                
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
        }
    }
}
