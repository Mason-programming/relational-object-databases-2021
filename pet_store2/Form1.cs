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
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=71L643con!;persistsecurityinfo=True;database=pet_store2");
        public Form1()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pet_store2DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            // TODO: This line of code loads data into the 'pet_store2DataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.pet_store2DataSet.customer);

        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void c_FNameRichTextBox_Enter(object sender, EventArgs e)
        {
            string C_FName = c_FNameRichTextBox.Text;
            if(C_FName.Equals("Stacy"))
            {
                c_FNameRichTextBox.Text = " ";
          
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `customer` (`C_FName`, `C_LName`, `C_ID`, `C_PhoneNum`, `C_Address`) VALUES (@p1, @p2, @p3, @p4, @p5)", db.getConnection());
            command.Parameters.Add("@p1", MySqlDbType.VarChar).Value = c_FNameRichTextBox.Text;
            command.Parameters.Add("@p2", MySqlDbType.VarChar).Value = c_LNameRichTextBox.Text;
            command.Parameters.Add("@p4", MySqlDbType.VarChar).Value = c_PhoneNumTextBox.Text;
            command.Parameters.Add("@p5", MySqlDbType.VarChar).Value = c_PhoneNumTextBox.Text;
            command.Parameters.Add("@p3", MySqlDbType.VarChar).Value = c_IDTextBox.Text;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account Created");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
           

            db.closeConnection();
        }

        private void c_PhoneNumLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
