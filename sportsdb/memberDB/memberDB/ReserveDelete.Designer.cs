
namespace memberDB
{
    partial class ReserveDelete
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
            this.backButton = new System.Windows.Forms.Button();
            this.reserveDliteButton = new System.Windows.Forms.Button();
            this.reserveIdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(212, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "削除したい予約氏名を選択してください";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(80, 350);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 48);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // reserveDliteButton
            // 
            this.reserveDliteButton.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reserveDliteButton.Location = new System.Drawing.Point(610, 350);
            this.reserveDliteButton.Name = "reserveDliteButton";
            this.reserveDliteButton.Size = new System.Drawing.Size(127, 48);
            this.reserveDliteButton.TabIndex = 4;
            this.reserveDliteButton.Text = "削除";
            this.reserveDliteButton.UseVisualStyleBackColor = true;
            this.reserveDliteButton.Click += new System.EventHandler(this.reserveDliteButtonClick);
            // 
            // reserveIdBox
            // 
            this.reserveIdBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reserveIdBox.Location = new System.Drawing.Point(293, 120);
            this.reserveIdBox.Name = "reserveIdBox";
            this.reserveIdBox.Size = new System.Drawing.Size(300, 27);
            this.reserveIdBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(162, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "予約氏名";
            // 
            // ReserveDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reserveIdBox);
            this.Controls.Add(this.reserveDliteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ReserveDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "予約削除";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button reserveDliteButton;
        private System.Windows.Forms.TextBox reserveIdBox;
        private System.Windows.Forms.Label label2;
    }
}