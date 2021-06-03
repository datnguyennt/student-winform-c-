using Bai1.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
	public partial class Form1 : Form
	{
		HoTenDBEntities db = new HoTenDBEntities();
		int IDEmp = 0;
		public Form1()
		{
			InitializeComponent();
			dtgEmployee.AutoGenerateColumns = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			loadDTGEmployee();
			loadCBB();
		}

		public void loadDTGEmployee()
		{
			var lstEmployee = (from p in db.Employee
							   join c in db.EmpType on p.EmployeeType equals c.TypeId
							   select new
							   {
								   p.EmployeeId,
								   p.Name,
								   p.Gender,
								   Sex = (p.Gender ? "Male" :"Female"),
								   p.Address,
								   p.Department,
								   p.EmployeeType,
								   c.TypeName
							   }).ToList();
			dtgEmployee.Columns[0].Visible = false;
			dtgEmployee.DataSource = lstEmployee;
		}

		public void loadCBB()
		{
			var lstEmType = db.EmpType.ToList();
			cbbEmployeeType.DataSource = lstEmType;
			cbbEmployeeType.DisplayMember = "TypeName";
			cbbEmployeeType.ValueMember = "TypeID";
		}
		private List<Employee> getData()
		{
			return db.Employee.ToList();
		}
		private void ClearData()
		{
			txtAddress.Text = "";
			txtName.Text = "";
			txtDepartment.Text = "";
			IDEmp = 0;
		}

		private void dtgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtName.Text = dtgEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtAddress.Text = dtgEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtDepartment.Text = dtgEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
			string gender = dtgEmployee.Rows[e.RowIndex].Cells[7].Value.ToString();
			if (gender == "True")
			{
				rdmMale.Checked = true;
			}
			else
			{
				rdbFemale.Checked = true;
			}
			cbbEmployeeType.SelectedValue = dtgEmployee.Rows[e.RowIndex].Cells[6].Value;
			IDEmp = Int32.Parse(dtgEmployee.Rows[e.RowIndex].Cells[0].Value.ToString());
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (IDEmp == 0)
				{
					Employee em = new Employee();
					em.Name = txtName.Text.Trim();
					em.Address = txtAddress.Text.Trim();
					em.Department = txtDepartment.Text.Trim();

					bool value = true;
					bool isChecked = rdmMale.Checked;
					if (isChecked)
						value = true;
					else
						value = false;
					em.Gender = value;

					em.EmployeeType = cbbEmployeeType.SelectedIndex + 1;

					db.Employee.Add(em);
					db.SaveChanges();
					ClearData();
					loadDTGEmployee();
					MessageBox.Show("Save success");
				}
				else
				{
					Employee emp = db.Employee.First(x => x.EmployeeId.Equals(IDEmp));
					emp.Name = txtName.Text.Trim();
					emp.Address = txtAddress.Text.Trim();
					emp.Department = txtDepartment.Text.Trim();

					bool value = true;
					bool isChecked = rdmMale.Checked;
					if (isChecked)
						value = true;
					else
						value = false;
					emp.Gender = value;

					emp.EmployeeType = cbbEmployeeType.SelectedIndex + 1;
					db.SaveChanges();
					ClearData();
					loadDTGEmployee();
					MessageBox.Show("Update success");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex.Message, "Warning",
	MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (IDEmp == 0)
			{
				MessageBox.Show("Selected employee to delete!!", "Warning",
	MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					Employee emp = db.Employee.First(x => x.EmployeeId.Equals(IDEmp));
					db.Employee.Remove(emp);
					db.SaveChanges();
					loadDTGEmployee();
					ClearData();
					MessageBox.Show("Deleted Successfully");
				}
			}

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearData();
		}
	}
}
