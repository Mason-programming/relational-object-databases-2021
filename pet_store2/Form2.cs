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
    public partial class Form2 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=71L643con!;persistsecurityinfo=True;database=pet_store2");
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM pet_store2DataSet.customer", connection);
                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "customer");
             
                connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void supplier_has_productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplier_has_productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pet_store2DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pet_store2DataSet.pets' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
