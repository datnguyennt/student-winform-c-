
namespace Bai1
{
	partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pnSex = new System.Windows.Forms.Panel();
			this.rdbFemale = new System.Windows.Forms.RadioButton();
			this.rdmMale = new System.Windows.Forms.RadioButton();
			this.cbbEmployeeType = new System.Windows.Forms.ComboBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtDepartment = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.dtgEmployee = new System.Windows.Forms.DataGridView();
			this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmployeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.pnSex.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pnSex);
			this.groupBox1.Controls.Add(this.cbbEmployeeType);
			this.groupBox1.Controls.Add(this.txtAddress);
			this.groupBox1.Controls.Add(this.txtDepartment);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(3, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1098, 275);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Employee Information";
			// 
			// pnSex
			// 
			this.pnSex.Controls.Add(this.rdbFemale);
			this.pnSex.Controls.Add(this.rdmMale);
			this.pnSex.Location = new System.Drawing.Point(160, 189);
			this.pnSex.Name = "pnSex";
			this.pnSex.Size = new System.Drawing.Size(296, 58);
			this.pnSex.TabIndex = 3;
			// 
			// rdbFemale
			// 
			this.rdbFemale.AutoSize = true;
			this.rdbFemale.Location = new System.Drawing.Point(143, 16);
			this.rdbFemale.Name = "rdbFemale";
			this.rdbFemale.Size = new System.Drawing.Size(89, 26);
			this.rdbFemale.TabIndex = 0;
			this.rdbFemale.TabStop = true;
			this.rdbFemale.Text = "Female";
			this.rdbFemale.UseVisualStyleBackColor = true;
			// 
			// rdmMale
			// 
			this.rdmMale.AutoSize = true;
			this.rdmMale.Location = new System.Drawing.Point(27, 16);
			this.rdmMale.Name = "rdmMale";
			this.rdmMale.Size = new System.Drawing.Size(72, 26);
			this.rdmMale.TabIndex = 0;
			this.rdmMale.TabStop = true;
			this.rdmMale.Text = "Male";
			this.rdmMale.UseVisualStyleBackColor = true;
			// 
			// cbbEmployeeType
			// 
			this.cbbEmployeeType.FormattingEnabled = true;
			this.cbbEmployeeType.Location = new System.Drawing.Point(688, 185);
			this.cbbEmployeeType.Name = "cbbEmployeeType";
			this.cbbEmployeeType.Size = new System.Drawing.Size(306, 30);
			this.cbbEmployeeType.TabIndex = 3;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(688, 49);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(391, 111);
			this.txtAddress.TabIndex = 2;
			// 
			// txtDepartment
			// 
			this.txtDepartment.Location = new System.Drawing.Point(160, 123);
			this.txtDepartment.Name = "txtDepartment";
			this.txtDepartment.Size = new System.Drawing.Size(306, 30);
			this.txtDepartment.TabIndex = 1;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(160, 49);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(306, 30);
			this.txtName.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(519, 189);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(139, 22);
			this.label5.TabIndex = 0;
			this.label5.Text = "Employee Type:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 189);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 22);
			this.label3.TabIndex = 0;
			this.label3.Text = "Sex:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 22);
			this.label2.TabIndex = 0;
			this.label2.Text = "Department:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(519, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 22);
			this.label4.TabIndex = 0;
			this.label4.Text = "Address";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Location = new System.Drawing.Point(282, 290);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(513, 90);
			this.panel1.TabIndex = 1;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(371, 27);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(105, 40);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.ForeColor = System.Drawing.Color.White;
			this.btnClear.Location = new System.Drawing.Point(214, 27);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(105, 40);
			this.btnClear.TabIndex = 1;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(43, 27);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(105, 40);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// dtgEmployee
			// 
			this.dtgEmployee.BackgroundColor = System.Drawing.Color.White;
			this.dtgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.FullName,
            this.Address,
            this.Gender,
            this.EmployeeType,
            this.Department,
            this.TypeName,
            this.Sex});
			this.dtgEmployee.Location = new System.Drawing.Point(7, 416);
			this.dtgEmployee.Name = "dtgEmployee";
			this.dtgEmployee.RowHeadersWidth = 51;
			this.dtgEmployee.RowTemplate.Height = 24;
			this.dtgEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgEmployee.Size = new System.Drawing.Size(1094, 253);
			this.dtgEmployee.TabIndex = 2;
			this.dtgEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmployee_CellClick);
			// 
			// EmployeeId
			// 
			this.EmployeeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.EmployeeId.DataPropertyName = "EmployeeId";
			this.EmployeeId.HeaderText = "EmployeeId";
			this.EmployeeId.MinimumWidth = 6;
			this.EmployeeId.Name = "EmployeeId";
			// 
			// FullName
			// 
			this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FullName.DataPropertyName = "Name";
			this.FullName.HeaderText = "FullName";
			this.FullName.MinimumWidth = 6;
			this.FullName.Name = "FullName";
			// 
			// Address
			// 
			this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Address.DataPropertyName = "Address";
			this.Address.HeaderText = "Address";
			this.Address.MinimumWidth = 6;
			this.Address.Name = "Address";
			// 
			// Gender
			// 
			this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Gender.DataPropertyName = "Sex";
			this.Gender.HeaderText = "Gender";
			this.Gender.MinimumWidth = 6;
			this.Gender.Name = "Gender";
			// 
			// EmployeeType
			// 
			this.EmployeeType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.EmployeeType.DataPropertyName = "TypeName";
			this.EmployeeType.HeaderText = "EmployeeType";
			this.EmployeeType.MinimumWidth = 6;
			this.EmployeeType.Name = "EmployeeType";
			// 
			// Department
			// 
			this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Department.DataPropertyName = "Department";
			this.Department.HeaderText = "Department";
			this.Department.MinimumWidth = 6;
			this.Department.Name = "Department";
			this.Department.Visible = false;
			this.Department.Width = 125;
			// 
			// TypeName
			// 
			this.TypeName.DataPropertyName = "EmployeeType";
			this.TypeName.HeaderText = "TypeName";
			this.TypeName.MinimumWidth = 6;
			this.TypeName.Name = "TypeName";
			this.TypeName.Visible = false;
			this.TypeName.Width = 125;
			// 
			// Sex
			// 
			this.Sex.DataPropertyName = "Gender";
			this.Sex.HeaderText = "Sex";
			this.Sex.MinimumWidth = 6;
			this.Sex.Name = "Sex";
			this.Sex.Visible = false;
			this.Sex.Width = 125;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1112, 679);
			this.Controls.Add(this.dtgEmployee);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.pnSex.ResumeLayout(false);
			this.pnSex.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel pnSex;
		private System.Windows.Forms.RadioButton rdbFemale;
		private System.Windows.Forms.RadioButton rdmMale;
		private System.Windows.Forms.ComboBox cbbEmployeeType;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtDepartment;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DataGridView dtgEmployee;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
		private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Address;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeType;
		private System.Windows.Forms.DataGridViewTextBoxColumn Department;
		private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
	}
}

