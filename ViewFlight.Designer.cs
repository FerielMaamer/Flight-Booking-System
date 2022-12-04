namespace OOPproject_form
{
    partial class ViewFlight
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
            this.viewFlightId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewFlightBtn = new System.Windows.Forms.Button();
            this.flightTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight ID";
            // 
            // viewFlightId
            // 
            this.viewFlightId.Location = new System.Drawing.Point(205, 108);
            this.viewFlightId.Margin = new System.Windows.Forms.Padding(4);
            this.viewFlightId.Name = "viewFlightId";
            this.viewFlightId.Size = new System.Drawing.Size(165, 22);
            this.viewFlightId.TabIndex = 1;
            this.viewFlightId.TextChanged += new System.EventHandler(this.viewFlightId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "To view a specific flight, enter the flight ID below:";
            // 
            // viewFlightBtn
            // 
            this.viewFlightBtn.Location = new System.Drawing.Point(236, 173);
            this.viewFlightBtn.Name = "viewFlightBtn";
            this.viewFlightBtn.Size = new System.Drawing.Size(114, 23);
            this.viewFlightBtn.TabIndex = 4;
            this.viewFlightBtn.Text = "View Flight";
            this.viewFlightBtn.UseVisualStyleBackColor = true;
            this.viewFlightBtn.Click += new System.EventHandler(this.viewFlightBtn_Click);
            // 
            // flightTextBox
            // 
            this.flightTextBox.Location = new System.Drawing.Point(88, 248);
            this.flightTextBox.Name = "flightTextBox";
            this.flightTextBox.Size = new System.Drawing.Size(426, 249);
            this.flightTextBox.TabIndex = 5;
            this.flightTextBox.Text = "";
            // 
            // ViewFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.flightTextBox);
            this.Controls.Add(this.viewFlightBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewFlightId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewFlight";
            this.Text = "ViewFlight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox viewFlightId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewFlightBtn;
        private System.Windows.Forms.RichTextBox flightTextBox;
    }
}