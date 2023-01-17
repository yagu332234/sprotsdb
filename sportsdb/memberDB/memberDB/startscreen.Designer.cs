
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
            this.memberRegisterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.roginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.newRegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memberRegisterButton
            // 
            this.memberRegisterButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memberRegisterButton.Location = new System.Drawing.Point(151, 138);
            this.memberRegisterButton.Name = "memberRegisterButton";
            this.memberRegisterButton.Size = new System.Drawing.Size(136, 69);
            this.memberRegisterButton.TabIndex = 0;
            this.memberRegisterButton.Text = "会員登録";
            this.memberRegisterButton.UseVisualStyleBackColor = true;
            this.memberRegisterButton.Click += new System.EventHandler(this.memberRegisterButtonClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(252, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "スタート画面";
            // 
            // roginButton
            // 
            this.roginButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roginButton.Location = new System.Drawing.Point(310, 138);
            this.roginButton.Name = "roginButton";
            this.roginButton.Size = new System.Drawing.Size(159, 69);
            this.roginButton.TabIndex = 2;
            this.roginButton.Text = "ログイン画面";
            this.roginButton.UseVisualStyleBackColor = true;
            this.roginButton.Click += new System.EventHandler(this.roginButtonClick);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(103, 327);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(137, 41);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "システム終了";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // newRegisterButton
            // 
            this.newRegisterButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newRegisterButton.Location = new System.Drawing.Point(240, 239);
            this.newRegisterButton.Name = "newRegisterButton";
            this.newRegisterButton.Size = new System.Drawing.Size(136, 69);
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
            this.Controls.Add(this.memberRegisterButton);
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "スタート画面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button memberRegisterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button roginButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button newRegisterButton;
    }
}