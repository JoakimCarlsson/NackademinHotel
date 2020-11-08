using System.ComponentModel;

namespace NackademinHotel
{
    partial class BookingEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.payedCheckBox = new System.Windows.Forms.CheckBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.extraBedsComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.cancelBooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Datum";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slut Datum";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rums nummer";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Extra sängar";
            // 
            // payedCheckBox
            // 
            this.payedCheckBox.Location = new System.Drawing.Point(12, 132);
            this.payedCheckBox.Name = "payedCheckBox";
            this.payedCheckBox.Size = new System.Drawing.Size(76, 18);
            this.payedCheckBox.TabIndex = 4;
            this.payedCheckBox.Text = "Betald";
            this.payedCheckBox.UseVisualStyleBackColor = true;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(94, 8);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(109, 20);
            this.startDatePicker.TabIndex = 5;
            // 
            // endTimePicker
            // 
            this.endTimePicker.Location = new System.Drawing.Point(94, 38);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(109, 20);
            this.endTimePicker.TabIndex = 6;
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.Location = new System.Drawing.Point(95, 72);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(108, 20);
            this.roomNumberTextBox.TabIndex = 7;
            // 
            // extraBedsComboBox
            // 
            this.extraBedsComboBox.FormattingEnabled = true;
            this.extraBedsComboBox.Location = new System.Drawing.Point(94, 104);
            this.extraBedsComboBox.Name = "extraBedsComboBox";
            this.extraBedsComboBox.Size = new System.Drawing.Size(109, 21);
            this.extraBedsComboBox.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(94, 156);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(109, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Spara";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(260, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Förnamn";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(260, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Efternamn";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(260, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Födelsedatum";
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Location = new System.Drawing.Point(345, 69);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(109, 20);
            this.dateOfBirthPicker.TabIndex = 13;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(346, 8);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(108, 20);
            this.firstNameTextBox.TabIndex = 14;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(346, 38);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(108, 20);
            this.lastNameTextBox.TabIndex = 15;
            // 
            // cancelBooking
            // 
            this.cancelBooking.Location = new System.Drawing.Point(346, 156);
            this.cancelBooking.Name = "cancelBooking";
            this.cancelBooking.Size = new System.Drawing.Size(109, 23);
            this.cancelBooking.TabIndex = 16;
            this.cancelBooking.Text = "Avboka";
            this.cancelBooking.UseVisualStyleBackColor = true;
            this.cancelBooking.Click += new System.EventHandler(this.cancelBooking_Click);
            // 
            // BookingEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 198);
            this.Controls.Add(this.cancelBooking);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.extraBedsComboBox);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.payedCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookingEditForm";
            this.Text = "BookingEditForm";
            this.Load += new System.EventHandler(this.BookingEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button cancelBooking;

        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lastNameTextBox;

        private System.Windows.Forms.CheckBox payedCheckBox;

        private System.Windows.Forms.ComboBox extraBedsComboBox;
        private System.Windows.Forms.TextBox roomNumberTextBox;

        private System.Windows.Forms.Button saveButton;

        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}