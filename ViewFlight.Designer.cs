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
            this.lvViewFlight = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight ID";
            // 
            // viewFlightId
            // 
            this.viewFlightId.Location = new System.Drawing.Point(154, 88);
            this.viewFlightId.Name = "viewFlightId";
            this.viewFlightId.Size = new System.Drawing.Size(125, 20);
            this.viewFlightId.TabIndex = 1;
            // 
            // lvViewFlight
            // 
            this.lvViewFlight.HideSelection = false;
            this.lvViewFlight.Location = new System.Drawing.Point(59, 190);
            this.lvViewFlight.Name = "lvViewFlight";
            this.lvViewFlight.Size = new System.Drawing.Size(525, 198);
            this.lvViewFlight.TabIndex = 2;
            this.lvViewFlight.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "To view a specific flight, enter the flight ID below:";
            // 
            // ViewFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvViewFlight);
            this.Controls.Add(this.viewFlightId);
            this.Controls.Add(this.label1);
            this.Name = "ViewFlight";
            this.Text = "ViewFlight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox viewFlightId;
        private System.Windows.Forms.ListView lvViewFlight;
        private System.Windows.Forms.Label label2;
    }
}