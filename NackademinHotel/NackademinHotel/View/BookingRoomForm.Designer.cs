using System.ComponentModel;

namespace NackademinHotel
{
    partial class BookingRoomForm
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
            this.roomsNumberTextBox = new System.Windows.Forms.TextBox();
            this.roomSizeTextBox = new System.Windows.Forms.TextBox();
            this.doubleRoomTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveBooking = new System.Windows.Forms.Button();
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.editCustomerButton = new System.Windows.Forms.Button();
            this.extraBedsComboBox = new System.Windows.Forms.ComboBox();
            this.payedCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rumsnummer:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rum Storlek";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dubbel Rum";
            // 
            // roomsNumberTextBox
            // 
            this.roomsNumberTextBox.Location = new System.Drawing.Point(98, 6);
            this.roomsNumberTextBox.Name = "roomsNumberTextBox";
            this.roomsNumberTextBox.Size = new System.Drawing.Size(88, 20);
            this.roomsNumberTextBox.TabIndex = 3;
            // 
            // roomSizeTextBox
            // 
            this.roomSizeTextBox.Location = new System.Drawing.Point(98, 45);
            this.roomSizeTextBox.Name = "roomSizeTextBox";
            this.roomSizeTextBox.Size = new System.Drawing.Size(88, 20);
            this.roomSizeTextBox.TabIndex = 4;
            // 
            // doubleRoomTextBox
            // 
            this.doubleRoomTextBox.Location = new System.Drawing.Point(98, 83);
            this.doubleRoomTextBox.Name = "doubleRoomTextBox";
            this.doubleRoomTextBox.Size = new System.Drawing.Size(88, 20);
            this.doubleRoomTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Extra sängar";
            // 
            // saveBooking
            // 
            this.saveBooking.Location = new System.Drawing.Point(12, 192);
            this.saveBooking.Name = "saveBooking";
            this.saveBooking.Size = new System.Drawing.Size(97, 20);
            this.saveBooking.TabIndex = 9;
            this.saveBooking.Text = "Boka";
            this.saveBooking.UseVisualStyleBackColor = true;
            this.saveBooking.Click += new System.EventHandler(this.saveBooking_Click);
            // 
            // customerListBox
            // 
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.Location = new System.Drawing.Point(217, 6);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(218, 173);
            this.customerListBox.TabIndex = 10;
            // 
            // editCustomerButton
            // 
            this.editCustomerButton.Location = new System.Drawing.Point(217, 192);
            this.editCustomerButton.Name = "editCustomerButton";
            this.editCustomerButton.Size = new System.Drawing.Size(91, 20);
            this.editCustomerButton.TabIndex = 11;
            this.editCustomerButton.Text = "Hantera Kunder";
            this.editCustomerButton.UseVisualStyleBackColor = true;
            this.editCustomerButton.Click += new System.EventHandler(this.editCustomerButton_Click);
            // 
            // extraBedsComboBox
            // 
            this.extraBedsComboBox.FormattingEnabled = true;
            this.extraBedsComboBox.Location = new System.Drawing.Point(99, 122);
            this.extraBedsComboBox.Name = "extraBedsComboBox";
            this.extraBedsComboBox.Size = new System.Drawing.Size(86, 21);
            this.extraBedsComboBox.TabIndex = 12;
            // 
            // payedCheckBox
            // 
            this.payedCheckBox.Location = new System.Drawing.Point(14, 157);
            this.payedCheckBox.Name = "payedCheckBox";
            this.payedCheckBox.Size = new System.Drawing.Size(95, 22);
            this.payedCheckBox.TabIndex = 14;
            this.payedCheckBox.Text = "Betala";
            this.payedCheckBox.UseVisualStyleBackColor = true;
            // 
            // BookingRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 247);
            this.Controls.Add(this.payedCheckBox);
            this.Controls.Add(this.extraBedsComboBox);
            this.Controls.Add(this.editCustomerButton);
            this.Controls.Add(this.customerListBox);
            this.Controls.Add(this.saveBooking);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doubleRoomTextBox);
            this.Controls.Add(this.roomSizeTextBox);
            this.Controls.Add(this.roomsNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookingRoomForm";
            this.Text = "BookingRoomForm";
            this.Load += new System.EventHandler(this.BookingRoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox payedCheckBox;

        private System.Windows.Forms.ComboBox extraBedsComboBox;

        private System.Windows.Forms.Button editCustomerButton;

        private System.Windows.Forms.ListBox customerListBox;

        private System.Windows.Forms.Button saveBooking;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox doubleRoomTextBox;
        private System.Windows.Forms.TextBox roomSizeTextBox;
        private System.Windows.Forms.TextBox roomsNumberTextBox;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}