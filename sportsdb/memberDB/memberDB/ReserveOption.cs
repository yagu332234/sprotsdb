using System;
using System.Windows.Forms;

namespace memberDB
{
    public partial class ReserveOption : Form
    {
        public ReserveOption()
        {
            InitializeComponent();
        }

        private void reserveOptionButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;
            ReserveRegister reserveRegister = new ReserveRegister();
            reserveRegister.Show();
        }

        private void reserveDeleteButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;
            ReserveDelete reserveDelete = new ReserveDelete();
            reserveDelete.Show();
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;
            Main main = new Main();
            main.Show();
        }

        private void reserveUpdateButtonClick(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;
            ReserveUpdate reserveUpdate = new ReserveUpdate();
            reserveUpdate.Show();
        }
    }
}
