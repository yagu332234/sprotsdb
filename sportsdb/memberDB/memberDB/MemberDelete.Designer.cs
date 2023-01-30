
namespace memberDB
{
    partial class MemberDelete
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
            this.memberDeleteBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.memberDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memberDeleteBox
            // 
            this.memberDeleteBox.Location = new System.Drawing.Point(274, 131);
            this.memberDeleteBox.Name = "memberDeleteBox";
            this.memberDeleteBox.Size = new System.Drawing.Size(210, 27);
            this.memberDeleteBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(196, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "削除したい氏名を入力して下さい";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(146, 282);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(101, 63);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // memberDeleteButton
            // 
            this.memberDeleteButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memberDeleteButton.Location = new System.Drawing.Point(517, 273);
            this.memberDeleteButton.Name = "memberDeleteButton";
            this.memberDeleteButton.Size = new System.Drawing.Size(101, 63);
            this.memberDeleteButton.TabIndex = 3;
            this.memberDeleteButton.Text = "削除";
            this.memberDeleteButton.UseVisualStyleBackColor = true;
            this.memberDeleteButton.Click += new System.EventHandler(this.memberDeleteButtonClick);
            // 
            // MemberDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memberDeleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memberDeleteBox);
            this.Name = "MemberDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会員削除";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox memberDeleteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button memberDeleteButton;
    }
}