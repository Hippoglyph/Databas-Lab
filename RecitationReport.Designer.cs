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
            this.idText.Location = new System.Drawing.Point(27, 42);
            this.idText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(113, 22);
            this.idText.TabIndex = 0;
            this.idText.Text = "Insert student ID";
            this.idText.TextChanged += new System.EventHandler(this.Submit);
            // 
            // courseBox
            // 
            this.courseBox.FormattingEnabled = true;
            this.courseBox.ItemHeight = 16;
            this.courseBox.Location = new System.Drawing.Point(27, 93);
            this.courseBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(113, 84);
            this.courseBox.TabIndex = 2;
            this.courseBox.SelectedIndexChanged += new System.EventHandler(this.courseBox_SelectedIndexChanged);
            // 
            // recitationBox
            // 
            this.recitationBox.FormattingEnabled = true;
            this.recitationBox.ItemHeight = 16;
            this.recitationBox.Location = new System.Drawing.Point(27, 205);
            this.recitationBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recitationBox.Name = "recitationBox";
            this.recitationBox.Size = new System.Drawing.Size(113, 84);
            this.recitationBox.TabIndex = 3;
            this.recitationBox.SelectedIndexChanged += new System.EventHandler(this.recitationBox_SelectedIndexChanged);
            // 
            // groupBox
            // 
            this.groupBox.FormattingEnabled = true;
            this.groupBox.ItemHeight = 16;
            this.groupBox.Location = new System.Drawing.Point(27, 312);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(113, 84);
            this.groupBox.TabIndex = 4;
            // 
            // problemBox
            // 
            this.problemBox.FormattingEnabled = true;
            this.problemBox.Location = new System.Drawing.Point(189, 42);
            this.problemBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.problemBox.Name = "problemBox";
            this.problemBox.Size = new System.Drawing.Size(237, 344);
            this.problemBox.TabIndex = 5;
            // 
            // RecitationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 435);
            this.Controls.Add(this.problemBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.recitationBox);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.idText);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

