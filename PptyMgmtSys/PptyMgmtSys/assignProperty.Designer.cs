namespace PptyMgmtSys {
    partial class assignProperty {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.StaffIDbox = new System.Windows.Forms.ComboBox();
            this.IDbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.StaffNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuburbLabel = new System.Windows.Forms.Label();
            this.StreetNameLabel = new System.Windows.Forms.Label();
            this.updateAssignment = new System.Windows.Forms.Button();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.HoursBox = new System.Windows.Forms.TextBox();
            this.cancelAssignmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StaffIDbox
            // 
            this.StaffIDbox.FormattingEnabled = true;
            this.StaffIDbox.Location = new System.Drawing.Point(128, 33);
            this.StaffIDbox.Name = "StaffIDbox";
            this.StaffIDbox.Size = new System.Drawing.Size(64, 21);
            this.StaffIDbox.TabIndex = 0;
            this.StaffIDbox.SelectedIndexChanged += new System.EventHandler(this.staffBox_SelectedIndexChanged);
            // 
            // IDbox
            // 
            this.IDbox.FormattingEnabled = true;
            this.IDbox.Location = new System.Drawing.Point(348, 36);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(62, 21);
            this.IDbox.TabIndex = 1;
            this.IDbox.SelectedIndexChanged += new System.EventHandler(this.IDbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff ID #:";
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(29, 85);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(42, 13);
            this.DOBLabel.TabIndex = 3;
            this.DOBLabel.Text = "D.O.B.:";
            // 
            // StaffNameLabel
            // 
            this.StaffNameLabel.AutoSize = true;
            this.StaffNameLabel.Location = new System.Drawing.Point(29, 63);
            this.StaffNameLabel.Name = "StaffNameLabel";
            this.StaffNameLabel.Size = new System.Drawing.Size(63, 13);
            this.StaffNameLabel.TabIndex = 4;
            this.StaffNameLabel.Text = "Staff Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Property ID #:";
            // 
            // SuburbLabel
            // 
            this.SuburbLabel.AutoSize = true;
            this.SuburbLabel.Location = new System.Drawing.Point(223, 63);
            this.SuburbLabel.Name = "SuburbLabel";
            this.SuburbLabel.Size = new System.Drawing.Size(44, 13);
            this.SuburbLabel.TabIndex = 6;
            this.SuburbLabel.Text = "Suburb:";
            // 
            // StreetNameLabel
            // 
            this.StreetNameLabel.AutoSize = true;
            this.StreetNameLabel.Location = new System.Drawing.Point(223, 85);
            this.StreetNameLabel.Name = "StreetNameLabel";
            this.StreetNameLabel.Size = new System.Drawing.Size(69, 13);
            this.StreetNameLabel.TabIndex = 7;
            this.StreetNameLabel.Text = "Street Name:";
            // 
            // updateAssignment
            // 
            this.updateAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAssignment.Location = new System.Drawing.Point(226, 158);
            this.updateAssignment.Name = "updateAssignment";
            this.updateAssignment.Size = new System.Drawing.Size(184, 41);
            this.updateAssignment.TabIndex = 8;
            this.updateAssignment.Text = "Assign Property";
            this.updateAssignment.UseVisualStyleBackColor = true;
            this.updateAssignment.Click += new System.EventHandler(this.button1_Click);
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLabel.Location = new System.Drawing.Point(28, 116);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(132, 20);
            this.HoursLabel.TabIndex = 9;
            this.HoursLabel.Text = "Working Hours:";
            // 
            // HoursBox
            // 
            this.HoursBox.Location = new System.Drawing.Point(164, 118);
            this.HoursBox.Name = "HoursBox";
            this.HoursBox.Size = new System.Drawing.Size(154, 20);
            this.HoursBox.TabIndex = 10;
            // 
            // cancelAssignmentButton
            // 
            this.cancelAssignmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAssignmentButton.Location = new System.Drawing.Point(32, 158);
            this.cancelAssignmentButton.Name = "cancelAssignmentButton";
            this.cancelAssignmentButton.Size = new System.Drawing.Size(184, 41);
            this.cancelAssignmentButton.TabIndex = 11;
            this.cancelAssignmentButton.Text = "Cancel Assignment";
            this.cancelAssignmentButton.UseVisualStyleBackColor = true;
            this.cancelAssignmentButton.Click += new System.EventHandler(this.cancelAssignmentButton_Click);
            // 
            // assignProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 220);
            this.Controls.Add(this.cancelAssignmentButton);
            this.Controls.Add(this.HoursBox);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.updateAssignment);
            this.Controls.Add(this.StreetNameLabel);
            this.Controls.Add(this.SuburbLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StaffNameLabel);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.StaffIDbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "assignProperty";
            this.Text = "Assign Property to Staff";
            this.Load += new System.EventHandler(this.assignProperty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StaffIDbox;
        private System.Windows.Forms.ComboBox IDbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.Label StaffNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SuburbLabel;
        private System.Windows.Forms.Label StreetNameLabel;
        private System.Windows.Forms.Button updateAssignment;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.TextBox HoursBox;
        private System.Windows.Forms.Button cancelAssignmentButton;
    }
}