namespace OOPproject_form
{
    partial class AddFlight
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
            this.label4 = new System.Windows.Forms.Label();
            this.flightNumBtn = new System.Windows.Forms.TextBox();
            this.flightOrgBtn = new System.Windows.Forms.TextBox();
            this.flightDestBtn = new System.Windows.Forms.TextBox();
            this.flightCapacityBtn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addFlightbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Number ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Flight Origin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Flight Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Flight Capacity";
            // 
            // flightNumBtn
            // 
            this.flightNumBtn.Location = new System.Drawing.Point(214, 62);
            this.flightNumBtn.Name = "flightNumBtn";
            this.flightNumBtn.Size = new System.Drawing.Size(164, 20);
            this.flightNumBtn.TabIndex = 4;
            this.flightNumBtn.TextChanged += new System.EventHandler(this.flightNumBtn_TextChanged);
            // 
            // flightOrgBtn
            // 
            this.flightOrgBtn.Location = new System.Drawing.Point(214, 111);
            this.flightOrgBtn.Name = "flightOrgBtn";
            this.flightOrgBtn.Size = new System.Drawing.Size(164, 20);
            this.flightOrgBtn.TabIndex = 5;
            this.flightOrgBtn.TextChanged += new System.EventHandler(this.flightOrgBtn_TextChanged);
            // 
            // flightDestBtn
            // 
            this.flightDestBtn.Location = new System.Drawing.Point(214, 165);
            this.flightDestBtn.Name = "flightDestBtn";
            this.flightDestBtn.Size = new System.Drawing.Size(164, 20);
            this.flightDestBtn.TabIndex = 6;
            this.flightDestBtn.TextChanged += new System.EventHandler(this.flightDestBtn_TextChanged);
            // 
            // flightCapacityBtn
            // 
            this.flightCapacityBtn.Location = new System.Drawing.Point(214, 219);
            this.flightCapacityBtn.Name = "flightCapacityBtn";
            this.flightCapacityBtn.Size = new System.Drawing.Size(164, 20);
            this.flightCapacityBtn.TabIndex = 7;
            this.flightCapacityBtn.TextChanged += new System.EventHandler(this.flightCapacityBtn_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Create a new flight";
            // 
            // addFlightbtn
            // 
            this.addFlightbtn.Location = new System.Drawing.Point(251, 282);
            this.addFlightbtn.Name = "addFlightbtn";
            this.addFlightbtn.Size = new System.Drawing.Size(75, 23);
            this.addFlightbtn.TabIndex = 9;
            this.addFlightbtn.Text = "Add";
            this.addFlightbtn.UseVisualStyleBackColor = true;
            this.addFlightbtn.Click += new System.EventHandler(this.addFlightbtn_Click);
            // 
            // AddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addFlightbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flightCapacityBtn);
            this.Controls.Add(this.flightDestBtn);
            this.Controls.Add(this.flightOrgBtn);
            this.Controls.Add(this.flightNumBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFlight";
            this.Text = "Flights_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox flightNumBtn;
        private System.Windows.Forms.TextBox flightOrgBtn;
        private System.Windows.Forms.TextBox flightDestBtn;
        private System.Windows.Forms.TextBox flightCapacityBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addFlightbtn;
    }
}