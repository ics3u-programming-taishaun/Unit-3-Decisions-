namespace PerfectSquaresWhileTaishaun
{
    partial class FrmPerfectSquares
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
            this.nudEndValue = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstPerfectSquares = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndValue)).BeginInit();
            this.SuspendLayout();
            // 
            // nudEndValue
            // 
            this.nudEndValue.Location = new System.Drawing.Point(329, 144);
            this.nudEndValue.Name = "nudEndValue";
            this.nudEndValue.Size = new System.Drawing.Size(120, 20);
            this.nudEndValue.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(329, 48);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 41);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lstPerfectSquares
            // 
            this.lstPerfectSquares.FormattingEnabled = true;
            this.lstPerfectSquares.Location = new System.Drawing.Point(306, 213);
            this.lstPerfectSquares.Name = "lstPerfectSquares";
            this.lstPerfectSquares.Size = new System.Drawing.Size(143, 108);
            this.lstPerfectSquares.TabIndex = 2;
            this.lstPerfectSquares.SelectedIndexChanged += new System.EventHandler(this.LstPerfectSquares_SelectedIndexChanged);
            // 
            // FrmPerfectSquares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPerfectSquares);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nudEndValue);
            this.Name = "FrmPerfectSquares";
            this.Text = "Perfect Squares by Taishaun";
            ((System.ComponentModel.ISupportInitialize)(this.nudEndValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudEndValue;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstPerfectSquares;
    }
}

