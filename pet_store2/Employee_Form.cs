using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet_store2
{
    public partial class Employee_Form : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=71L643con!;persistsecurityinfo=True;database=pet_store2");
        public Employee_Form()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pet_store2DataSet);

        }

        private void Employee_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pet_store2DataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.pet_store2DataSet.employee);

        }

        private void submit_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee` (`Employ_ID`, `Employ_FName`, `Employ_LNmae`, `Employ_JobTitle`, `Employ_Salary`, `Employ_DOB`) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", db.getConnection());
            command.Parameters.AddWithValue("@p1", 23456).MySqlDbType = MySqlDbType.Int32;
            command.Parameters.Add("@p2", MySqlDbType.VarChar).Value = employ_FNameRichTextBox.Text;
            command.Parameters.Add("@p3", MySqlDbType.VarChar).Value = employ_LNmaeRichTextBox.Text;
            command.Parameters.Add("@p4", MySqlDbType.VarChar).Value = employ_JobTitleRichTextBox.Text;
            command.Parameters.Add("@p5", MySqlDbType.VarChar).Value = employ_SalaryTextBox.Text;
            command.Parameters.Add("@p6", MySqlDbType.VarChar).Value = employ_DOBTextBox.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account Created");
            }
            else
            {
                MessageBox.Show("ERROR");
            }


            db.closeConnection();
        }
    }
}
