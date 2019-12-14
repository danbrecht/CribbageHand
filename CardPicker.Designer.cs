namespace CribbageHand
{
    partial class CardPicker
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
            this.cboValue = new System.Windows.Forms.ComboBox();
            this.cboSuit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboValue
            // 
            this.cboValue.FormattingEnabled = true;
            this.cboValue.Items.AddRange(new object[] {
            "A",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K"});
            this.cboValue.Location = new System.Drawing.Point(0, 0);
            this.cboValue.Name = "cboValue";
            this.cboValue.Size = new System.Drawing.Size(50, 24);
            this.cboValue.TabIndex = 1;
            this.cboValue.SelectedIndexChanged += new System.EventHandler(this.cboValue_SelectedIndexChanged);
            // 
            // cboSuit
            // 
            this.cboSuit.FormattingEnabled = true;
            this.cboSuit.Items.AddRange(new object[] {
            "H",
            "S",
            "C",
            "D"});
            this.cboSuit.Location = new System.Drawing.Point(56, 0);
            this.cboSuit.Name = "cboSuit";
            this.cboSuit.Size = new System.Drawing.Size(50, 24);
            this.cboSuit.TabIndex = 2;
            // 
            // CardPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboSuit);
            this.Controls.Add(this.cboValue);
            this.Name = "CardPicker";
            this.Size = new System.Drawing.Size(108, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboValue;
        private System.Windows.Forms.ComboBox cboSuit;
    }
}
