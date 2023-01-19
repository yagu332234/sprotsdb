
namespace memberDB
{
    partial class ReserveStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reserveStatusButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reserveIdBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // reserveStatusButton
            // 
            this.reserveStatusButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reserveStatusButton.Location = new System.Drawing.Point(125, 160);
            this.reserveStatusButton.Name = "reserveStatusButton";
            this.reserveStatusButton.Size = new System.Drawing.Size(153, 47);
            this.reserveStatusButton.TabIndex = 0;
            this.reserveStatusButton.Text = "予約表示";
            this.reserveStatusButton.UseVisualStyleBackColor = true;
            this.reserveStatusButton.Click += new System.EventHandler(this.reserveStatusButtonClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 246);
            this.dataGridView1.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(79, 359);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(114, 60);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(306, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "予約IDを入力してください";
            // 
            // reserveIdBox
            // 
            this.reserveIdBox.Location = new System.Drawing.Point(319, 94);
            this.reserveIdBox.Name = "reserveIdBox";
            this.reserveIdBox.Size = new System.Drawing.Size(262, 27);
            this.reserveIdBox.TabIndex = 4;
            // 
            // ReserveStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reserveIdBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reserveStatusButton);
            this.Name = "ReserveStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReserveStatus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reserveStatusButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reserveIdBox;
    }
}