namespace craps
{
    partial class GameView
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
            this.resultLbl = new System.Windows.Forms.Label();
            this.pointLbl = new System.Windows.Forms.Label();
            this.rollSumLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(12, 9);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(40, 13);
            this.resultLbl.TabIndex = 0;
            this.resultLbl.Text = "Result:";
            // 
            // pointLbl
            // 
            this.pointLbl.AutoSize = true;
            this.pointLbl.Location = new System.Drawing.Point(13, 36);
            this.pointLbl.Name = "pointLbl";
            this.pointLbl.Size = new System.Drawing.Size(39, 13);
            this.pointLbl.TabIndex = 1;
            this.pointLbl.Text = "Points:";
            // 
            // rollSumLbl
            // 
            this.rollSumLbl.AutoSize = true;
            this.rollSumLbl.Location = new System.Drawing.Point(12, 64);
            this.rollSumLbl.Name = "rollSumLbl";
            this.rollSumLbl.Size = new System.Drawing.Size(49, 13);
            this.rollSumLbl.TabIndex = 2;
            this.rollSumLbl.Text = "RollSum:";
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 141);
            this.Controls.Add(this.rollSumLbl);
            this.Controls.Add(this.pointLbl);
            this.Controls.Add(this.resultLbl);
            this.Name = "GameView";
            this.Text = "GameView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label pointLbl;
        private System.Windows.Forms.Label rollSumLbl;
    }
}