
namespace memberDB
{
    partial class StartScreen
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
            this.roginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.newRegisterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dbCriate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(243, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "HCSスポーツクラブ会員登録";
            // 
            // roginButton
            // 
            this.roginButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roginButton.Location = new System.Drawing.Point(444, 186);
            this.roginButton.Name = "roginButton";
            this.roginButton.Size = new System.Drawing.Size(167, 105);
            this.roginButton.TabIndex = 2;
            this.roginButton.Text = "ログイン画面";
            this.roginButton.UseVisualStyleBackColor = true;
            this.roginButton.Click += new System.EventHandler(this.roginButtonClick);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(65, 348);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(167, 69);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "システム終了";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // newRegisterButton
            // 
            this.newRegisterButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newRegisterButton.Location = new System.Drawing.Point(210, 186);
            this.newRegisterButton.Name = "newRegisterButton";
            this.newRegisterButton.Size = new System.Drawing.Size(167, 105);
            this.newRegisterButton.TabIndex = 4;
            this.newRegisterButton.Text = "新規登録";
            this.newRegisterButton.UseVisualStyleBackColor = true;
            this.newRegisterButton.Click += new System.EventHandler(this.newRegisterButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(163, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "新規登録の人はこちらから！";
            // 
            // dbCriate
            // 
            this.dbCriate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dbCriate.Location = new System.Drawing.Point(518, 361);
            this.dbCriate.Name = "dbCriate";
            this.dbCriate.Size = new System.Drawing.Size(227, 48);
            this.dbCriate.TabIndex = 6;
            this.dbCriate.Text = "データベースの作成はこちら";
            this.dbCriate.UseVisualStyleBackColor = true;
            this.dbCriate.Click += new System.EventHandler(this.dbCriateClick);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dbCriate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newRegisterButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.roginButton);
            this.Controls.Add(this.label1);
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "スタート画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button roginButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button newRegisterButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dbCriate;
    }
}