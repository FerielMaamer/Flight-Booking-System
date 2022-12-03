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
            this.addBookingView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookingFlightId = new System.Windows.Forms.TextBox();
            this.bookingCustId = new System.Windows.Forms.TextBox();
            this.addBookingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBookingView
            // 
            this.addBookingView.HideSelection = false;
            this.addBookingView.Location = new System.Drawing.Point(38, 53);
            this.addBookingView.Name = "addBookingView";
            this.addBookingView.Size = new System.Drawing.Size(279, 342);
            this.addBookingView.TabIndex = 0;
            this.addBookingView.UseCompatibleStateImageBehavior = false;
            this.addBookingView.SelectedIndexChanged += new System.EventHandler(this.addBookingView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To add a booking, enter the flight ID and the Customer ID below:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Flight ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer ID";
            // 
            // bookingFlightId
            // 
            this.bookingFlightId.Location = new System.Drawing.Point(476, 102);
            this.bookingFlightId.Name = "bookingFlightId";
            this.bookingFlightId.Size = new System.Drawing.Size(133, 20);
            this.bookingFlightId.TabIndex = 4;
            this.bookingFlightId.TextChanged += new System.EventHandler(this.bookingFlightId_TextChanged);
            // 
            // bookingCustId
            // 
            this.bookingCustId.Location = new System.Drawing.Point(476, 152);
            this.bookingCustId.Name = "bookingCustId";
            this.bookingCustId.Size = new System.Drawing.Size(133, 20);
            this.bookingCustId.TabIndex = 5;
            this.bookingCustId.TextChanged += new System.EventHandler(this.bookingCustId_TextChanged);
            // 
            // addBookingBtn
            // 
            this.addBookingBtn.Location = new System.Drawing.Point(485, 225);
            this.addBookingBtn.Name = "addBookingBtn";
            this.addBookingBtn.Size = new System.Drawing.Size(113, 23);
            this.addBookingBtn.TabIndex = 6;
            this.addBookingBtn.Text = "Add Booking";
            this.addBookingBtn.UseVisualStyleBackColor = true;
            this.addBookingBtn.Click += new System.EventHandler(this.addBookingBtn_Click);
            // 
            // MakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addBookingBtn);
            this.Controls.Add(this.bookingCustId);
            this.Controls.Add(this.bookingFlightId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBookingView);
            this.Name = "MakeBooking";
            this.Text = "BookingMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView addBookingView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookingFlightId;
        private System.Windows.Forms.TextBox bookingCustId;
        private System.Windows.Forms.Button addBookingBtn;
    }
}