namespace CribbageHand
{
    partial class StatsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMean = new System.Windows.Forms.Label();
            this.lboPoints = new System.Windows.Forms.ListBox();
            this.lblHand = new System.Windows.Forms.Label();
            this.lblCrib = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(12, 72);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(37, 17);
            this.lblMax.TabIndex = 1;
            this.lblMax.Text = "Max:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(15, 93);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(34, 17);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Min:";
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(2, 50);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(47, 17);
            this.lblMean.TabIndex = 5;
            this.lblMean.Text = "Mean:";
            // 
            // lboPoints
            // 
            this.lboPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboPoints.FormattingEnabled = true;
            this.lboPoints.ItemHeight = 16;
            this.lboPoints.Location = new System.Drawing.Point(3, 119);
            this.lboPoints.Name = "lboPoints";
            this.lboPoints.Size = new System.Drawing.Size(188, 324);
            this.lboPoints.TabIndex = 6;
            // 
            // lblHand
            // 
            this.lblHand.AutoSize = true;
            this.lblHand.Location = new System.Drawing.Point(3, 9);
            this.lblHand.Name = "lblHand";
            this.lblHand.Size = new System.Drawing.Size(46, 17);
            this.lblHand.TabIndex = 7;
            this.lblHand.Text = "Hand:";
            // 
            // lblCrib
            // 
            this.lblCrib.AutoSize = true;
            this.lblCrib.Location = new System.Drawing.Point(12, 29);
            this.lblCrib.Name = "lblCrib";
            this.lblCrib.Size = new System.Drawing.Size(37, 17);
            this.lblCrib.TabIndex = 8;
            this.lblCrib.Text = "Crib:";
            // 
            // StatsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCrib);
            this.Controls.Add(this.lblHand);
            this.Controls.Add(this.lboPoints);
            this.Controls.Add(this.lblMean);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Name = "StatsControl";
            this.Size = new System.Drawing.Size(195, 449);
            this.Load += new System.EventHandler(this.StatsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.ListBox lboPoints;
        private System.Windows.Forms.Label lblHand;
        private System.Windows.Forms.Label lblCrib;
    }
}
