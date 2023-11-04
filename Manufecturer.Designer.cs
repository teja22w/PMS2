namespace Pharmacy_Management_System
{
    partial class Manufecturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manufecturer));
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtManufecturerName = new System.Windows.Forms.TextBox();
            this.DGVManufecturer = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.txtJoinDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnSellers = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnMedicines = new System.Windows.Forms.Button();
            this.btnManufacturer = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.GoSelling = new System.Windows.Forms.PictureBox();
            this.GoLogout = new System.Windows.Forms.PictureBox();
            this.GoSellers = new System.Windows.Forms.PictureBox();
            this.GoCustomers = new System.Windows.Forms.PictureBox();
            this.GoMedicines = new System.Windows.Forms.PictureBox();
            this.GoManufacturer = new System.Windows.Forms.PictureBox();
            this.GoDashboard = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVManufecturer)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSellers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoManufacturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtGender.Location = new System.Drawing.Point(23, 162);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(190, 33);
            this.txtGender.TabIndex = 29;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobileNo.Location = new System.Drawing.Point(495, 82);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(190, 30);
            this.txtMobileNo.TabIndex = 27;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(244, 82);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(190, 70);
            this.txtAddress.TabIndex = 27;
            // 
            // txtManufecturerName
            // 
            this.txtManufecturerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtManufecturerName.Location = new System.Drawing.Point(23, 82);
            this.txtManufecturerName.Name = "txtManufecturerName";
            this.txtManufecturerName.Size = new System.Drawing.Size(190, 30);
            this.txtManufecturerName.TabIndex = 27;
            // 
            // DGVManufecturer
            // 
            this.DGVManufecturer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVManufecturer.BackgroundColor = System.Drawing.Color.White;
            this.DGVManufecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVManufecturer.GridColor = System.Drawing.Color.Black;
            this.DGVManufecturer.Location = new System.Drawing.Point(3, 242);
            this.DGVManufecturer.Name = "DGVManufecturer";
            this.DGVManufecturer.RowTemplate.Height = 24;
            this.DGVManufecturer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVManufecturer.Size = new System.Drawing.Size(973, 437);
            this.DGVManufecturer.TabIndex = 26;
            this.DGVManufecturer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVManufecturer_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(610, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(448, 158);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(287, 158);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(415, 211);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(175, 23);
            this.label17.TabIndex = 22;
            this.label17.Text = "Manufecturer List";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.LimeGreen;
            this.label15.Location = new System.Drawing.Point(19, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 25);
            this.label15.TabIndex = 12;
            this.label15.Text = "Gender";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.LimeGreen;
            this.label14.Location = new System.Drawing.Point(758, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "Join Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.LimeGreen;
            this.label8.Location = new System.Drawing.Point(491, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mobile No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(240, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(286, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 23);
            this.label18.TabIndex = 36;
            this.label18.Text = "Manufecturer";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.Controls.Add(this.txtGender);
            this.Panel2.Controls.Add(this.txtJoinDate);
            this.Panel2.Controls.Add(this.txtMobileNo);
            this.Panel2.Controls.Add(this.txtAddress);
            this.Panel2.Controls.Add(this.txtManufecturerName);
            this.Panel2.Controls.Add(this.DGVManufecturer);
            this.Panel2.Controls.Add(this.btnDelete);
            this.Panel2.Controls.Add(this.btnEdit);
            this.Panel2.Controls.Add(this.btnSave);
            this.Panel2.Controls.Add(this.label17);
            this.Panel2.Controls.Add(this.label15);
            this.Panel2.Controls.Add(this.label14);
            this.Panel2.Controls.Add(this.label8);
            this.Panel2.Controls.Add(this.label7);
            this.Panel2.Controls.Add(this.label6);
            this.Panel2.Controls.Add(this.label5);
            this.Panel2.Location = new System.Drawing.Point(289, 76);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(979, 682);
            this.Panel2.TabIndex = 33;
            // 
            // txtJoinDate
            // 
            this.txtJoinDate.CalendarForeColor = System.Drawing.Color.LimeGreen;
            this.txtJoinDate.CalendarTitleBackColor = System.Drawing.Color.LimeGreen;
            this.txtJoinDate.CalendarTitleForeColor = System.Drawing.Color.LimeGreen;
            this.txtJoinDate.CalendarTrailingForeColor = System.Drawing.Color.LimeGreen;
            this.txtJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtJoinDate.Location = new System.Drawing.Point(756, 77);
            this.txtJoinDate.Name = "txtJoinDate";
            this.txtJoinDate.Size = new System.Drawing.Size(166, 30);
            this.txtJoinDate.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(19, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Manufecturer Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(19, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Manufecturer Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(542, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 34);
            this.label4.TabIndex = 34;
            this.label4.Text = "Pharmacy Management System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(723, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Version 1.0";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1228, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 37;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.btnLogout);
            this.Panel1.Controls.Add(this.btnSelling);
            this.Panel1.Controls.Add(this.btnSellers);
            this.Panel1.Controls.Add(this.btnCustomers);
            this.Panel1.Controls.Add(this.btnMedicines);
            this.Panel1.Controls.Add(this.btnManufacturer);
            this.Panel1.Controls.Add(this.btnDashboard);
            this.Panel1.Controls.Add(this.GoSelling);
            this.Panel1.Controls.Add(this.GoLogout);
            this.Panel1.Controls.Add(this.GoSellers);
            this.Panel1.Controls.Add(this.GoCustomers);
            this.Panel1.Controls.Add(this.GoMedicines);
            this.Panel1.Controls.Add(this.GoManufacturer);
            this.Panel1.Controls.Add(this.GoDashboard);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.pictureBox3);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(277, 768);
            this.Panel1.TabIndex = 38;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnLogout.Location = new System.Drawing.Point(63, 715);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(187, 40);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.BackColor = System.Drawing.Color.White;
            this.btnSelling.FlatAppearance.BorderSize = 0;
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelling.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelling.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSelling.Location = new System.Drawing.Point(63, 542);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(187, 40);
            this.btnSelling.TabIndex = 23;
            this.btnSelling.Text = "Selling";
            this.btnSelling.UseVisualStyleBackColor = false;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // btnSellers
            // 
            this.btnSellers.BackColor = System.Drawing.Color.White;
            this.btnSellers.FlatAppearance.BorderSize = 0;
            this.btnSellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellers.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSellers.Location = new System.Drawing.Point(63, 469);
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.Size = new System.Drawing.Size(187, 40);
            this.btnSellers.TabIndex = 23;
            this.btnSellers.Text = "Sellers";
            this.btnSellers.UseVisualStyleBackColor = false;
            this.btnSellers.Click += new System.EventHandler(this.btnSellers_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.White;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnCustomers.Location = new System.Drawing.Point(63, 394);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(187, 40);
            this.btnCustomers.TabIndex = 24;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnMedicines
            // 
            this.btnMedicines.BackColor = System.Drawing.Color.White;
            this.btnMedicines.FlatAppearance.BorderSize = 0;
            this.btnMedicines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicines.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicines.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnMedicines.Location = new System.Drawing.Point(63, 321);
            this.btnMedicines.Name = "btnMedicines";
            this.btnMedicines.Size = new System.Drawing.Size(187, 40);
            this.btnMedicines.TabIndex = 25;
            this.btnMedicines.Text = "Medicines";
            this.btnMedicines.UseVisualStyleBackColor = false;
            this.btnMedicines.Click += new System.EventHandler(this.btnMedicines_Click);
            // 
            // btnManufacturer
            // 
            this.btnManufacturer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnManufacturer.FlatAppearance.BorderSize = 0;
            this.btnManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManufacturer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManufacturer.ForeColor = System.Drawing.Color.White;
            this.btnManufacturer.Location = new System.Drawing.Point(63, 246);
            this.btnManufacturer.Name = "btnManufacturer";
            this.btnManufacturer.Size = new System.Drawing.Size(187, 40);
            this.btnManufacturer.TabIndex = 26;
            this.btnManufacturer.Text = "Manufacturer";
            this.btnManufacturer.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnDashboard.Location = new System.Drawing.Point(63, 171);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(187, 40);
            this.btnDashboard.TabIndex = 27;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // GoSelling
            // 
            this.GoSelling.Image = ((System.Drawing.Image)(resources.GetObject("GoSelling.Image")));
            this.GoSelling.Location = new System.Drawing.Point(6, 537);
            this.GoSelling.Name = "GoSelling";
            this.GoSelling.Size = new System.Drawing.Size(50, 50);
            this.GoSelling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoSelling.TabIndex = 8;
            this.GoSelling.TabStop = false;
            this.GoSelling.Click += new System.EventHandler(this.GoSelling_Click);
            // 
            // GoLogout
            // 
            this.GoLogout.Image = ((System.Drawing.Image)(resources.GetObject("GoLogout.Image")));
            this.GoLogout.Location = new System.Drawing.Point(6, 710);
            this.GoLogout.Name = "GoLogout";
            this.GoLogout.Size = new System.Drawing.Size(50, 50);
            this.GoLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoLogout.TabIndex = 8;
            this.GoLogout.TabStop = false;
            this.GoLogout.Click += new System.EventHandler(this.GoLogout_Click);
            // 
            // GoSellers
            // 
            this.GoSellers.Image = ((System.Drawing.Image)(resources.GetObject("GoSellers.Image")));
            this.GoSellers.Location = new System.Drawing.Point(6, 464);
            this.GoSellers.Name = "GoSellers";
            this.GoSellers.Size = new System.Drawing.Size(50, 50);
            this.GoSellers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoSellers.TabIndex = 8;
            this.GoSellers.TabStop = false;
            this.GoSellers.Click += new System.EventHandler(this.GoSellers_Click);
            // 
            // GoCustomers
            // 
            this.GoCustomers.Image = ((System.Drawing.Image)(resources.GetObject("GoCustomers.Image")));
            this.GoCustomers.Location = new System.Drawing.Point(6, 389);
            this.GoCustomers.Name = "GoCustomers";
            this.GoCustomers.Size = new System.Drawing.Size(50, 50);
            this.GoCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoCustomers.TabIndex = 8;
            this.GoCustomers.TabStop = false;
            this.GoCustomers.Click += new System.EventHandler(this.GoCustomers_Click);
            // 
            // GoMedicines
            // 
            this.GoMedicines.Image = ((System.Drawing.Image)(resources.GetObject("GoMedicines.Image")));
            this.GoMedicines.Location = new System.Drawing.Point(6, 316);
            this.GoMedicines.Name = "GoMedicines";
            this.GoMedicines.Size = new System.Drawing.Size(50, 50);
            this.GoMedicines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoMedicines.TabIndex = 8;
            this.GoMedicines.TabStop = false;
            this.GoMedicines.Click += new System.EventHandler(this.GoMedicines_Click);
            // 
            // GoManufacturer
            // 
            this.GoManufacturer.Image = ((System.Drawing.Image)(resources.GetObject("GoManufacturer.Image")));
            this.GoManufacturer.Location = new System.Drawing.Point(6, 243);
            this.GoManufacturer.Name = "GoManufacturer";
            this.GoManufacturer.Size = new System.Drawing.Size(50, 50);
            this.GoManufacturer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoManufacturer.TabIndex = 8;
            this.GoManufacturer.TabStop = false;
            // 
            // GoDashboard
            // 
            this.GoDashboard.Image = ((System.Drawing.Image)(resources.GetObject("GoDashboard.Image")));
            this.GoDashboard.Location = new System.Drawing.Point(6, 166);
            this.GoDashboard.Name = "GoDashboard";
            this.GoDashboard.Size = new System.Drawing.Size(50, 50);
            this.GoDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoDashboard.TabIndex = 8;
            this.GoDashboard.TabStop = false;
            this.GoDashboard.Click += new System.EventHandler(this.GoDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(116, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Health Care";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // Manufecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Manufecturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manufecturer";
            ((System.ComponentModel.ISupportInitialize)(this.DGVManufecturer)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSellers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoMedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoManufacturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtManufecturerName;
        private System.Windows.Forms.DataGridView DGVManufecturer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.DateTimePicker txtJoinDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnSellers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnMedicines;
        private System.Windows.Forms.Button btnManufacturer;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox GoSelling;
        private System.Windows.Forms.PictureBox GoLogout;
        private System.Windows.Forms.PictureBox GoSellers;
        private System.Windows.Forms.PictureBox GoCustomers;
        private System.Windows.Forms.PictureBox GoMedicines;
        private System.Windows.Forms.PictureBox GoManufacturer;
        private System.Windows.Forms.PictureBox GoDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}