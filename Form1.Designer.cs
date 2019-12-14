namespace CribbageHand
{
    partial class Form1
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
            this.txtHandSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToCrib = new System.Windows.Forms.NumericUpDown();
            this.gbHand = new System.Windows.Forms.GroupBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.cmdRandomHand = new System.Windows.Forms.Button();
            this.pnlStats = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtHandSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToCrib)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHandSize
            // 
            this.txtHandSize.Location = new System.Drawing.Point(77, 13);
            this.txtHandSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtHandSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtHandSize.Name = "txtHandSize";
            this.txtHandSize.Size = new System.Drawing.Size(52, 22);
            this.txtHandSize.TabIndex = 0;
            this.txtHandSize.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.txtHandSize.ValueChanged += new System.EventHandler(this.txtHandSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Crib:";
            // 
            // txtToCrib
            // 
            this.txtToCrib.Location = new System.Drawing.Point(77, 39);
            this.txtToCrib.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtToCrib.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtToCrib.Name = "txtToCrib";
            this.txtToCrib.Size = new System.Drawing.Size(52, 22);
            this.txtToCrib.TabIndex = 2;
            this.txtToCrib.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // gbHand
            // 
            this.gbHand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbHand.Location = new System.Drawing.Point(14, 73);
            this.gbHand.Name = "gbHand";
            this.gbHand.Size = new System.Drawing.Size(125, 362);
            this.gbHand.TabIndex = 4;
            this.gbHand.TabStop = false;
            this.gbHand.Text = "Hand";
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdCalculate.Location = new System.Drawing.Point(57, 441);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(82, 23);
            this.cmdCalculate.TabIndex = 5;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // cmdRandomHand
            // 
            this.cmdRandomHand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdRandomHand.Location = new System.Drawing.Point(23, 496);
            this.cmdRandomHand.Name = "cmdRandomHand";
            this.cmdRandomHand.Size = new System.Drawing.Size(116, 23);
            this.cmdRandomHand.TabIndex = 6;
            this.cmdRandomHand.Text = "Random Hand";
            this.cmdRandomHand.UseVisualStyleBackColor = true;
            this.cmdRandomHand.Click += new System.EventHandler(this.cmdRandomHand_Click);
            // 
            // pnlStats
            // 
            this.pnlStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStats.AutoScroll = true;
            this.pnlStats.Location = new System.Drawing.Point(145, 13);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(865, 516);
            this.pnlStats.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 541);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.cmdRandomHand);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.gbHand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtToCrib);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHandSize);
            this.Name = "Form1";
            this.Text = "Cribbage Hand";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtHandSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToCrib)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtHandSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtToCrib;
        private System.Windows.Forms.GroupBox gbHand;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Button cmdRandomHand;
        private System.Windows.Forms.Panel pnlStats;
    }
}

