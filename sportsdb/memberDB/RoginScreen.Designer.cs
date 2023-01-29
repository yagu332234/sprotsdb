
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
            this.memberIdBox = new System.Windows.Forms.TextBox();
            this.memberPasswordBox = new System.Windows.Forms.TextBox();
            this.roginButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.maskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(208, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "会員IDとパスワードを入力してください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(66, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "会員ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(66, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "パスワード";
            // 
            // memberIdBox
            // 
            this.memberIdBox.Location = new System.Drawing.Point(188, 106);
            this.memberIdBox.Name = "memberIdBox";
            this.memberIdBox.Size = new System.Drawing.Size(194, 27);
            this.memberIdBox.TabIndex = 3;
            // 
            // memberPasswordBox
            // 
            this.memberPasswordBox.Location = new System.Drawing.Point(188, 261);
            this.memberPasswordBox.Name = "memberPasswordBox";
            this.memberPasswordBox.Size = new System.Drawing.Size(194, 27);
            this.memberPasswordBox.TabIndex = 4;
            this.memberPasswordBox.UseSystemPasswordChar = true;
            // 
            // roginButton
            // 
            this.roginButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roginButton.Location = new System.Drawing.Point(563, 339);
            this.roginButton.Name = "roginButton";
            this.roginButton.Size = new System.Drawing.Size(120, 62);
            this.roginButton.TabIndex = 5;
            this.roginButton.Text = "ログイン";
            this.roginButton.UseVisualStyleBackColor = true;
            this.roginButton.Click += new System.EventHandler(this.roginButtonClick);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(104, 339);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 62);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // maskButton
            // 
            this.maskButton.Location = new System.Drawing.Point(409, 261);
            this.maskButton.Name = "maskButton";
            this.maskButton.Size = new System.Drawing.Size(44, 27);
            this.maskButton.TabIndex = 7;
            this.maskButton.Text = "👁";
            this.maskButton.UseVisualStyleBackColor = true;
            this.maskButton.Click += new System.EventHandler(this.maskButtonClick);
            // 
            // RoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.roginButton);
            this.Controls.Add(this.memberPasswordBox);
            this.Controls.Add(this.memberIdBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ログイン";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox memberIdBox;
        private System.Windows.Forms.TextBox memberPasswordBox;
        private System.Windows.Forms.Button roginButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button maskButton;
    }
}