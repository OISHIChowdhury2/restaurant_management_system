namespace projectoop
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.panelSDSearchEditDelete = new System.Windows.Forms.Panel();
            this.lblUserAccID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxShowDetailsSearch = new System.Windows.Forms.TextBox();
            this.btnSDDelete = new System.Windows.Forms.Button();
            this.btnSDEdit = new System.Windows.Forms.Button();
            this.lblShowDetails = new System.Windows.Forms.Label();
            this.panelManagerRegForm = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.c1 = new System.Windows.Forms.ComboBox();
            this.lblMGender = new System.Windows.Forms.Label();
            this.btnMRegister = new System.Windows.Forms.Button();
            this.lblMJoiningDate = new System.Windows.Forms.Label();
            this.txtboxMAdd = new System.Windows.Forms.TextBox();
            this.txtboxMPhone = new System.Windows.Forms.TextBox();
            this.txtboxMAccID = new System.Windows.Forms.TextBox();
            this.txtboxMName = new System.Windows.Forms.TextBox();
            this.lblMAddress = new System.Windows.Forms.Label();
            this.lblMPhone = new System.Windows.Forms.Label();
            this.lblMDOB = new System.Windows.Forms.Label();
            this.lblMAccountID = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.lblManagerRegForm = new System.Windows.Forms.Label();
            this.dataGVUinfo = new System.Windows.Forms.DataGridView();
            this.totalFromTable1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectoopDataSet4 = new projectoop.projectoopDataSet4();
            this.lblUserinfo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joitdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regmgBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectoopDataSet5 = new projectoop.projectoopDataSet5();
            this.projectoopDataSet1 = new projectoop.projectoopDataSet1();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectoopDataSet3 = new projectoop.projectoopDataSet3();
            this.regmgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regmgTableAdapter = new projectoop.projectoopDataSet1TableAdapters.regmgTableAdapter();
            this.orderTableAdapter = new projectoop.projectoopDataSet3TableAdapters.orderTableAdapter();
            this.totalTableAdapter = new projectoop.projectoopDataSet4TableAdapters.totalTableAdapter();
            this.regmgTableAdapter1 = new projectoop.projectoopDataSet5TableAdapters.regmgTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSDSearchEditDelete.SuspendLayout();
            this.panelManagerRegForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectoopDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regmgBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectoopDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectoopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectoopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regmgBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSDSearchEditDelete
            // 
            this.panelSDSearchEditDelete.BackColor = System.Drawing.Color.Black;
            this.panelSDSearchEditDelete.Controls.Add(this.lblUserAccID);
            this.panelSDSearchEditDelete.Controls.Add(this.label2);
            this.panelSDSearchEditDelete.Controls.Add(this.txtboxShowDetailsSearch);
            this.panelSDSearchEditDelete.Controls.Add(this.btnSDDelete);
            this.panelSDSearchEditDelete.Controls.Add(this.btnSDEdit);
            this.panelSDSearchEditDelete.Location = new System.Drawing.Point(336, -1);
            this.panelSDSearchEditDelete.Name = "panelSDSearchEditDelete";
            this.panelSDSearchEditDelete.Size = new System.Drawing.Size(302, 118);
            this.panelSDSearchEditDelete.TabIndex = 1;
            // 
            // lblUserAccID
            // 
            this.lblUserAccID.AutoSize = true;
            this.lblUserAccID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAccID.ForeColor = System.Drawing.Color.Yellow;
            this.lblUserAccID.Location = new System.Drawing.Point(11, 84);
            this.lblUserAccID.Name = "lblUserAccID";
            this.lblUserAccID.Size = new System.Drawing.Size(48, 17);
            this.lblUserAccID.TabIndex = 5;
            this.lblUserAccID.Text = "Acc ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(115, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "USER";
            // 
            // txtboxShowDetailsSearch
            // 
            this.txtboxShowDetailsSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtboxShowDetailsSearch.Location = new System.Drawing.Point(79, 79);
            this.txtboxShowDetailsSearch.Name = "txtboxShowDetailsSearch";
            this.txtboxShowDetailsSearch.Size = new System.Drawing.Size(210, 25);
            this.txtboxShowDetailsSearch.TabIndex = 3;
            this.txtboxShowDetailsSearch.TextChanged += new System.EventHandler(this.txtboxShowDetailsSearch_TextChanged_1);
            // 
            // btnSDDelete
            // 
            this.btnSDDelete.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSDDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSDDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSDDelete.Location = new System.Drawing.Point(207, 37);
            this.btnSDDelete.Name = "btnSDDelete";
            this.btnSDDelete.Size = new System.Drawing.Size(80, 30);
            this.btnSDDelete.TabIndex = 2;
            this.btnSDDelete.Text = "Delete";
            this.btnSDDelete.UseVisualStyleBackColor = false;
            this.btnSDDelete.Click += new System.EventHandler(this.btnSDDelete_Click);
            // 
            // btnSDEdit
            // 
            this.btnSDEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSDEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSDEdit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSDEdit.Location = new System.Drawing.Point(14, 37);
            this.btnSDEdit.Name = "btnSDEdit";
            this.btnSDEdit.Size = new System.Drawing.Size(80, 30);
            this.btnSDEdit.TabIndex = 1;
            this.btnSDEdit.Text = "Edit";
            this.btnSDEdit.UseVisualStyleBackColor = false;
            this.btnSDEdit.Click += new System.EventHandler(this.btnSDEdit_Click);
            // 
            // lblShowDetails
            // 
            this.lblShowDetails.AutoSize = true;
            this.lblShowDetails.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDetails.Location = new System.Drawing.Point(332, 120);
            this.lblShowDetails.Name = "lblShowDetails";
            this.lblShowDetails.Size = new System.Drawing.Size(112, 18);
            this.lblShowDetails.TabIndex = 3;
            this.lblShowDetails.Text = "SHOW DETAILS";
            // 
            // panelManagerRegForm
            // 
            this.panelManagerRegForm.BackColor = System.Drawing.Color.Black;
            this.panelManagerRegForm.Controls.Add(this.textBox2);
            this.panelManagerRegForm.Controls.Add(this.textBox1);
            this.panelManagerRegForm.Controls.Add(this.c1);
            this.panelManagerRegForm.Controls.Add(this.lblMGender);
            this.panelManagerRegForm.Controls.Add(this.btnMRegister);
            this.panelManagerRegForm.Controls.Add(this.lblMJoiningDate);
            this.panelManagerRegForm.Controls.Add(this.txtboxMAdd);
            this.panelManagerRegForm.Controls.Add(this.txtboxMPhone);
            this.panelManagerRegForm.Controls.Add(this.txtboxMAccID);
            this.panelManagerRegForm.Controls.Add(this.txtboxMName);
            this.panelManagerRegForm.Controls.Add(this.lblMAddress);
            this.panelManagerRegForm.Controls.Add(this.lblMPhone);
            this.panelManagerRegForm.Controls.Add(this.lblMDOB);
            this.panelManagerRegForm.Controls.Add(this.lblMAccountID);
            this.panelManagerRegForm.Controls.Add(this.lblMName);
            this.panelManagerRegForm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelManagerRegForm.Location = new System.Drawing.Point(1, 57);
            this.panelManagerRegForm.Name = "panelManagerRegForm";
            this.panelManagerRegForm.Size = new System.Drawing.Size(329, 461);
            this.panelManagerRegForm.TabIndex = 10;
            this.panelManagerRegForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(100, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 22);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(100, 369);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 22);
            this.textBox1.TabIndex = 17;
            // 
            // c1
            // 
            this.c1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.c1.FormattingEnabled = true;
            this.c1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.c1.Location = new System.Drawing.Point(100, 211);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(220, 27);
            this.c1.TabIndex = 16;
            // 
            // lblMGender
            // 
            this.lblMGender.AutoSize = true;
            this.lblMGender.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMGender.Location = new System.Drawing.Point(9, 217);
            this.lblMGender.Name = "lblMGender";
            this.lblMGender.Size = new System.Drawing.Size(62, 19);
            this.lblMGender.TabIndex = 15;
            this.lblMGender.Text = "Gender";
            // 
            // btnMRegister
            // 
            this.btnMRegister.BackColor = System.Drawing.Color.Green;
            this.btnMRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMRegister.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMRegister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMRegister.Location = new System.Drawing.Point(80, 399);
            this.btnMRegister.Name = "btnMRegister";
            this.btnMRegister.Size = new System.Drawing.Size(151, 45);
            this.btnMRegister.TabIndex = 14;
            this.btnMRegister.Text = "REGISTER";
            this.btnMRegister.UseVisualStyleBackColor = false;
            this.btnMRegister.Click += new System.EventHandler(this.btnMRegister_Click);
            // 
            // lblMJoiningDate
            // 
            this.lblMJoiningDate.AutoSize = true;
            this.lblMJoiningDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMJoiningDate.Location = new System.Drawing.Point(3, 353);
            this.lblMJoiningDate.Name = "lblMJoiningDate";
            this.lblMJoiningDate.Size = new System.Drawing.Size(62, 38);
            this.lblMJoiningDate.TabIndex = 10;
            this.lblMJoiningDate.Text = "Joining \r\nDate";
            // 
            // txtboxMAdd
            // 
            this.txtboxMAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtboxMAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMAdd.Location = new System.Drawing.Point(100, 260);
            this.txtboxMAdd.Multiline = true;
            this.txtboxMAdd.Name = "txtboxMAdd";
            this.txtboxMAdd.Size = new System.Drawing.Size(220, 83);
            this.txtboxMAdd.TabIndex = 9;
            // 
            // txtboxMPhone
            // 
            this.txtboxMPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtboxMPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxMPhone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMPhone.Location = new System.Drawing.Point(100, 167);
            this.txtboxMPhone.Name = "txtboxMPhone";
            this.txtboxMPhone.Size = new System.Drawing.Size(220, 22);
            this.txtboxMPhone.TabIndex = 8;
            // 
            // txtboxMAccID
            // 
            this.txtboxMAccID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtboxMAccID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxMAccID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMAccID.Location = new System.Drawing.Point(100, 77);
            this.txtboxMAccID.Name = "txtboxMAccID";
            this.txtboxMAccID.Size = new System.Drawing.Size(220, 22);
            this.txtboxMAccID.TabIndex = 6;
            // 
            // txtboxMName
            // 
            this.txtboxMName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtboxMName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMName.Location = new System.Drawing.Point(100, 34);
            this.txtboxMName.Name = "txtboxMName";
            this.txtboxMName.Size = new System.Drawing.Size(220, 22);
            this.txtboxMName.TabIndex = 5;
            // 
            // lblMAddress
            // 
            this.lblMAddress.AutoSize = true;
            this.lblMAddress.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAddress.Location = new System.Drawing.Point(9, 260);
            this.lblMAddress.Name = "lblMAddress";
            this.lblMAddress.Size = new System.Drawing.Size(61, 19);
            this.lblMAddress.TabIndex = 4;
            this.lblMAddress.Text = "Address";
            // 
            // lblMPhone
            // 
            this.lblMPhone.AutoSize = true;
            this.lblMPhone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPhone.Location = new System.Drawing.Point(9, 171);
            this.lblMPhone.Name = "lblMPhone";
            this.lblMPhone.Size = new System.Drawing.Size(53, 19);
            this.lblMPhone.TabIndex = 3;
            this.lblMPhone.Text = "Phone";
            // 
            // lblMDOB
            // 
            this.lblMDOB.AutoSize = true;
            this.lblMDOB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDOB.Location = new System.Drawing.Point(9, 128);
            this.lblMDOB.Name = "lblMDOB";
            this.lblMDOB.Size = new System.Drawing.Size(39, 19);
            this.lblMDOB.TabIndex = 2;
            this.lblMDOB.Text = "DOB";
            // 
            // lblMAccountID
            // 
            this.lblMAccountID.AutoSize = true;
            this.lblMAccountID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAccountID.Location = new System.Drawing.Point(9, 73);
            this.lblMAccountID.Name = "lblMAccountID";
            this.lblMAccountID.Size = new System.Drawing.Size(72, 38);
            this.lblMAccountID.TabIndex = 1;
            this.lblMAccountID.Text = "Account \r\nID";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMName.Location = new System.Drawing.Point(9, 34);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(51, 19);
            this.lblMName.TabIndex = 0;
            this.lblMName.Text = "Name";
            // 
            // lblManagerRegForm
            // 
            this.lblManagerRegForm.AutoSize = true;
            this.lblManagerRegForm.BackColor = System.Drawing.Color.Transparent;
            this.lblManagerRegForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerRegForm.Location = new System.Drawing.Point(10, 16);
            this.lblManagerRegForm.Name = "lblManagerRegForm";
            this.lblManagerRegForm.Size = new System.Drawing.Size(245, 23);
            this.lblManagerRegForm.TabIndex = 11;
            this.lblManagerRegForm.Text = "Manger Registration Form";
            // 
            // dataGVUinfo
            // 
            this.dataGVUinfo.AllowUserToAddRows = false;
            this.dataGVUinfo.AllowUserToDeleteRows = false;
            this.dataGVUinfo.AutoGenerateColumns = false;
            this.dataGVUinfo.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGVUinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVUinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.totalFromTable1DataGridViewTextBoxColumn});
            this.dataGVUinfo.DataSource = this.totalBindingSource;
            this.dataGVUinfo.Location = new System.Drawing.Point(657, 44);
            this.dataGVUinfo.Name = "dataGVUinfo";
            this.dataGVUinfo.RowTemplate.Height = 24;
            this.dataGVUinfo.Size = new System.Drawing.Size(146, 181);
            this.dataGVUinfo.TabIndex = 14;
            // 
            // totalFromTable1DataGridViewTextBoxColumn
            // 
            this.totalFromTable1DataGridViewTextBoxColumn.DataPropertyName = "TotalFromTable1";
            this.totalFromTable1DataGridViewTextBoxColumn.HeaderText = "TotalFromTable1";
            this.totalFromTable1DataGridViewTextBoxColumn.Name = "totalFromTable1DataGridViewTextBoxColumn";
            // 
            // totalBindingSource
            // 
            this.totalBindingSource.DataMember = "total";
            this.totalBindingSource.DataSource = this.projectoopDataSet4;
            // 
            // projectoopDataSet4
            // 
            this.projectoopDataSet4.DataSetName = "projectoopDataSet4";
            this.projectoopDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblUserinfo
            // 
            this.lblUserinfo.Location = new System.Drawing.Point(629, 19);
            this.lblUserinfo.Name = "lblUserinfo";
            this.lblUserinfo.Size = new System.Drawing.Size(204, 22);
            this.lblUserinfo.TabIndex = 0;
            this.lblUserinfo.Text = "Order information Table 1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.acidDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.joitdtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.regmgBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(335, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(303, 165);
            this.dataGridView1.TabIndex = 15;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // acidDataGridViewTextBoxColumn
            // 
            this.acidDataGridViewTextBoxColumn.DataPropertyName = "acid";
            this.acidDataGridViewTextBoxColumn.HeaderText = "acid";
            this.acidDataGridViewTextBoxColumn.Name = "acidDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // joitdtDataGridViewTextBoxColumn
            // 
            this.joitdtDataGridViewTextBoxColumn.DataPropertyName = "joitdt";
            this.joitdtDataGridViewTextBoxColumn.HeaderText = "joitdt";
            this.joitdtDataGridViewTextBoxColumn.Name = "joitdtDataGridViewTextBoxColumn";
            // 
            // regmgBindingSource1
            // 
            this.regmgBindingSource1.DataMember = "regmg";
            this.regmgBindingSource1.DataSource = this.projectoopDataSet5;
            // 
            // projectoopDataSet5
            // 
            this.projectoopDataSet5.DataSetName = "projectoopDataSet5";
            this.projectoopDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectoopDataSet1
            // 
            this.projectoopDataSet1.DataSetName = "projectoopDataSet1";
            this.projectoopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.projectoopDataSet3;
            // 
            // projectoopDataSet3
            // 
            this.projectoopDataSet3.DataSetName = "projectoopDataSet3";
            this.projectoopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regmgBindingSource
            // 
            this.regmgBindingSource.DataMember = "regmg";
            this.regmgBindingSource.DataSource = this.projectoopDataSet1;
            // 
            // regmgTableAdapter
            // 
            this.regmgTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // totalTableAdapter
            // 
            this.totalTableAdapter.ClearBeforeFill = true;
            // 
            // regmgTableAdapter1
            // 
            this.regmgTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(717, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(853, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblUserinfo);
            this.Controls.Add(this.dataGVUinfo);
            this.Controls.Add(this.lblManagerRegForm);
            this.Controls.Add(this.panelManagerRegForm);
            this.Controls.Add(this.lblShowDetails);
            this.Controls.Add(this.panelSDSearchEditDelete);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Admin";
            this.Load += new System.EventHandler(this.Form5_Load_2);
            this.panelSDSearchEditDelete.ResumeLayout(false);
            this.panelSDSearchEditDelete.PerformLayout();
            this.panelManagerRegForm.ResumeLayout(false);
            this.panelManagerRegForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectoopDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regmgBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectoopDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectoopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectoopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regmgBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSDSearchEditDelete;
        private System.Windows.Forms.Button btnSDDelete;
        private System.Windows.Forms.Button btnSDEdit;
        private System.Windows.Forms.Label lblShowDetails;
        private System.Windows.Forms.Panel panelManagerRegForm;
        private System.Windows.Forms.Label lblManagerRegForm;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblMAddress;
        private System.Windows.Forms.Label lblMPhone;
        private System.Windows.Forms.Label lblMDOB;
        private System.Windows.Forms.Label lblMAccountID;
        private System.Windows.Forms.Button btnMRegister;
        private System.Windows.Forms.Label lblMJoiningDate;
        private System.Windows.Forms.TextBox txtboxMAdd;
        private System.Windows.Forms.TextBox txtboxMPhone;
        private System.Windows.Forms.TextBox txtboxMAccID;
        private System.Windows.Forms.TextBox txtboxMName;
        private System.Windows.Forms.TextBox txtboxShowDetailsSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserAccID;
        private System.Windows.Forms.Label lblMGender;
        private System.Windows.Forms.ComboBox c1;
        private System.Windows.Forms.DataGridView dataGVUinfo;
        private System.Windows.Forms.Label lblUserinfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private projectoopDataSet1 projectoopDataSet1;
        private System.Windows.Forms.BindingSource regmgBindingSource;
        private projectoopDataSet1TableAdapters.regmgTableAdapter regmgTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joitdtDataGridViewTextBoxColumn;
        private projectoopDataSet3 projectoopDataSet3;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private projectoopDataSet3TableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private projectoopDataSet4 projectoopDataSet4;
        private System.Windows.Forms.BindingSource totalBindingSource;
        private projectoopDataSet4TableAdapters.totalTableAdapter totalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFromTable1DataGridViewTextBoxColumn;
        private projectoopDataSet5 projectoopDataSet5;
        private System.Windows.Forms.BindingSource regmgBindingSource1;
        private projectoopDataSet5TableAdapters.regmgTableAdapter regmgTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}

