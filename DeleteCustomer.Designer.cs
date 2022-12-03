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
            this.lvDeleteCust = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // custIDText
            // 
            this.custIDText.Location = new System.Drawing.Point(247, 106);
            this.custIDText.Name = "custIDText";
            this.custIDText.Size = new System.Drawing.Size(231, 20);
            this.custIDText.TabIndex = 1;
            this.custIDText.TextChanged += new System.EventHandler(this.custIDText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "To delete a customer please enter their customer ID below:";
            // 
            // deleteCustBtn
            // 
            this.deleteCustBtn.Location = new System.Drawing.Point(251, 172);
            this.deleteCustBtn.Name = "deleteCustBtn";
            this.deleteCustBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteCustBtn.TabIndex = 3;
            this.deleteCustBtn.Text = "Delete";
            this.deleteCustBtn.UseVisualStyleBackColor = true;
            this.deleteCustBtn.Click += new System.EventHandler(this.deleteCustBtn_Click);
            // 
            // lvDeleteCust
            // 
            this.lvDeleteCust.HideSelection = false;
            this.lvDeleteCust.Location = new System.Drawing.Point(125, 250);
            this.lvDeleteCust.Name = "lvDeleteCust";
            this.lvDeleteCust.Size = new System.Drawing.Size(353, 85);
            this.lvDeleteCust.TabIndex = 4;
            this.lvDeleteCust.UseCompatibleStateImageBehavior = false;
            this.lvDeleteCust.SelectedIndexChanged += new System.EventHandler(this.lvDeleteCust_SelectedIndexChanged);
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvDeleteCust);
            this.Controls.Add(this.deleteCustBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.custIDText);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ListView lvDeleteCust;
    }
}