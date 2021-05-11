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

    public partial class supplier_form : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=71L643con!;persistsecurityinfo=True;database=pet_store2");
        public supplier_form()
        {
            InitializeComponent();
        }

        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pet_store2DataSet);

        }

        private void supplier_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pet_store2DataSet.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.pet_store2DataSet.supplier);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `supplier` (`Sup_Name`, `Sup_PhoneNum`, `Sup_Type`) VALUES (@p1, @p2, @p3)", db.getConnection());
            command.Parameters.Add("@p1", MySqlDbType.VarChar).Value = sup_NameRichTextBox.Text;
            command.Parameters.Add("@p2", MySqlDbType.VarChar).Value = sup_PhoneNumTextBox.Text;
            command.Parameters.Add("@p3", MySqlDbType.VarChar).Value = sup_TypeRichTextBox.Text;
            

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
