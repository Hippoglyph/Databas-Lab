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
            this.selectionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.StudentIdLabel = new System.Windows.Forms.Label();
            this.CorseLabel = new System.Windows.Forms.Label();
            this.RecitationLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.problemBox = new System.Windows.Forms.FlowLayoutPanel();
            this.locationLabel = new System.Windows.Forms.Label();
            this.selectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(10, 27);
            this.idText.Margin = new System.Windows.Forms.Padding(10);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(111, 22);
            this.idText.TabIndex = 0;
            this.idText.TextChanged += new System.EventHandler(this.Submit);
            // 
            // courseBox
            // 
            this.courseBox.FormattingEnabled = true;
            this.courseBox.ItemHeight = 16;
            this.courseBox.Location = new System.Drawing.Point(8, 84);
            this.courseBox.Margin = new System.Windows.Forms.Padding(8);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(113, 84);
            this.courseBox.TabIndex = 2;
            this.courseBox.SelectedIndexChanged += new System.EventHandler(this.courseBox_SelectedIndexChanged);
            // 
            // recitationBox
            // 
            this.recitationBox.FormattingEnabled = true;
            this.recitationBox.ItemHeight = 16;
            this.recitationBox.Location = new System.Drawing.Point(8, 201);
            this.recitationBox.Margin = new System.Windows.Forms.Padding(8);
            this.recitationBox.Name = "recitationBox";
            this.recitationBox.Size = new System.Drawing.Size(113, 84);
            this.recitationBox.TabIndex = 3;
            this.recitationBox.SelectedIndexChanged += new System.EventHandler(this.recitationBox_SelectedIndexChanged);
            // 
            // groupBox
            // 
            this.groupBox.FormattingEnabled = true;
            this.groupBox.ItemHeight = 16;
            this.groupBox.Location = new System.Drawing.Point(8, 318);
            this.groupBox.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(113, 84);
            this.groupBox.TabIndex = 4;
            this.groupBox.SelectedIndexChanged += new System.EventHandler(this.groupBox_SelectedIndexChanged);
            // 
            // selectionPanel
            // 
            this.selectionPanel.AutoScroll = true;
            this.selectionPanel.Controls.Add(this.StudentIdLabel);
            this.selectionPanel.Controls.Add(this.idText);
            this.selectionPanel.Controls.Add(this.CorseLabel);
            this.selectionPanel.Controls.Add(this.courseBox);
            this.selectionPanel.Controls.Add(this.RecitationLabel);
            this.selectionPanel.Controls.Add(this.recitationBox);
            this.selectionPanel.Controls.Add(this.GroupLabel);
            this.selectionPanel.Controls.Add(this.groupBox);
            this.selectionPanel.Location = new System.Drawing.Point(12, 12);
            this.selectionPanel.Name = "selectionPanel";
            this.selectionPanel.Size = new System.Drawing.Size(160, 411);
            this.selectionPanel.TabIndex = 6;
            // 
            // StudentIdLabel
            // 
            this.StudentIdLabel.AutoSize = true;
            this.StudentIdLabel.Location = new System.Drawing.Point(3, 0);
            this.StudentIdLabel.Name = "StudentIdLabel";
            this.StudentIdLabel.Size = new System.Drawing.Size(74, 17);
            this.StudentIdLabel.TabIndex = 5;
            this.StudentIdLabel.Text = "Student ID";
            // 
            // CorseLabel
            // 
            this.CorseLabel.AutoSize = true;
            this.CorseLabel.Location = new System.Drawing.Point(3, 59);
            this.CorseLabel.Name = "CorseLabel";
            this.CorseLabel.Size = new System.Drawing.Size(53, 17);
            this.CorseLabel.TabIndex = 6;
            this.CorseLabel.Text = "Course";
            // 
            // RecitationLabel
            // 
            this.RecitationLabel.AutoSize = true;
            this.RecitationLabel.Location = new System.Drawing.Point(3, 176);
            this.RecitationLabel.Name = "RecitationLabel";
            this.RecitationLabel.Size = new System.Drawing.Size(71, 17);
            this.RecitationLabel.TabIndex = 7;
            this.RecitationLabel.Text = "Recitation";
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(3, 293);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(48, 17);
            this.GroupLabel.TabIndex = 8;
            this.GroupLabel.Text = "Group";
            // 
            // problemBox
            // 
            this.problemBox.AutoScroll = true;
            this.problemBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.problemBox.Location = new System.Drawing.Point(179, 33);
            this.problemBox.Name = "problemBox";
            this.problemBox.Size = new System.Drawing.Size(517, 390);
            this.problemBox.TabIndex = 7;
            this.problemBox.WrapContents = false;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(179, 13);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(62, 17);
            this.locationLabel.TabIndex = 8;
            this.locationLabel.Text = "Location";
            // 
            // RecitationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 451);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.problemBox);
            this.Controls.Add(this.selectionPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RecitationReport";
            this.Text = "Recitation report system";
            this.selectionPanel.ResumeLayout(false);
            this.selectionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.ListBox courseBox;
        private System.Windows.Forms.ListBox recitationBox;
        private System.Windows.Forms.ListBox groupBox;
        private System.Windows.Forms.FlowLayoutPanel selectionPanel;
        private System.Windows.Forms.Label StudentIdLabel;
        private System.Windows.Forms.Label CorseLabel;
        private System.Windows.Forms.Label RecitationLabel;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.FlowLayoutPanel problemBox;
        private System.Windows.Forms.Label locationLabel;
    }
}

