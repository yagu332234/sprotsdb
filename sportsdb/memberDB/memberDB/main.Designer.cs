
namespace memberDB
{
    partial class Main
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
            this.reserveButton = new System.Windows.Forms.Button();
            this.memberDeleteButton = new System.Windows.Forms.Button();
            this.memberUpdateButton = new System.Windows.Forms.Button();
            this.memberStatusButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(277, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "メインメニュー";
            // 
            // reserveButton
            // 
            this.reserveButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reserveButton.Location = new System.Drawing.Point(176, 130);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(139, 47);
            this.reserveButton.TabIndex = 1;
            this.reserveButton.Text = "予約画面";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButtonClick);
            // 
            // memberDeleteButton
            // 
            this.memberDeleteButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memberDeleteButton.Location = new System.Drawing.Point(380, 130);
            this.memberDeleteButton.Name = "memberDeleteButton";
            this.memberDeleteButton.Size = new System.Drawing.Size(142, 47);
            this.memberDeleteButton.TabIndex = 2;
            this.memberDeleteButton.Text = "会員削除";
            this.memberDeleteButton.UseVisualStyleBackColor = true;
            this.memberDeleteButton.Click += new System.EventHandler(this.memberDeleteButtonClick);
            // 
            // memberUpdateButton
            // 
            this.memberUpdateButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memberUpdateButton.Location = new System.Drawing.Point(176, 262);
            this.memberUpdateButton.Name = "memberUpdateButton";
            this.memberUpdateButton.Size = new System.Drawing.Size(151, 52);
            this.memberUpdateButton.TabIndex = 3;
            this.memberUpdateButton.Text = "会員情報更新画面";
            this.memberUpdateButton.UseVisualStyleBackColor = true;
            this.memberUpdateButton.Click += new System.EventHandler(this.memberUpdateButtonClick);
            // 
            // memberStatusButton
            // 
            this.memberStatusButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memberStatusButton.Location = new System.Drawing.Point(380, 262);
            this.memberStatusButton.Name = "memberStatusButton";
            this.memberStatusButton.Size = new System.Drawing.Size(142, 52);
            this.memberStatusButton.TabIndex = 4;
            this.memberStatusButton.Text = "会員情報画面";
            this.memberStatusButton.UseVisualStyleBackColor = true;
            this.memberStatusButton.Click += new System.EventHandler(this.memberStatusButtonClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(176, 337);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 75);
            this.button5.TabIndex = 5;
            this.button5.Text = "会員データ作成";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(31, 360);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(129, 52);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "戻るボタン";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(380, 337);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 75);
            this.button7.TabIndex = 7;
            this.button7.Text = "予約データ作成";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.memberStatusButton);
            this.Controls.Add(this.memberUpdateButton);
            this.Controls.Add(this.memberDeleteButton);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "メイン画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Button memberDeleteButton;
        private System.Windows.Forms.Button memberUpdateButton;
        private System.Windows.Forms.Button memberStatusButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button button7;
    }
}