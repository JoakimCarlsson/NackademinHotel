using System.ComponentModel;

namespace NackademinHotel
{
    partial class BookingForm
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
            this.bookinListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.availableRooms = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.saveBookingbutton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookinListBox
            // 
            this.bookinListBox.FormattingEnabled = true;
            this.bookinListBox.Location = new System.Drawing.Point(12, 34);
            this.bookinListBox.Name = "bookinListBox";
            this.bookinListBox.Size = new System.Drawing.Size(182, 316);
            this.bookinListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bokningar";
            // 
            // availableRooms
            // 
            this.availableRooms.FormattingEnabled = true;
            this.availableRooms.Location = new System.Drawing.Point(222, 34);
            this.availableRooms.Name = "availableRooms";
            this.availableRooms.Size = new System.Drawing.Size(182, 316);
            this.availableRooms.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(222, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lediga Rum";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(426, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Datum";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(426, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Slut Datum";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(426, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kund";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(511, 28);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(153, 20);
            this.startDate.TabIndex = 7;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(511, 52);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(153, 20);
            this.endDate.TabIndex = 8;
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(511, 77);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(153, 21);
            this.customerComboBox.TabIndex = 10;
            // 
            // saveBookingbutton
            // 
            this.saveBookingbutton.Location = new System.Drawing.Point(426, 109);
            this.saveBookingbutton.Name = "saveBookingbutton";
            this.saveBookingbutton.Size = new System.Drawing.Size(84, 23);
            this.saveBookingbutton.TabIndex = 11;
            this.saveBookingbutton.Text = "Spara";
            this.saveBookingbutton.UseVisualStyleBackColor = true;
            this.saveBookingbutton.Click += new System.EventHandler(this.saveBookingbutton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(14, 354);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(109, 27);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Redigera";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.saveBookingbutton);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.availableRooms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookinListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button editButton;

        private System.Windows.Forms.DateTimePicker endDate;

        private System.Windows.Forms.Button saveBookingbutton;

        private System.Windows.Forms.ComboBox customerComboBox;

        private System.Windows.Forms.DateTimePicker startDate;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.ListBox availableRooms;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ListBox bookinListBox;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}