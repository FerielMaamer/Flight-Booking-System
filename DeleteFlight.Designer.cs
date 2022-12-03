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
            this.lvDeleteFlight = new System.Windows.Forms.ListView();
            this.deleteFlightBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flightIDText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvDeleteFlight
            // 
            this.lvDeleteFlight.HideSelection = false;
            this.lvDeleteFlight.Location = new System.Drawing.Point(146, 270);
            this.lvDeleteFlight.Name = "lvDeleteFlight";
            this.lvDeleteFlight.Size = new System.Drawing.Size(353, 85);
            this.lvDeleteFlight.TabIndex = 9;
            this.lvDeleteFlight.UseCompatibleStateImageBehavior = false;
            this.lvDeleteFlight.SelectedIndexChanged += new System.EventHandler(this.lvDeleteFlight_SelectedIndexChanged);
            // 
            // deleteFlightBtn
            // 
            this.deleteFlightBtn.Location = new System.Drawing.Point(272, 192);
            this.deleteFlightBtn.Name = "deleteFlightBtn";
            this.deleteFlightBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteFlightBtn.TabIndex = 8;
            this.deleteFlightBtn.Text = "Delete";
            this.deleteFlightBtn.UseVisualStyleBackColor = true;
            this.deleteFlightBtn.Click += new System.EventHandler(this.deleteFlightBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "To delete a flight please enter the flight ID below:";
            // 
            // flightIDText
            // 
            this.flightIDText.Location = new System.Drawing.Point(268, 126);
            this.flightIDText.Name = "flightIDText";
            this.flightIDText.Size = new System.Drawing.Size(231, 20);
            this.flightIDText.TabIndex = 6;
            this.flightIDText.TextChanged += new System.EventHandler(this.flightIDText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Flight ID";
            // 
            // DeleteFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvDeleteFlight);
            this.Controls.Add(this.deleteFlightBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flightIDText);
            this.Controls.Add(this.label1);
            this.Name = "DeleteFlight";
            this.Text = "DeleteFlight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDeleteFlight;
        private System.Windows.Forms.Button deleteFlightBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox flightIDText;
        private System.Windows.Forms.Label label1;
    }
}