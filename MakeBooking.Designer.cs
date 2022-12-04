namespace OOPproject_form
{
    partial class MakeBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookingFlightId = new System.Windows.Forms.TextBox();
            this.bookingCustId = new System.Windows.Forms.TextBox();
            this.addBookingBtn = new System.Windows.Forms.Button();
            this.addBookingMsg = new System.Windows.Forms.Label();
            this.bookingTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "To add a booking, enter the flight ID and the Customer ID below:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Flight ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer ID";
            // 
            // bookingFlightId
            // 
            this.bookingFlightId.Location = new System.Drawing.Point(635, 126);
            this.bookingFlightId.Margin = new System.Windows.Forms.Padding(4);
            this.bookingFlightId.Name = "bookingFlightId";
            this.bookingFlightId.Size = new System.Drawing.Size(176, 22);
            this.bookingFlightId.TabIndex = 4;
            this.bookingFlightId.TextChanged += new System.EventHandler(this.bookingFlightId_TextChanged);
            // 
            // bookingCustId
            // 
            this.bookingCustId.Location = new System.Drawing.Point(635, 187);
            this.bookingCustId.Margin = new System.Windows.Forms.Padding(4);
            this.bookingCustId.Name = "bookingCustId";
            this.bookingCustId.Size = new System.Drawing.Size(176, 22);
            this.bookingCustId.TabIndex = 5;
            this.bookingCustId.TextChanged += new System.EventHandler(this.bookingCustId_TextChanged);
            // 
            // addBookingBtn
            // 
            this.addBookingBtn.Location = new System.Drawing.Point(647, 277);
            this.addBookingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBookingBtn.Name = "addBookingBtn";
            this.addBookingBtn.Size = new System.Drawing.Size(151, 28);
            this.addBookingBtn.TabIndex = 6;
            this.addBookingBtn.Text = "Add Booking";
            this.addBookingBtn.UseVisualStyleBackColor = true;
            this.addBookingBtn.Click += new System.EventHandler(this.addBookingBtn_Click);
            // 
            // addBookingMsg
            // 
            this.addBookingMsg.AutoSize = true;
            this.addBookingMsg.ForeColor = System.Drawing.Color.Red;
            this.addBookingMsg.Location = new System.Drawing.Point(633, 378);
            this.addBookingMsg.Name = "addBookingMsg";
            this.addBookingMsg.Size = new System.Drawing.Size(0, 16);
            this.addBookingMsg.TabIndex = 7;
            // 
            // bookingTextBox
            // 
            this.bookingTextBox.Location = new System.Drawing.Point(31, 28);
            this.bookingTextBox.Name = "bookingTextBox";
            this.bookingTextBox.Size = new System.Drawing.Size(392, 448);
            this.bookingTextBox.TabIndex = 8;
            this.bookingTextBox.Text = "";
            // 
            // MakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bookingTextBox);
            this.Controls.Add(this.addBookingMsg);
            this.Controls.Add(this.addBookingBtn);
            this.Controls.Add(this.bookingCustId);
            this.Controls.Add(this.bookingFlightId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MakeBooking";
            this.Text = "BookingMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookingFlightId;
        private System.Windows.Forms.TextBox bookingCustId;
        private System.Windows.Forms.Button addBookingBtn;
        private System.Windows.Forms.Label addBookingMsg;
        private System.Windows.Forms.RichTextBox bookingTextBox;
    }
}