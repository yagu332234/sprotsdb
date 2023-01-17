
namespace memberDB
{
    partial class RoginScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.member_idbox = new System.Windows.Forms.TextBox();
            this.member_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "会員IDとパスワードを入力してください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(88, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "会員ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(88, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "パスワード";
            // 
            // member_idbox
            // 
            this.member_idbox.Location = new System.Drawing.Point(188, 106);
            this.member_idbox.Name = "member_idbox";
            this.member_idbox.Size = new System.Drawing.Size(194, 27);
            this.member_idbox.TabIndex = 3;
            // 
            // member_password
            // 
            this.member_password.Location = new System.Drawing.Point(188, 261);
            this.member_password.Name = "member_password";
            this.member_password.Size = new System.Drawing.Size(194, 27);
            this.member_password.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "ログイン";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(101, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 58);
            this.button2.TabIndex = 6;
            this.button2.Text = "戻る";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.member_password);
            this.Controls.Add(this.member_idbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ログイン画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox member_idbox;
        private System.Windows.Forms.TextBox member_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}