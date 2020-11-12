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
            this.payedCheckBox = new System.Windows.Forms.CheckBox();
            this.extraBedsNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.extraBedsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rumsnummer:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rum Storlek";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dubbel Rum";
            // 
            // roomsNumberTextBox
            // 
            this.roomsNumberTextBox.Location = new System.Drawing.Point(114, 7);
            this.roomsNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roomsNumberTextBox.Name = "roomsNumberTextBox";
            this.roomsNumberTextBox.Size = new System.Drawing.Size(102, 23);
            this.roomsNumberTextBox.TabIndex = 3;
            // 
            // roomSizeTextBox
            // 
            this.roomSizeTextBox.Location = new System.Drawing.Point(114, 52);
            this.roomSizeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roomSizeTextBox.Name = "roomSizeTextBox";
            this.roomSizeTextBox.Size = new System.Drawing.Size(102, 23);
            this.roomSizeTextBox.TabIndex = 4;
            // 
            // doubleRoomTextBox
            // 
            this.doubleRoomTextBox.Location = new System.Drawing.Point(114, 96);
            this.doubleRoomTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.doubleRoomTextBox.Name = "doubleRoomTextBox";
            this.doubleRoomTextBox.Size = new System.Drawing.Size(102, 23);
            this.doubleRoomTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Extra sängar";
            // 
            // saveBooking
            // 
            this.saveBooking.Location = new System.Drawing.Point(14, 222);
            this.saveBooking.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveBooking.Name = "saveBooking";
            this.saveBooking.Size = new System.Drawing.Size(113, 23);
            this.saveBooking.TabIndex = 9;
            this.saveBooking.Text = "Boka";
            this.saveBooking.UseVisualStyleBackColor = true;
            this.saveBooking.Click += new System.EventHandler(this.saveBooking_Click);
            // 
            // customerListBox
            // 
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.ItemHeight = 15;
            this.customerListBox.Location = new System.Drawing.Point(253, 7);
            this.customerListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(254, 199);
            this.customerListBox.TabIndex = 10;
            // 
            // editCustomerButton
            // 
            this.editCustomerButton.Location = new System.Drawing.Point(253, 222);
            this.editCustomerButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editCustomerButton.Name = "editCustomerButton";
            this.editCustomerButton.Size = new System.Drawing.Size(106, 23);
            this.editCustomerButton.TabIndex = 11;
            this.editCustomerButton.Text = "Hantera Kunder";
            this.editCustomerButton.UseVisualStyleBackColor = true;
            this.editCustomerButton.Click += new System.EventHandler(this.editCustomerButton_Click);
            // 
            // payedCheckBox
            // 
            this.payedCheckBox.Location = new System.Drawing.Point(16, 181);
            this.payedCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.payedCheckBox.Name = "payedCheckBox";
            this.payedCheckBox.Size = new System.Drawing.Size(111, 25);
            this.payedCheckBox.TabIndex = 14;
            this.payedCheckBox.Text = "Betala";
            this.payedCheckBox.UseVisualStyleBackColor = true;
            // 
            // extraBedsNumeric
            // 
            this.extraBedsNumeric.Location = new System.Drawing.Point(114, 139);
            this.extraBedsNumeric.Name = "extraBedsNumeric";
            this.extraBedsNumeric.Size = new System.Drawing.Size(102, 23);
            this.extraBedsNumeric.TabIndex = 15;
            // 
            // BookingRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 259);
            this.Controls.Add(this.extraBedsNumeric);
            this.Controls.Add(this.payedCheckBox);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookingRoomForm";
            this.Text = "BookingRoomForm";
            this.Load += new System.EventHandler(this.BookingRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.extraBedsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.CheckBox payedCheckBox;

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

        private System.Windows.Forms.NumericUpDown extraBedsNumeric;
    }
}