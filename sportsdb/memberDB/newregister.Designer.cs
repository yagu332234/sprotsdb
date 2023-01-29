
namespace memberDB
{
    partial class NewRegister
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.housebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.phonebox = new System.Windows.Forms.MaskedTextBox();
            this.birthdaybox = new System.Windows.Forms.MaskedTextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(320, 91);
            this.nameBox.MaxLength = 15;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(196, 27);
            this.nameBox.TabIndex = 0;
            // 
            // housebox
            // 
            this.housebox.Location = new System.Drawing.Point(320, 154);
            this.housebox.MaxLength = 100;
            this.housebox.Name = "housebox";
            this.housebox.Size = new System.Drawing.Size(196, 27);
            this.housebox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(338, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "新規登録";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(247, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "氏名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(247, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "住所";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(217, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "電話番号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(217, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "生年月日";
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(320, 331);
            this.passwordbox.MaxLength = 100;
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(196, 27);
            this.passwordbox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(224, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "パスワード";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(29, 387);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(117, 51);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // phonebox
            // 
            this.phonebox.Location = new System.Drawing.Point(320, 217);
            this.phonebox.Mask = "99900-9990-0000";
            this.phonebox.Name = "phonebox";
            this.phonebox.Size = new System.Drawing.Size(196, 27);
            this.phonebox.TabIndex = 9;
            // 
            // birthdaybox
            // 
            this.birthdaybox.Location = new System.Drawing.Point(320, 276);
            this.birthdaybox.Mask = "0000年90月90日";
            this.birthdaybox.Name = "birthdaybox";
            this.birthdaybox.Size = new System.Drawing.Size(196, 27);
            this.birthdaybox.TabIndex = 11;
            this.birthdaybox.ValidatingType = typeof(System.DateTime);
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerButton.Location = new System.Drawing.Point(598, 387);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(117, 51);
            this.registerButton.TabIndex = 17;
            this.registerButton.Text = "次へ";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton);
            // 
            // NewRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.birthdaybox);
            this.Controls.Add(this.phonebox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.housebox);
            this.Controls.Add(this.nameBox);
            this.Name = "NewRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新規登録";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox housebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.MaskedTextBox phonebox;
        private System.Windows.Forms.MaskedTextBox birthdaybox;
        private System.Windows.Forms.Button registerButton;
    }
}