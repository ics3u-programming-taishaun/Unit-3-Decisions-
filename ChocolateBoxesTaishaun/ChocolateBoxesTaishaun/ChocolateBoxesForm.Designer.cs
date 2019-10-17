namespace ChocolateBoxesTaishaun
{
    partial class FrmChocolateBoxes
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
            this.lblNumBoxesSold = new System.Windows.Forms.Label();
            this.lblUserReward = new System.Windows.Forms.Label();
            this.txtNumBoxes = new System.Windows.Forms.TextBox();
            this.btnGetReward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumBoxesSold
            // 
            this.lblNumBoxesSold.AutoSize = true;
            this.lblNumBoxesSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBoxesSold.Location = new System.Drawing.Point(46, 50);
            this.lblNumBoxesSold.Name = "lblNumBoxesSold";
            this.lblNumBoxesSold.Size = new System.Drawing.Size(332, 26);
            this.lblNumBoxesSold.TabIndex = 0;
            this.lblNumBoxesSold.Text = "Enter the number of boxes sold : ";
            // 
            // lblUserReward
            // 
            this.lblUserReward.AutoSize = true;
            this.lblUserReward.Location = new System.Drawing.Point(108, 202);
            this.lblUserReward.Name = "lblUserReward";
            this.lblUserReward.Size = new System.Drawing.Size(35, 13);
            this.lblUserReward.TabIndex = 1;
            this.lblUserReward.Text = "label2";
            // 
            // txtNumBoxes
            // 
            this.txtNumBoxes.Location = new System.Drawing.Point(441, 56);
            this.txtNumBoxes.Name = "txtNumBoxes";
            this.txtNumBoxes.Size = new System.Drawing.Size(100, 20);
            this.txtNumBoxes.TabIndex = 2;
            // 
            // btnGetReward
            // 
            this.btnGetReward.Location = new System.Drawing.Point(452, 192);
            this.btnGetReward.Name = "btnGetReward";
            this.btnGetReward.Size = new System.Drawing.Size(75, 23);
            this.btnGetReward.TabIndex = 3;
            this.btnGetReward.Text = "Get Reward ";
            this.btnGetReward.UseVisualStyleBackColor = true;
            this.btnGetReward.Click += new System.EventHandler(this.BtnGetReward_Click);
            // 
            // FrmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetReward);
            this.Controls.Add(this.txtNumBoxes);
            this.Controls.Add(this.lblUserReward);
            this.Controls.Add(this.lblNumBoxesSold);
            this.Name = "FrmChocolateBoxes";
            this.Text = "Chocolate boxes by Taishaun Johnson";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumBoxesSold;
        private System.Windows.Forms.Label lblUserReward;
        private System.Windows.Forms.TextBox txtNumBoxes;
        private System.Windows.Forms.Button btnGetReward;
    }
}

