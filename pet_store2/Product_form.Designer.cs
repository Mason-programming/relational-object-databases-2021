
namespace pet_store2
{
    partial class Product_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_form));
            System.Windows.Forms.Label product_IDLabel;
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label product_TypeLabel;
            System.Windows.Forms.Label store_priceLabel;
            System.Windows.Forms.Label product_stockLabel;
            this.pet_store2DataSet = new pet_store2.pet_store2DataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new pet_store2.pet_store2DataSetTableAdapters.productsTableAdapter();
            this.tableAdapterManager = new pet_store2.pet_store2DataSetTableAdapters.TableAdapterManager();
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.product_IDTextBox = new System.Windows.Forms.TextBox();
            this.product_NameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.product_TypeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.store_priceTextBox = new System.Windows.Forms.TextBox();
            this.product_stockTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            product_IDLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            product_TypeLabel = new System.Windows.Forms.Label();
            store_priceLabel = new System.Windows.Forms.Label();
            product_stockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pet_store2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pet_store2DataSet
            // 
            this.pet_store2DataSet.DataSetName = "pet_store2DataSet";
            this.pet_store2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.pet_store2DataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customer_has_productsTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.employees__use_productsTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.petsTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.supplier_has_productsTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = pet_store2.pet_store2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productsBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productsBindingNavigatorSaveItem});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productsBindingNavigator.Size = new System.Drawing.Size(914, 42);
            this.productsBindingNavigator.TabIndex = 0;
            this.productsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 19);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 32);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsBindingNavigatorSaveItem.Image")));
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.productsBindingNavigatorSaveItem.Text = "Save Data";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click);
            // 
            // product_IDLabel
            // 
            product_IDLabel.AutoSize = true;
            product_IDLabel.Location = new System.Drawing.Point(49, 113);
            product_IDLabel.Name = "product_IDLabel";
            product_IDLabel.Size = new System.Drawing.Size(118, 25);
            product_IDLabel.TabIndex = 1;
            product_IDLabel.Text = "Product ID:";
            // 
            // product_IDTextBox
            // 
            this.product_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Product_ID", true));
            this.product_IDTextBox.Location = new System.Drawing.Point(209, 110);
            this.product_IDTextBox.Name = "product_IDTextBox";
            this.product_IDTextBox.Size = new System.Drawing.Size(615, 31);
            this.product_IDTextBox.TabIndex = 2;
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(49, 160);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(154, 25);
            product_NameLabel.TabIndex = 3;
            product_NameLabel.Text = "Product Name:";
            // 
            // product_NameRichTextBox
            // 
            this.product_NameRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Product_Name", true));
            this.product_NameRichTextBox.Location = new System.Drawing.Point(209, 160);
            this.product_NameRichTextBox.Name = "product_NameRichTextBox";
            this.product_NameRichTextBox.Size = new System.Drawing.Size(615, 40);
            this.product_NameRichTextBox.TabIndex = 4;
            this.product_NameRichTextBox.Text = "";
            // 
            // product_TypeLabel
            // 
            product_TypeLabel.AutoSize = true;
            product_TypeLabel.Location = new System.Drawing.Point(49, 239);
            product_TypeLabel.Name = "product_TypeLabel";
            product_TypeLabel.Size = new System.Drawing.Size(146, 25);
            product_TypeLabel.TabIndex = 5;
            product_TypeLabel.Text = "Product Type:";
            // 
            // product_TypeRichTextBox
            // 
            this.product_TypeRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Product_Type", true));
            this.product_TypeRichTextBox.Location = new System.Drawing.Point(209, 239);
            this.product_TypeRichTextBox.Name = "product_TypeRichTextBox";
            this.product_TypeRichTextBox.Size = new System.Drawing.Size(615, 38);
            this.product_TypeRichTextBox.TabIndex = 6;
            this.product_TypeRichTextBox.Text = "";
            // 
            // store_priceLabel
            // 
            store_priceLabel.AutoSize = true;
            store_priceLabel.Location = new System.Drawing.Point(49, 316);
            store_priceLabel.Name = "store_priceLabel";
            store_priceLabel.Size = new System.Drawing.Size(122, 25);
            store_priceLabel.TabIndex = 7;
            store_priceLabel.Text = "Store price:";
            // 
            // store_priceTextBox
            // 
            this.store_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Store_price", true));
            this.store_priceTextBox.Location = new System.Drawing.Point(209, 316);
            this.store_priceTextBox.Name = "store_priceTextBox";
            this.store_priceTextBox.Size = new System.Drawing.Size(615, 31);
            this.store_priceTextBox.TabIndex = 8;
            // 
            // product_stockLabel
            // 
            product_stockLabel.AutoSize = true;
            product_stockLabel.Location = new System.Drawing.Point(49, 388);
            product_stockLabel.Name = "product_stockLabel";
            product_stockLabel.Size = new System.Drawing.Size(149, 25);
            product_stockLabel.TabIndex = 9;
            product_stockLabel.Text = "Product stock:";
            // 
            // product_stockTextBox
            // 
            this.product_stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Product_stock", true));
            this.product_stockTextBox.Location = new System.Drawing.Point(209, 388);
            this.product_stockTextBox.Name = "product_stockTextBox";
            this.product_stockTextBox.Size = new System.Drawing.Size(615, 31);
            this.product_stockTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 57);
            this.button1.TabIndex = 11;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Product_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(product_IDLabel);
            this.Controls.Add(this.product_IDTextBox);
            this.Controls.Add(product_NameLabel);
            this.Controls.Add(this.product_NameRichTextBox);
            this.Controls.Add(product_TypeLabel);
            this.Controls.Add(this.product_TypeRichTextBox);
            this.Controls.Add(store_priceLabel);
            this.Controls.Add(this.store_priceTextBox);
            this.Controls.Add(product_stockLabel);
            this.Controls.Add(this.product_stockTextBox);
            this.Controls.Add(this.productsBindingNavigator);
            this.Name = "Product_form";
            this.Text = "Product_form";
            this.Load += new System.EventHandler(this.Product_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pet_store2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pet_store2DataSet pet_store2DataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private pet_store2DataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private pet_store2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox product_IDTextBox;
        private System.Windows.Forms.RichTextBox product_NameRichTextBox;
        private System.Windows.Forms.RichTextBox product_TypeRichTextBox;
        private System.Windows.Forms.TextBox store_priceTextBox;
        private System.Windows.Forms.TextBox product_stockTextBox;
        private System.Windows.Forms.Button button1;
    }
}