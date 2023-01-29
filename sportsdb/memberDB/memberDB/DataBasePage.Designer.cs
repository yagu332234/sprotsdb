
namespace memberDB
{
    partial class DataBasePage
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
            this.memberDB = new System.Windows.Forms.Button();
            this.memberDBDelete = new System.Windows.Forms.Button();
            this.reserveDB = new System.Windows.Forms.Button();
            this.reserveDBDelete = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // memberDB
            // 
            this.memberDB.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memberDB.Location = new System.Drawing.Point(190, 137);
            this.memberDB.Name = "memberDB";
            this.memberDB.Size = new System.Drawing.Size(197, 64);
            this.memberDB.TabIndex = 0;
            this.memberDB.Text = "会員データベース作成";
            this.memberDB.UseVisualStyleBackColor = true;
            this.memberDB.Click += new System.EventHandler(this.memberDBClick);
            // 
            // memberDBDelete
            // 
            this.memberDBDelete.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memberDBDelete.Location = new System.Drawing.Point(190, 235);
            this.memberDBDelete.Name = "memberDBDelete";
            this.memberDBDelete.Size = new System.Drawing.Size(197, 64);
            this.memberDBDelete.TabIndex = 1;
            this.memberDBDelete.Text = "会員データベース削除";
            this.memberDBDelete.UseVisualStyleBackColor = true;
            this.memberDBDelete.Click += new System.EventHandler(this.memberDBDeleteClick);
            // 
            // reserveDB
            // 
            this.reserveDB.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reserveDB.Location = new System.Drawing.Point(416, 137);
            this.reserveDB.Name = "reserveDB";
            this.reserveDB.Size = new System.Drawing.Size(197, 64);
            this.reserveDB.TabIndex = 2;
            this.reserveDB.Text = "予約データベース作成";
            this.reserveDB.UseVisualStyleBackColor = true;
            this.reserveDB.Click += new System.EventHandler(this.reserveDBClick);
            // 
            // reserveDBDelete
            // 
            this.reserveDBDelete.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reserveDBDelete.Location = new System.Drawing.Point(416, 235);
            this.reserveDBDelete.Name = "reserveDBDelete";
            this.reserveDBDelete.Size = new System.Drawing.Size(197, 64);
            this.reserveDBDelete.TabIndex = 3;
            this.reserveDBDelete.Text = "予約データベース削除";
            this.reserveDBDelete.UseVisualStyleBackColor = true;
            this.reserveDBDelete.Click += new System.EventHandler(this.reserveDBDeleteClick);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(72, 362);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(131, 64);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(286, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "データベース作成";
            // 
            // DataBasePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.reserveDBDelete);
            this.Controls.Add(this.reserveDB);
            this.Controls.Add(this.memberDBDelete);
            this.Controls.Add(this.memberDB);
            this.Name = "DataBasePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataBasePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button memberDB;
        private System.Windows.Forms.Button memberDBDelete;
        private System.Windows.Forms.Button reserveDB;
        private System.Windows.Forms.Button reserveDBDelete;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
    }
}