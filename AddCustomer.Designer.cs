namespace OOPproject_form
{
    partial class AddCustomer
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
            this.custFNameBtn = new System.Windows.Forms.TextBox();
            this.custLNameBtn = new System.Windows.Forms.TextBox();
            this.custPhoneNumBtn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addCustBtn = new System.Windows.Forms.Button();
            this.addCustMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // custFNameBtn
            // 
            this.custFNameBtn.Location = new System.Drawing.Point(239, 80);
            this.custFNameBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.custFNameBtn.Name = "custFNameBtn";
            this.custFNameBtn.Size = new System.Drawing.Size(249, 22);
            this.custFNameBtn.TabIndex = 3;
            this.custFNameBtn.TextChanged += new System.EventHandler(this.custFNameBtn_TextChanged);
            // 
            // custLNameBtn
            // 
            this.custLNameBtn.Location = new System.Drawing.Point(239, 130);
            this.custLNameBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.custLNameBtn.Name = "custLNameBtn";
            this.custLNameBtn.Size = new System.Drawing.Size(249, 22);
            this.custLNameBtn.TabIndex = 4;
            this.custLNameBtn.TextChanged += new System.EventHandler(this.custLNameBtn_TextChanged);
            // 
            // custPhoneNumBtn
            // 
            this.custPhoneNumBtn.Location = new System.Drawing.Point(239, 185);
            this.custPhoneNumBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.custPhoneNumBtn.Name = "custPhoneNumBtn";
            this.custPhoneNumBtn.Size = new System.Drawing.Size(249, 22);
            this.custPhoneNumBtn.TabIndex = 5;
            this.custPhoneNumBtn.TextChanged += new System.EventHandler(this.custPhoneNumBtn_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Create a New Customer";
            // 
            // addCustBtn
            // 
            this.addCustBtn.Location = new System.Drawing.Point(325, 279);
            this.addCustBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addCustBtn.Name = "addCustBtn";
            this.addCustBtn.Size = new System.Drawing.Size(100, 28);
            this.addCustBtn.TabIndex = 7;
            this.addCustBtn.Text = "Add";
            this.addCustBtn.UseVisualStyleBackColor = true;
            this.addCustBtn.Click += new System.EventHandler(this.addCustBtn_Click);
            // 
            // addCustMsg
            // 
            this.addCustMsg.AutoSize = true;
            this.addCustMsg.ForeColor = System.Drawing.Color.Red;
            this.addCustMsg.Location = new System.Drawing.Point(340, 360);
            this.addCustMsg.Name = "addCustMsg";
            this.addCustMsg.Size = new System.Drawing.Size(0, 16);
            this.addCustMsg.TabIndex = 8;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.addCustMsg);
            this.Controls.Add(this.addCustBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.custPhoneNumBtn);
            this.Controls.Add(this.custLNameBtn);
            this.Controls.Add(this.custFNameBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox custFNameBtn;
        private System.Windows.Forms.TextBox custLNameBtn;
        private System.Windows.Forms.TextBox custPhoneNumBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addCustBtn;
        private System.Windows.Forms.Label addCustMsg;
    }
}