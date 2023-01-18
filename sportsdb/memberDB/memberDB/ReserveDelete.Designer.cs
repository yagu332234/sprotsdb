
namespace memberDB
{
    partial class ReserveDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.reservebutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reserveDliteButton = new System.Windows.Forms.Button();
            this.reserveIdBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(197, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "削除したい予約を選択してください";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(80, 350);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(99, 48);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // reservebutton
            // 
            this.reservebutton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reservebutton.Location = new System.Drawing.Point(145, 182);
            this.reservebutton.Name = "reservebutton";
            this.reservebutton.Size = new System.Drawing.Size(114, 39);
            this.reservebutton.TabIndex = 2;
            this.reservebutton.Text = "予約表示";
            this.reservebutton.UseVisualStyleBackColor = true;
            this.reservebutton.Click += new System.EventHandler(this.reservebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 188);
            this.dataGridView1.TabIndex = 3;
            // 
            // reserveDliteButton
            // 
            this.reserveDliteButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reserveDliteButton.Location = new System.Drawing.Point(631, 350);
            this.reserveDliteButton.Name = "reserveDliteButton";
            this.reserveDliteButton.Size = new System.Drawing.Size(99, 48);
            this.reserveDliteButton.TabIndex = 4;
            this.reserveDliteButton.Text = "削除";
            this.reserveDliteButton.UseVisualStyleBackColor = true;
            this.reserveDliteButton.Click += new System.EventHandler(this.reserveDliteButton_Click);
            // 
            // reserveIdBox
            // 
            this.reserveIdBox.Location = new System.Drawing.Point(231, 115);
            this.reserveIdBox.Name = "reserveIdBox";
            this.reserveIdBox.Size = new System.Drawing.Size(268, 27);
            this.reserveIdBox.TabIndex = 5;
            // 
            // ReserveDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reserveIdBox);
            this.Controls.Add(this.reserveDliteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reservebutton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Name = "ReserveDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "予約削除画面";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button reservebutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button reserveDliteButton;
        private System.Windows.Forms.TextBox reserveIdBox;
    }
}