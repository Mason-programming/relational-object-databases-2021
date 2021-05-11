
namespace pet_store2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label c_IDLabel;
            System.Windows.Forms.Label c_PhoneNumLabel;
            System.Windows.Forms.Label c_AddressLabel;
            System.Windows.Forms.Label pet_FNameLabel;
            System.Windows.Forms.Label c_LNameLabel;
            System.Windows.Forms.Label pet_TypeLabel;
            System.Windows.Forms.Label c_IDLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label c_PhoneNumLabel1;
            System.Windows.Forms.Label c_FNameLabel;
            System.Windows.Forms.Label c_LNameLabel1;
            System.Windows.Forms.Label c_IDLabel2;
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pet_store2DataSet = new pet_store2.pet_store2DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.petsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.customerTableAdapter = new pet_store2.pet_store2DataSetTableAdapters.customerTableAdapter();
            this.tableAdapterManager = new pet_store2.pet_store2DataSetTableAdapters.TableAdapterManager();
            this.petsTableAdapter = new pet_store2.pet_store2DataSetTableAdapters.petsTableAdapter();
            this.c_PhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.c_FNameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.c_LNameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.c_IDTextBox = new System.Windows.Forms.TextBox();
            c_IDLabel = new System.Windows.Forms.Label();
            c_PhoneNumLabel = new System.Windows.Forms.Label();
            c_AddressLabel = new System.Windows.Forms.Label();
            pet_FNameLabel = new System.Windows.Forms.Label();
            c_LNameLabel = new System.Windows.Forms.Label();
            pet_TypeLabel = new System.Windows.Forms.Label();
            c_IDLabel1 = new System.Windows.Forms.Label();
            c_PhoneNumLabel1 = new System.Windows.Forms.Label();
            c_FNameLabel = new System.Windows.Forms.Label();
            c_LNameLabel1 = new System.Windows.Forms.Label();
            c_IDLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet_store2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // c_IDLabel
            // 
            c_IDLabel.AutoSize = true;
            c_IDLabel.Location = new System.Drawing.Point(69, 233);
            c_IDLabel.Name = "c_IDLabel";
            c_IDLabel.Size = new System.Drawing.Size(0, 25);
            c_IDLabel.TabIndex = 5;
            // 
            // c_PhoneNumLabel
            // 
            c_PhoneNumLabel.AutoSize = true;
            c_PhoneNumLabel.Location = new System.Drawing.Point(69, 270);
            c_PhoneNumLabel.Name = "c_PhoneNumLabel";
            c_PhoneNumLabel.Size = new System.Drawing.Size(0, 25);
            c_PhoneNumLabel.TabIndex = 7;
            // 
            // c_AddressLabel
            // 
            c_AddressLabel.AutoSize = true;
            c_AddressLabel.Location = new System.Drawing.Point(69, 307);
            c_AddressLabel.Name = "c_AddressLabel";
            c_AddressLabel.Size = new System.Drawing.Size(0, 25);
            c_AddressLabel.TabIndex = 9;
            // 
            // pet_FNameLabel
            // 
            pet_FNameLabel.AutoSize = true;
            pet_FNameLabel.Location = new System.Drawing.Point(204, 298);
            pet_FNameLabel.Name = "pet_FNameLabel";
            pet_FNameLabel.Size = new System.Drawing.Size(0, 25);
            pet_FNameLabel.TabIndex = 17;
            // 
            // c_LNameLabel
            // 
            c_LNameLabel.AutoSize = true;
            c_LNameLabel.Location = new System.Drawing.Point(138, 166);
            c_LNameLabel.Name = "c_LNameLabel";
            c_LNameLabel.Size = new System.Drawing.Size(0, 25);
            c_LNameLabel.TabIndex = 18;
            // 
            // pet_TypeLabel
            // 
            pet_TypeLabel.AutoSize = true;
            pet_TypeLabel.Location = new System.Drawing.Point(34, 298);
            pet_TypeLabel.Name = "pet_TypeLabel";
            pet_TypeLabel.Size = new System.Drawing.Size(0, 25);
            pet_TypeLabel.TabIndex = 22;
            // 
            // c_IDLabel1
            // 
            c_IDLabel1.AutoSize = true;
            c_IDLabel1.Location = new System.Drawing.Point(111, 332);
            c_IDLabel1.Name = "c_IDLabel1";
            c_IDLabel1.Size = new System.Drawing.Size(0, 25);
            c_IDLabel1.TabIndex = 23;
            // 
            // customerBindingNavigator
            // 
            this.customerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerBindingNavigator.BindingSource = this.customerBindingSource;
            this.customerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customerBindingNavigatorSaveItem});
            this.customerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerBindingNavigator.Name = "customerBindingNavigator";
            this.customerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerBindingNavigator.Size = new System.Drawing.Size(784, 42);
            this.customerBindingNavigator.TabIndex = 0;
            this.customerBindingNavigator.Text = "bindingNavigator1";
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
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.pet_store2DataSet;
            // 
            // pet_store2DataSet
            // 
            this.pet_store2DataSet.DataSetName = "pet_store2DataSet";
            this.pet_store2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 44);
            this.customerBindingNavigatorSaveItem.Text = "Save Data";
            this.customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerBindingNavigatorSaveItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(343, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 31);
            this.textBox1.TabIndex = 11;
            // 
            // petsBindingSource
            // 
            this.petsBindingSource.DataMember = "pets";
            this.petsBindingSource.DataSource = this.pet_store2DataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 53);
            this.button1.TabIndex = 22;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customer_has_productsTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.employees__use_productsTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.petsTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.supplier_has_productsTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = pet_store2.pet_store2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // petsTableAdapter
            // 
            this.petsTableAdapter.ClearBeforeFill = true;
            // 
            // c_PhoneNumLabel1
            // 
            c_PhoneNumLabel1.AutoSize = true;
            c_PhoneNumLabel1.Location = new System.Drawing.Point(12, 267);
            c_PhoneNumLabel1.Name = "c_PhoneNumLabel1";
            c_PhoneNumLabel1.Size = new System.Drawing.Size(228, 25);
            c_PhoneNumLabel1.TabIndex = 24;
            c_PhoneNumLabel1.Text = "Customer Phone Num:";
            c_PhoneNumLabel1.Click += new System.EventHandler(this.c_PhoneNumLabel1_Click);
            // 
            // c_PhoneNumTextBox
            // 
            this.c_PhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "C_PhoneNum", true));
            this.c_PhoneNumTextBox.Location = new System.Drawing.Point(251, 264);
            this.c_PhoneNumTextBox.Name = "c_PhoneNumTextBox";
            this.c_PhoneNumTextBox.Size = new System.Drawing.Size(464, 31);
            this.c_PhoneNumTextBox.TabIndex = 25;
            // 
            // c_FNameLabel
            // 
            c_FNameLabel.AutoSize = true;
            c_FNameLabel.Location = new System.Drawing.Point(12, 122);
            c_FNameLabel.Name = "c_FNameLabel";
            c_FNameLabel.Size = new System.Drawing.Size(220, 25);
            c_FNameLabel.TabIndex = 25;
            c_FNameLabel.Text = "Customer First Name:";
            // 
            // c_FNameRichTextBox
            // 
            this.c_FNameRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "C_FName", true));
            this.c_FNameRichTextBox.Location = new System.Drawing.Point(251, 119);
            this.c_FNameRichTextBox.Name = "c_FNameRichTextBox";
            this.c_FNameRichTextBox.Size = new System.Drawing.Size(462, 50);
            this.c_FNameRichTextBox.TabIndex = 26;
            this.c_FNameRichTextBox.Text = "";
            // 
            // c_LNameLabel1
            // 
            c_LNameLabel1.AutoSize = true;
            c_LNameLabel1.Location = new System.Drawing.Point(12, 187);
            c_LNameLabel1.Name = "c_LNameLabel1";
            c_LNameLabel1.Size = new System.Drawing.Size(219, 25);
            c_LNameLabel1.TabIndex = 26;
            c_LNameLabel1.Text = "Customer Last Name:";
            // 
            // c_LNameRichTextBox
            // 
            this.c_LNameRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "C_LName", true));
            this.c_LNameRichTextBox.Location = new System.Drawing.Point(251, 187);
            this.c_LNameRichTextBox.Name = "c_LNameRichTextBox";
            this.c_LNameRichTextBox.Size = new System.Drawing.Size(464, 46);
            this.c_LNameRichTextBox.TabIndex = 27;
            this.c_LNameRichTextBox.Text = "";
            // 
            // c_IDLabel2
            // 
            c_IDLabel2.AutoSize = true;
            c_IDLabel2.Location = new System.Drawing.Point(12, 329);
            c_IDLabel2.Name = "c_IDLabel2";
            c_IDLabel2.Size = new System.Drawing.Size(59, 25);
            c_IDLabel2.TabIndex = 27;
            c_IDLabel2.Text = "C ID:";
            // 
            // c_IDTextBox
            // 
            this.c_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "C_ID", true));
            this.c_IDTextBox.Location = new System.Drawing.Point(252, 329);
            this.c_IDTextBox.Name = "c_IDTextBox";
            this.c_IDTextBox.Size = new System.Drawing.Size(464, 31);
            this.c_IDTextBox.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 531);
            this.Controls.Add(c_IDLabel2);
            this.Controls.Add(this.c_IDTextBox);
            this.Controls.Add(c_LNameLabel1);
            this.Controls.Add(this.c_LNameRichTextBox);
            this.Controls.Add(c_FNameLabel);
            this.Controls.Add(this.c_FNameRichTextBox);
            this.Controls.Add(c_PhoneNumLabel1);
            this.Controls.Add(this.c_PhoneNumTextBox);
            this.Controls.Add(c_IDLabel1);
            this.Controls.Add(pet_TypeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(c_LNameLabel);
            this.Controls.Add(pet_FNameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(c_IDLabel);
            this.Controls.Add(c_PhoneNumLabel);
            this.Controls.Add(c_AddressLabel);
            this.Controls.Add(this.customerBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
            this.customerBindingNavigator.ResumeLayout(false);
            this.customerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet_store2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pet_store2DataSet pet_store2DataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private pet_store2DataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private pet_store2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource petsBindingSource;
        private pet_store2DataSetTableAdapters.petsTableAdapter petsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox c_PhoneNumTextBox;
        private System.Windows.Forms.RichTextBox c_FNameRichTextBox;
        private System.Windows.Forms.RichTextBox c_LNameRichTextBox;
        private System.Windows.Forms.TextBox c_IDTextBox;
    }
}

