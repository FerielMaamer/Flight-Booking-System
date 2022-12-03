namespace OOPproject_form
{
    partial class DeleteFlight
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
            this.deleteFlightBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flightIDText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteFlightMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteFlightBtn
            // 
            this.deleteFlightBtn.Location = new System.Drawing.Point(363, 236);
            this.deleteFlightBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteFlightBtn.Name = "deleteFlightBtn";
            this.deleteFlightBtn.Size = new System.Drawing.Size(100, 28);
            this.deleteFlightBtn.TabIndex = 8;
            this.deleteFlightBtn.Text = "Delete";
            this.deleteFlightBtn.UseVisualStyleBackColor = true;
            this.deleteFlightBtn.Click += new System.EventHandler(this.deleteFlightBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "To delete a flight please enter the flight ID below:";
            // 
            // flightIDText
            // 
            this.flightIDText.Location = new System.Drawing.Point(357, 155);
            this.flightIDText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flightIDText.Name = "flightIDText";
            this.flightIDText.Size = new System.Drawing.Size(307, 22);
            this.flightIDText.TabIndex = 6;
            this.flightIDText.TextChanged += new System.EventHandler(this.flightIDText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Flight ID";
            // 
            // deleteFlightMsg
            // 
            this.deleteFlightMsg.AutoSize = true;
            this.deleteFlightMsg.ForeColor = System.Drawing.Color.Red;
            this.deleteFlightMsg.Location = new System.Drawing.Point(329, 366);
            this.deleteFlightMsg.Name = "deleteFlightMsg";
            this.deleteFlightMsg.Size = new System.Drawing.Size(0, 16);
            this.deleteFlightMsg.TabIndex = 9;
            // 
            // DeleteFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.deleteFlightMsg);
            this.Controls.Add(this.deleteFlightBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flightIDText);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeleteFlight";
            this.Text = "DeleteFlight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteFlightBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox flightIDText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label deleteFlightMsg;
    }
}