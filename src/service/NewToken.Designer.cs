namespace LaptopManagement
{
    partial class NewToken
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewToken = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rdWarranty = new System.Windows.Forms.RadioButton();
            this.rdService = new System.Windows.Forms.RadioButton();
            this.customerInfoContainer = new System.Windows.Forms.Panel();
            this.pnl_CustomerNotAvailable = new System.Windows.Forms.Panel();
            this.btnAddnewCustomer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTlist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerInfoContainer.SuspendLayout();
            this.pnl_CustomerNotAvailable.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewToken
            // 
            this.btnNewToken.Location = new System.Drawing.Point(333, 427);
            this.btnNewToken.Name = "btnNewToken";
            this.btnNewToken.Size = new System.Drawing.Size(164, 23);
            this.btnNewToken.TabIndex = 0;
            this.btnNewToken.Text = "Generate New Repair Order";
            this.btnNewToken.UseVisualStyleBackColor = true;
            this.btnNewToken.Click += new System.EventHandler(this.btnNewToken_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(201, 91);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(151, 24);
            this.txtPhone.TabIndex = 83;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 82;
            this.label6.Text = "Phone Number";
            // 
            // txtDiscription
            // 
            this.txtDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscription.Location = new System.Drawing.Point(201, 245);
            this.txtDiscription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(151, 110);
            this.txtDiscription.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Discription";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(201, 189);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(151, 52);
            this.txtProductName.TabIndex = 69;
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(201, 158);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(151, 24);
            this.txtProductID.TabIndex = 68;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(80, 192);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(101, 18);
            this.lblProductName.TabIndex = 67;
            this.lblProductName.Text = "Product name";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(80, 161);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(78, 18);
            this.lblProductID.TabIndex = 66;
            this.lblProductID.Text = "Product ID";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(201, 124);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(151, 24);
            this.txtCustomerName.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 80;
            this.label7.Text = "Customer Name";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(538, 83);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(151, 24);
            this.txtCost.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 84;
            this.label5.Text = "Cost";
            // 
            // txtToken
            // 
            this.txtToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToken.Location = new System.Drawing.Point(538, 120);
            this.txtToken.Margin = new System.Windows.Forms.Padding(2);
            this.txtToken.Name = "txtToken";
            this.txtToken.ReadOnly = true;
            this.txtToken.Size = new System.Drawing.Size(151, 24);
            this.txtToken.TabIndex = 95;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(431, 123);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 94;
            this.label9.Text = "Repair ID";
            // 
            // rdWarranty
            // 
            this.rdWarranty.AutoSize = true;
            this.rdWarranty.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdWarranty.Location = new System.Drawing.Point(271, 35);
            this.rdWarranty.Name = "rdWarranty";
            this.rdWarranty.Size = new System.Drawing.Size(117, 17);
            this.rdWarranty.TabIndex = 98;
            this.rdWarranty.TabStop = true;
            this.rdWarranty.Text = "Warranty Coverage";
            this.rdWarranty.UseVisualStyleBackColor = true;
            this.rdWarranty.CheckedChanged += new System.EventHandler(this.rdWarranty_CheckedChanged);
            // 
            // rdService
            // 
            this.rdService.AutoSize = true;
            this.rdService.Location = new System.Drawing.Point(411, 35);
            this.rdService.Name = "rdService";
            this.rdService.Size = new System.Drawing.Size(116, 17);
            this.rdService.TabIndex = 99;
            this.rdService.TabStop = true;
            this.rdService.Text = "Service and Repair";
            this.rdService.UseVisualStyleBackColor = true;
            this.rdService.CheckedChanged += new System.EventHandler(this.rdService_CheckedChanged);
            // 
            // customerInfoContainer
            // 
            this.customerInfoContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerInfoContainer.Controls.Add(this.pnl_CustomerNotAvailable);
            this.customerInfoContainer.Location = new System.Drawing.Point(201, 118);
            this.customerInfoContainer.Name = "customerInfoContainer";
            this.customerInfoContainer.Size = new System.Drawing.Size(154, 0);
            this.customerInfoContainer.TabIndex = 100;
            // 
            // pnl_CustomerNotAvailable
            // 
            this.pnl_CustomerNotAvailable.Controls.Add(this.btnAddnewCustomer);
            this.pnl_CustomerNotAvailable.Controls.Add(this.label4);
            this.pnl_CustomerNotAvailable.Location = new System.Drawing.Point(3, 4);
            this.pnl_CustomerNotAvailable.Name = "pnl_CustomerNotAvailable";
            this.pnl_CustomerNotAvailable.Size = new System.Drawing.Size(145, 85);
            this.pnl_CustomerNotAvailable.TabIndex = 33;
            // 
            // btnAddnewCustomer
            // 
            this.btnAddnewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(96)))), ((int)(((byte)(137)))));
            this.btnAddnewCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddnewCustomer.Location = new System.Drawing.Point(17, 35);
            this.btnAddnewCustomer.Name = "btnAddnewCustomer";
            this.btnAddnewCustomer.Size = new System.Drawing.Size(110, 27);
            this.btnAddnewCustomer.TabIndex = 34;
            this.btnAddnewCustomer.Text = "Add new Customer";
            this.btnAddnewCustomer.UseVisualStyleBackColor = false;
            this.btnAddnewCustomer.Click += new System.EventHandler(this.btnAddnewCustomer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Customer Not Available";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbTlist
            // 
            this.cmbTlist.FormattingEnabled = true;
            this.cmbTlist.Location = new System.Drawing.Point(538, 163);
            this.cmbTlist.Name = "cmbTlist";
            this.cmbTlist.Size = new System.Drawing.Size(151, 21);
            this.cmbTlist.TabIndex = 102;
            this.cmbTlist.SelectedIndexChanged += new System.EventHandler(this.cmbTlist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 103;
            this.label1.Text = "Technician";
            // 
            // NewToken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTlist);
            this.Controls.Add(this.customerInfoContainer);
            this.Controls.Add(this.rdService);
            this.Controls.Add(this.rdWarranty);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.btnNewToken);
            this.Name = "NewToken";
            this.Size = new System.Drawing.Size(770, 510);
            this.Load += new System.EventHandler(this.NewToken_Load);
            this.customerInfoContainer.ResumeLayout(false);
            this.pnl_CustomerNotAvailable.ResumeLayout(false);
            this.pnl_CustomerNotAvailable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewToken;
        public System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
        public System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdWarranty;
        private System.Windows.Forms.RadioButton rdService;
        public System.Windows.Forms.Panel customerInfoContainer;
        private System.Windows.Forms.Panel pnl_CustomerNotAvailable;
        private System.Windows.Forms.Button btnAddnewCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTlist;
        private System.Windows.Forms.Label label1;
    }
}
