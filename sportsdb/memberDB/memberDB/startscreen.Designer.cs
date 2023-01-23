
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
            this.mainButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.roginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.newRegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainButton
            // 
            this.mainButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainButton.Location = new System.Drawing.Point(151, 138);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(167, 69);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "メイン画面";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButtonClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(191, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "HCSスポーツクラブ会員登録";
            // 
            // roginButton
            // 
            this.roginButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roginButton.Location = new System.Drawing.Point(344, 138);
            this.roginButton.Name = "roginButton";
            this.roginButton.Size = new System.Drawing.Size(167, 69);
            this.roginButton.TabIndex = 2;
            this.roginButton.Text = "ログイン画面";
            this.roginButton.UseVisualStyleBackColor = true;
            this.roginButton.Click += new System.EventHandler(this.roginButtonClick);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(151, 254);
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
            this.newRegisterButton.Location = new System.Drawing.Point(344, 254);
            this.newRegisterButton.Name = "newRegisterButton";
            this.newRegisterButton.Size = new System.Drawing.Size(167, 69);
            this.newRegisterButton.TabIndex = 4;
            this.newRegisterButton.Text = "新規登録";
            this.newRegisterButton.UseVisualStyleBackColor = true;
            this.newRegisterButton.Click += new System.EventHandler(this.newRegisterButtonClick);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newRegisterButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.roginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainButton);
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "スタート画面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button roginButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button newRegisterButton;
    }
}