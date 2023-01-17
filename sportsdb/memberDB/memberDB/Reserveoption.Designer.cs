
namespace memberDB
{
    partial class ReserveOption
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
            this.reserveOptopnButton = new System.Windows.Forms.Button();
            this.reserveDeleteButton = new System.Windows.Forms.Button();
            this.reserveUpdateButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(329, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "予約選択";
            // 
            // reserveOptopnButton
            // 
            this.reserveOptopnButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reserveOptopnButton.Location = new System.Drawing.Point(218, 147);
            this.reserveOptopnButton.Name = "reserveOptopnButton";
            this.reserveOptopnButton.Size = new System.Drawing.Size(124, 46);
            this.reserveOptopnButton.TabIndex = 1;
            this.reserveOptopnButton.Text = "予約登録";
            this.reserveOptopnButton.UseVisualStyleBackColor = true;
            this.reserveOptopnButton.Click += new System.EventHandler(this.reserveOptionButtonClick);
            // 
            // reserveDeleteButton
            // 
            this.reserveDeleteButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reserveDeleteButton.Location = new System.Drawing.Point(433, 147);
            this.reserveDeleteButton.Name = "reserveDeleteButton";
            this.reserveDeleteButton.Size = new System.Drawing.Size(106, 46);
            this.reserveDeleteButton.TabIndex = 2;
            this.reserveDeleteButton.Text = "予約削除";
            this.reserveDeleteButton.UseVisualStyleBackColor = true;
            this.reserveDeleteButton.Click += new System.EventHandler(this.reserveDeleteButtonClick);
            // 
            // reserveUpdateButton
            // 
            this.reserveUpdateButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reserveUpdateButton.Location = new System.Drawing.Point(218, 268);
            this.reserveUpdateButton.Name = "reserveUpdateButton";
            this.reserveUpdateButton.Size = new System.Drawing.Size(124, 48);
            this.reserveUpdateButton.TabIndex = 3;
            this.reserveUpdateButton.Text = "予約更新";
            this.reserveUpdateButton.UseVisualStyleBackColor = true;
            this.reserveUpdateButton.Click += new System.EventHandler(this.reserveUpdateButtonClick);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(72, 380);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(106, 48);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // ReserveOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.reserveUpdateButton);
            this.Controls.Add(this.reserveDeleteButton);
            this.Controls.Add(this.reserveOptopnButton);
            this.Controls.Add(this.label1);
            this.Name = "ReserveOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "予約選択画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reserveOptopnButton;
        private System.Windows.Forms.Button reserveDeleteButton;
        private System.Windows.Forms.Button reserveUpdateButton;
        private System.Windows.Forms.Button backButton;
    }
}