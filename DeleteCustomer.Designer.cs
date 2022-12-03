namespace OOPproject_form
{
    partial class DeleteCustomer
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
            this.custIDText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteCustBtn = new System.Windows.Forms.Button();
            this.deleteCustMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // custIDText
            // 
            this.custIDText.Location = new System.Drawing.Point(259, 130);
            this.custIDText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.custIDText.Name = "custIDText";
            this.custIDText.Size = new System.Drawing.Size(307, 22);
            this.custIDText.TabIndex = 1;
            this.custIDText.TextChanged += new System.EventHandler(this.custIDText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "To delete a customer please enter their customer ID below:";
            // 
            // deleteCustBtn
            // 
            this.deleteCustBtn.Location = new System.Drawing.Point(335, 212);
            this.deleteCustBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteCustBtn.Name = "deleteCustBtn";
            this.deleteCustBtn.Size = new System.Drawing.Size(100, 28);
            this.deleteCustBtn.TabIndex = 3;
            this.deleteCustBtn.Text = "Delete";
            this.deleteCustBtn.UseVisualStyleBackColor = true;
            this.deleteCustBtn.Click += new System.EventHandler(this.deleteCustBtn_Click);
            // 
            // deleteCustMsg
            // 
            this.deleteCustMsg.AutoSize = true;
            this.deleteCustMsg.ForeColor = System.Drawing.Color.Red;
            this.deleteCustMsg.Location = new System.Drawing.Point(274, 342);
            this.deleteCustMsg.Name = "deleteCustMsg";
            this.deleteCustMsg.Size = new System.Drawing.Size(0, 16);
            this.deleteCustMsg.TabIndex = 4;
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.deleteCustMsg);
            this.Controls.Add(this.deleteCustBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.custIDText);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeleteCustomer";
            this.Text = "CustomersMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox custIDText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteCustBtn;
        private System.Windows.Forms.Label deleteCustMsg;
    }
}