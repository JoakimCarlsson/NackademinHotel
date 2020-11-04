namespace NackademinHotel
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.manageCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerListBox
            // 
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.Location = new System.Drawing.Point(12, 35);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(195, 199);
            this.customerListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrerade Kunder";
            // 
            // manageCustomer
            // 
            this.manageCustomer.Location = new System.Drawing.Point(12, 240);
            this.manageCustomer.Name = "manageCustomer";
            this.manageCustomer.Size = new System.Drawing.Size(92, 23);
            this.manageCustomer.TabIndex = 2;
            this.manageCustomer.Text = "Hantera Kunder";
            this.manageCustomer.UseVisualStyleBackColor = true;
            this.manageCustomer.Click += new System.EventHandler(this.registerCustomer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 390);
            this.Controls.Add(this.manageCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Hotel Service";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button manageCustomer;

        private System.Windows.Forms.ListBox customerListBox;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}

