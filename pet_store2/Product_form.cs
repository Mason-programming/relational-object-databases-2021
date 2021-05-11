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
    public partial class Product_form : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=71L643con!;persistsecurityinfo=True;database=pet_store2");
        public Product_form()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pet_store2DataSet);

        }

        private void Product_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pet_store2DataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.pet_store2DataSet.products);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `products` (`Product_ID`, `Product_Name`, `Product_Type`, `Store_price`, `Product_stock`) VALUES (@p1, @p2, @p3, @p4, @p5)", db.getConnection());
            command.Parameters.Add("@p1", MySqlDbType.VarChar).Value = product_IDTextBox.Text;
            command.Parameters.Add("@p2", MySqlDbType.VarChar).Value = product_NameRichTextBox.Text;
            command.Parameters.Add("@p3", MySqlDbType.VarChar).Value = product_TypeRichTextBox.Text;
            command.Parameters.Add("@p4", MySqlDbType.VarChar).Value = store_priceTextBox.Text;
            command.Parameters.Add("@p5", MySqlDbType.VarChar).Value = product_stockTextBox.Text;

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
