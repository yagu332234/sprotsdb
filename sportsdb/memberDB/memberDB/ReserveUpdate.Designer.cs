
namespace memberDB
{
    partial class ReserveUpdate
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
            this.updateButton = new System.Windows.Forms.Button();
            this.memberIdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "更新する予約の日付を選択してください";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(26, 379);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(146, 59);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "戻るボタン";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.Location = new System.Drawing.Point(576, 379);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(150, 59);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "更新";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButtonClick);
            // 
            // memberIdBox
            // 
            this.memberIdBox.Location = new System.Drawing.Point(292, 137);
            this.memberIdBox.Name = "memberIdBox";
            this.memberIdBox.Size = new System.Drawing.Size(223, 27);
            this.memberIdBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(189, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "予約ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(141, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "予約日付";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(278, 231);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // ReserveUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memberIdBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Name = "ReserveUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reserve_Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox memberIdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}