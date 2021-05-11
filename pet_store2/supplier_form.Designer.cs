
namespace pet_store2
{
    partial class supplier_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplier_form));
            System.Windows.Forms.Label sup_NameLabel;
            System.Windows.Forms.Label sup_PhoneNumLabel;
            System.Windows.Forms.Label sup_TypeLabel;
            this.pet_store2DataSet = new pet_store2.pet_store2DataSet();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new pet_store2.pet_store2DataSetTableAdapters.supplierTableAdapter();
            this.tableAdapterManager = new pet_store2.pet_store2DataSetTableAdapters.TableAdapterManager();
            this.supplierBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.supplierBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sup_NameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sup_PhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.sup_TypeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            sup_NameLabel = new System.Windows.Forms.Label();
            sup_PhoneNumLabel = new System.Windows.Forms.Label();
            sup_TypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pet_store2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingNavigator)).BeginInit();
            this.supplierBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pet_store2DataSet
            // 
            this.pet_store2DataSet.DataSetName = "pet_store2DataSet";
            this.pet_store2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.pet_store2DataSet;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customer_has_productsTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.employees__use_productsTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.petsTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.supplier_has_productsTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager.UpdateOrder = pet_store2.pet_store2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // supplierBindingNavigator
            // 
            this.supplierBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.supplierBindingNavigator.BindingSource = this.supplierBindingSource;
            this.supplierBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.supplierBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.supplierBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.supplierBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.supplierBindingNavigatorSaveItem});
            this.supplierBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.supplierBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.supplierBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.supplierBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.supplierBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.supplierBindingNavigator.Name = "supplierBindingNavigator";
            this.supplierBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.supplierBindingNavigator.Size = new System.Drawing.Size(978, 42);
            this.supplierBindingNavigator.TabIndex = 0;
            this.supplierBindingNavigator.Text = "bindingNavigator1";
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
            // supplierBindingNavigatorSaveItem
            // 
            this.supplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.supplierBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("supplierBindingNavigatorSaveItem.Image")));
            this.supplierBindingNavigatorSaveItem.Name = "supplierBindingNavigatorSaveItem";
            this.supplierBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.supplierBindingNavigatorSaveItem.Text = "Save Data";
            this.supplierBindingNavigatorSaveItem.Click += new System.EventHandler(this.supplierBindingNavigatorSaveItem_Click);
            // 
            // sup_NameLabel
            // 
            sup_NameLabel.AutoSize = true;
            sup_NameLabel.Location = new System.Drawing.Point(44, 177);
            sup_NameLabel.Name = "sup_NameLabel";
            sup_NameLabel.Size = new System.Drawing.Size(118, 25);
            sup_NameLabel.TabIndex = 1;
            sup_NameLabel.Text = "Sup Name:";
            // 
            // sup_NameRichTextBox
            // 
            this.sup_NameRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Sup_Name", true));
            this.sup_NameRichTextBox.Location = new System.Drawing.Point(224, 161);
            this.sup_NameRichTextBox.Name = "sup_NameRichTextBox";
            this.sup_NameRichTextBox.Size = new System.Drawing.Size(651, 63);
            this.sup_NameRichTextBox.TabIndex = 2;
            this.sup_NameRichTextBox.Text = "";
            // 
            // sup_PhoneNumLabel
            // 
            sup_PhoneNumLabel.AutoSize = true;
            sup_PhoneNumLabel.Location = new System.Drawing.Point(44, 295);
            sup_PhoneNumLabel.Name = "sup_PhoneNumLabel";
            sup_PhoneNumLabel.Size = new System.Drawing.Size(174, 25);
            sup_PhoneNumLabel.TabIndex = 3;
            sup_PhoneNumLabel.Text = "Sup Phone Num:";
            // 
            // sup_PhoneNumTextBox
            // 
            this.sup_PhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Sup_PhoneNum", true));
            this.sup_PhoneNumTextBox.Location = new System.Drawing.Point(224, 295);
            this.sup_PhoneNumTextBox.Name = "sup_PhoneNumTextBox";
            this.sup_PhoneNumTextBox.Size = new System.Drawing.Size(651, 31);
            this.sup_PhoneNumTextBox.TabIndex = 4;
            // 
            // sup_TypeLabel
            // 
            sup_TypeLabel.AutoSize = true;
            sup_TypeLabel.Location = new System.Drawing.Point(44, 362);
            sup_TypeLabel.Name = "sup_TypeLabel";
            sup_TypeLabel.Size = new System.Drawing.Size(110, 25);
            sup_TypeLabel.TabIndex = 5;
            sup_TypeLabel.Text = "Sup Type:";
            // 
            // sup_TypeRichTextBox
            // 
            this.sup_TypeRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Sup_Type", true));
            this.sup_TypeRichTextBox.Location = new System.Drawing.Point(224, 362);
            this.sup_TypeRichTextBox.Name = "sup_TypeRichTextBox";
            this.sup_TypeRichTextBox.Size = new System.Drawing.Size(651, 61);
            this.sup_TypeRichTextBox.TabIndex = 6;
            this.sup_TypeRichTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 74);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // supplier_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 638);
            this.Controls.Add(this.button1);
            this.Controls.Add(sup_NameLabel);
            this.Controls.Add(this.sup_NameRichTextBox);
            this.Controls.Add(sup_PhoneNumLabel);
            this.Controls.Add(this.sup_PhoneNumTextBox);
            this.Controls.Add(sup_TypeLabel);
            this.Controls.Add(this.sup_TypeRichTextBox);
            this.Controls.Add(this.supplierBindingNavigator);
            this.Name = "supplier_form";
            this.Text = "supplier_form";
            this.Load += new System.EventHandler(this.supplier_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pet_store2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingNavigator)).EndInit();
            this.supplierBindingNavigator.ResumeLayout(false);
            this.supplierBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pet_store2DataSet pet_store2DataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private pet_store2DataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private pet_store2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator supplierBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton supplierBindingNavigatorSaveItem;
        private System.Windows.Forms.RichTextBox sup_NameRichTextBox;
        private System.Windows.Forms.TextBox sup_PhoneNumTextBox;
        private System.Windows.Forms.RichTextBox sup_TypeRichTextBox;
        private System.Windows.Forms.Button button1;
    }
}