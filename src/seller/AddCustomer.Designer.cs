namespace LaptopManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_clearAll = new System.Windows.Forms.Button();
            this.txtbox_CustomerEmail = new System.Windows.Forms.TextBox();
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.txtbox_CustomerAddress = new System.Windows.Forms.TextBox();
            this.txtbox_CustomerPhone = new System.Windows.Forms.TextBox();
            this.txtlbl_username = new System.Windows.Forms.Label();
            this.txtlbl_address = new System.Windows.Forms.Label();
            this.txtlbl_empName = new System.Windows.Forms.Label();
            this.txtbox_CustomerName = new System.Windows.Forms.TextBox();
            this.txtlbl_search = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtlbl_phn = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_Customer = new System.Windows.Forms.DataGridView();
            this.btn_dlt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(397, 444);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 37);
            this.btn_save.TabIndex = 78;
            this.btn_save.Text = "Save and Update";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(298, 444);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 37);
            this.btn_Add.TabIndex = 76;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_clearAll
            // 
            this.btn_clearAll.Location = new System.Drawing.Point(196, 444);
            this.btn_clearAll.Name = "btn_clearAll";
            this.btn_clearAll.Size = new System.Drawing.Size(78, 37);
            this.btn_clearAll.TabIndex = 75;
            this.btn_clearAll.Text = "Clear All";
            this.btn_clearAll.UseVisualStyleBackColor = true;
            this.btn_clearAll.Click += new System.EventHandler(this.btn_clearAll_Click);
            // 
            // txtbox_CustomerEmail
            // 
            this.txtbox_CustomerEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtbox_CustomerEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_CustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_CustomerEmail.Location = new System.Drawing.Point(238, 398);
            this.txtbox_CustomerEmail.Name = "txtbox_CustomerEmail";
            this.txtbox_CustomerEmail.Size = new System.Drawing.Size(407, 24);
            this.txtbox_CustomerEmail.TabIndex = 73;
            this.txtbox_CustomerEmail.TextChanged += new System.EventHandler(this.txtbox_CustomerEmail_TextChanged);
            // 
            // txtbox_search
            // 
            this.txtbox_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtbox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_search.Font = new System.Drawing.Font("Ubuntu Mono Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_search.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_search.Location = new System.Drawing.Point(149, 23);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(534, 24);
            this.txtbox_search.TabIndex = 74;
            this.txtbox_search.TextChanged += new System.EventHandler(this.txtbox_search_TextChanged);
            this.txtbox_search.Enter += new System.EventHandler(this.txtbox_search_Enter);
            // 
            // txtbox_CustomerAddress
            // 
            this.txtbox_CustomerAddress.BackColor = System.Drawing.Color.White;
            this.txtbox_CustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_CustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_CustomerAddress.Location = new System.Drawing.Point(238, 363);
            this.txtbox_CustomerAddress.Name = "txtbox_CustomerAddress";
            this.txtbox_CustomerAddress.Size = new System.Drawing.Size(407, 24);
            this.txtbox_CustomerAddress.TabIndex = 72;
            this.txtbox_CustomerAddress.TextChanged += new System.EventHandler(this.txtbox_CustomerAddress_TextChanged);
            // 
            // txtbox_CustomerPhone
            // 
            this.txtbox_CustomerPhone.BackColor = System.Drawing.Color.White;
            this.txtbox_CustomerPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_CustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_CustomerPhone.Location = new System.Drawing.Point(535, 330);
            this.txtbox_CustomerPhone.Name = "txtbox_CustomerPhone";
            this.txtbox_CustomerPhone.Size = new System.Drawing.Size(109, 24);
            this.txtbox_CustomerPhone.TabIndex = 71;
            this.txtbox_CustomerPhone.TextChanged += new System.EventHandler(this.txtbox_CustomerPhone_TextChanged);
            // 
            // txtlbl_username
            // 
            this.txtlbl_username.AutoSize = true;
            this.txtlbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl_username.Location = new System.Drawing.Point(114, 400);
            this.txtlbl_username.Name = "txtlbl_username";
            this.txtlbl_username.Size = new System.Drawing.Size(45, 18);
            this.txtlbl_username.TabIndex = 70;
            this.txtlbl_username.Text = "Email";
            this.txtlbl_username.Click += new System.EventHandler(this.txtlbl_username_Click);
            // 
            // txtlbl_address
            // 
            this.txtlbl_address.AutoSize = true;
            this.txtlbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl_address.Location = new System.Drawing.Point(114, 363);
            this.txtlbl_address.Name = "txtlbl_address";
            this.txtlbl_address.Size = new System.Drawing.Size(62, 18);
            this.txtlbl_address.TabIndex = 69;
            this.txtlbl_address.Text = "Address";
            this.txtlbl_address.Click += new System.EventHandler(this.txtlbl_address_Click);
            // 
            // txtlbl_empName
            // 
            this.txtlbl_empName.AutoSize = true;
            this.txtlbl_empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl_empName.Location = new System.Drawing.Point(114, 332);
            this.txtlbl_empName.Name = "txtlbl_empName";
            this.txtlbl_empName.Size = new System.Drawing.Size(118, 18);
            this.txtlbl_empName.TabIndex = 67;
            this.txtlbl_empName.Text = "Customer Name";
            this.txtlbl_empName.Click += new System.EventHandler(this.txtlbl_empName_Click);
            // 
            // txtbox_CustomerName
            // 
            this.txtbox_CustomerName.BackColor = System.Drawing.Color.White;
            this.txtbox_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_CustomerName.Location = new System.Drawing.Point(238, 330);
            this.txtbox_CustomerName.Name = "txtbox_CustomerName";
            this.txtbox_CustomerName.Size = new System.Drawing.Size(167, 24);
            this.txtbox_CustomerName.TabIndex = 66;
            this.txtbox_CustomerName.TextChanged += new System.EventHandler(this.txtbox_CustomerName_TextChanged);
            // 
            // txtlbl_search
            // 
            this.txtlbl_search.AutoSize = true;
            this.txtlbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl_search.Location = new System.Drawing.Point(88, 25);
            this.txtlbl_search.Name = "txtlbl_search";
            this.txtlbl_search.Size = new System.Drawing.Size(55, 18);
            this.txtlbl_search.TabIndex = 65;
            this.txtlbl_search.Text = "Search";
            // 
            // txtlbl_phn
            // 
            this.txtlbl_phn.AutoSize = true;
            this.txtlbl_phn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl_phn.Location = new System.Drawing.Point(411, 332);
            this.txtlbl_phn.Name = "txtlbl_phn";
            this.txtlbl_phn.Size = new System.Drawing.Size(108, 18);
            this.txtlbl_phn.TabIndex = 68;
            this.txtlbl_phn.Text = "Phone Number";
            this.txtlbl_phn.Click += new System.EventHandler(this.txtlbl_phn_Click);
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 150;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 40;
            // 
            // grid_Customer
            // 
            this.grid_Customer.AllowUserToAddRows = false;
            this.grid_Customer.AllowUserToDeleteRows = false;
            this.grid_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FullName,
            this.Phone,
            this.Email,
            this.Address});
            this.grid_Customer.Location = new System.Drawing.Point(90, 62);
            this.grid_Customer.Name = "grid_Customer";
            this.grid_Customer.ReadOnly = true;
            this.grid_Customer.RowHeadersVisible = false;
            this.grid_Customer.Size = new System.Drawing.Size(593, 244);
            this.grid_Customer.TabIndex = 79;
            this.grid_Customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Customer_CellContentClick);
            this.grid_Customer.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Customer_CellContentDoubleClick);
            this.grid_Customer.DoubleClick += new System.EventHandler(this.grid_Customer_DoubleClick);
            // 
            // btn_dlt
            // 
            this.btn_dlt.Location = new System.Drawing.Point(521, 444);
            this.btn_dlt.Name = "btn_dlt";
            this.btn_dlt.Size = new System.Drawing.Size(75, 37);
            this.btn_dlt.TabIndex = 77;
            this.btn_dlt.Text = "Delete";
            this.btn_dlt.UseVisualStyleBackColor = true;
            this.btn_dlt.Click += new System.EventHandler(this.btn_dlt_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid_Customer);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_dlt);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_clearAll);
            this.Controls.Add(this.txtbox_CustomerEmail);
            this.Controls.Add(this.txtbox_search);
            this.Controls.Add(this.txtbox_CustomerAddress);
            this.Controls.Add(this.txtbox_CustomerPhone);
            this.Controls.Add(this.txtlbl_username);
            this.Controls.Add(this.txtlbl_address);
            this.Controls.Add(this.txtlbl_empName);
            this.Controls.Add(this.txtbox_CustomerName);
            this.Controls.Add(this.txtlbl_search);
            this.Controls.Add(this.txtlbl_phn);
            this.Name = "AddCustomer";
            this.Size = new System.Drawing.Size(770, 510);
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_clearAll;
        private System.Windows.Forms.TextBox txtbox_CustomerEmail;
        private System.Windows.Forms.TextBox txtbox_search;
        private System.Windows.Forms.TextBox txtbox_CustomerAddress;
        private System.Windows.Forms.TextBox txtbox_CustomerPhone;
        private System.Windows.Forms.Label txtlbl_username;
        private System.Windows.Forms.Label txtlbl_address;
        private System.Windows.Forms.Label txtlbl_empName;
        private System.Windows.Forms.TextBox txtbox_CustomerName;
        private System.Windows.Forms.Label txtlbl_search;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label txtlbl_phn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridView grid_Customer;
        private System.Windows.Forms.Button btn_dlt;
    }
}
