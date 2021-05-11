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
    public partial class Pet_Form : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=71L643con!;persistsecurityinfo=True;database=pet_store2");
        public Pet_Form()
        {
            InitializeComponent();
        }

        private void petsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.petsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pet_store2DataSet);

        }

        private void Pet_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pet_store2DataSet.pets' table. You can move, or remove it, as needed.
            this.petsTableAdapter.Fill(this.pet_store2DataSet.pets);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `pets` (`Pet_FName`, `Pet_Type`, `Pet_Nutrition`, `Pet_Behavior`, `Pet_ID`, `C_ID`) VALUES (@p1, @p3, @p4, @p5, @p6, @p7)", db.getConnection());
            command.Parameters.Add("@p1", MySqlDbType.VarChar).Value = pet_FNameRichTextBox.Text;
            
            command.Parameters.Add("@p3", MySqlDbType.VarChar).Value = pet_TypeRichTextBox.Text;
            command.Parameters.Add("@p4", MySqlDbType.VarChar).Value = pet_NutritionTextBox.Text;
            command.Parameters.Add("@p5", MySqlDbType.VarChar).Value = pet_BehaviorRichTextBox.Text;
            command.Parameters.AddWithValue("@p6", 23456).MySqlDbType = MySqlDbType.Int32;
            command.Parameters.Add("@p7", MySqlDbType.VarChar).Value = c_IDTextBox.Text;
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

