namespace RecitationRapportering
{
    partial class RecitationReport
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
            this.idText = new System.Windows.Forms.TextBox();
            this.courseBox = new System.Windows.Forms.ListBox();
            this.recitationBox = new System.Windows.Forms.ListBox();
            this.groupBox = new System.Windows.Forms.ListBox();
            this.problemBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(41, 66);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(167, 31);
            this.idText.TabIndex = 0;
            this.idText.Text = "Insert student ID";
            this.idText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Submit);
            // 
            // courseBox
            // 
            this.courseBox.FormattingEnabled = true;
            this.courseBox.ItemHeight = 25;
            this.courseBox.Location = new System.Drawing.Point(41, 146);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(167, 129);
            this.courseBox.TabIndex = 2;
            // 
            // recitationBox
            // 
            this.recitationBox.FormattingEnabled = true;
            this.recitationBox.ItemHeight = 25;
            this.recitationBox.Location = new System.Drawing.Point(41, 320);
            this.recitationBox.Name = "recitationBox";
            this.recitationBox.Size = new System.Drawing.Size(167, 129);
            this.recitationBox.TabIndex = 3;
            // 
            // groupBox
            // 
            this.groupBox.FormattingEnabled = true;
            this.groupBox.ItemHeight = 25;
            this.groupBox.Location = new System.Drawing.Point(41, 488);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(167, 129);
            this.groupBox.TabIndex = 4;
            // 
            // problemBox
            // 
            this.problemBox.FormattingEnabled = true;
            this.problemBox.Location = new System.Drawing.Point(283, 66);
            this.problemBox.Name = "problemBox";
            this.problemBox.Size = new System.Drawing.Size(354, 550);
            this.problemBox.TabIndex = 5;
            // 
            // RecitationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 679);
            this.Controls.Add(this.problemBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.recitationBox);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.idText);
            this.Name = "RecitationReport";
            this.Text = "Recitation report system";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.ListBox courseBox;
        private System.Windows.Forms.ListBox recitationBox;
        private System.Windows.Forms.ListBox groupBox;
        private System.Windows.Forms.CheckedListBox problemBox;
    }
}

