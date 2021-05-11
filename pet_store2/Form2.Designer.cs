
namespace pet_store2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.supplier_has_productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.supplier_has_productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.supplier_has_productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.petsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplier_has_productsTableAdapter = new pet_store2.pet_store2DataSetTableAdapters.supplier_has_productsTableAdapter();
            this.tableAdapterManager = new pet_store2.pet_store2DataSetTableAdapters.TableAdapterManager();
            this.customerTableAdapter = new pet_store2.pet_store2DataSetTableAdapters.customerTableAdapter();
            this.petsTableAdapter = new pet_store2.pet_store2DataSetTableAdapters.petsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_has_productsBindingNavigator)).BeginInit();
            this.supplier_has_productsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_has_productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet_store2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // supplier_has_productsBindingNavigator
            // 
            this.supplier_has_productsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.supplier_has_productsBindingNavigator.BindingSource = this.supplier_has_productsBindingSource;
            this.supplier_has_productsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.supplier_has_productsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.supplier_has_productsBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.supplier_has_productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.supplier_has_productsBindingNavigatorSaveItem});
            this.supplier_has_productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.supplier_has_productsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.supplier_has_productsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.supplier_has_productsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.supplier_has_productsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.supplier_has_productsBindingNavigator.Name = "supplier_has_productsBindingNavigator";
            this.supplier_has_productsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.supplier_has_productsBindingNavigator.Size = new System.Drawing.Size(1154, 50);
            this.supplier_has_productsBindingNavigator.TabIndex = 1;
            this.supplier_has_productsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // supplier_has_productsBindingSource
            // 
            this.supplier_has_productsBindingSource.DataMember = "supplier_has_products";
            this.supplier_has_productsBindingSource.DataSource = this.pet_store2DataSet;
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
            // supplier_has_productsBindingNavigatorSaveItem
            // 
            this.supplier_has_productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.supplier_has_productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("supplier_has_productsBindingNavigatorSaveItem.Image")));
            this.supplier_has_productsBindingNavigatorSaveItem.Name = "supplier_has_productsBindingNavigatorSaveItem";
            this.supplier_has_productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 44);
            this.supplier_has_productsBindingNavigatorSaveItem.Text = "Save Data";
            this.supplier_has_productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.supplier_has_productsBindingNavigatorSaveItem_Click);
            // 
            // petsBindingSource
            // 
            this.petsBindingSource.DataMember = "customer_pets";
            this.petsBindingSource.DataSource = this.customerBindingSource;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.pet_store2DataSet;
            // 
            // supplier_has_productsTableAdapter
            // 
            this.supplier_has_productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customer_has_productsTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.employees__use_productsTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.petsTableAdapter = this.petsTableAdapter;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.supplier_has_productsTableAdapter = this.supplier_has_productsTableAdapter;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = pet_store2.pet_store2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // petsTableAdapter
            // 
            this.petsTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 475);
            this.Controls.Add(this.supplier_has_productsBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplier_has_productsBindingNavigator)).EndInit();
            this.supplier_has_productsBindingNavigator.ResumeLayout(false);
            this.supplier_has_productsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_has_productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet_store2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private pet_store2DataSet pet_store2DataSet;
        private System.Windows.Forms.BindingSource supplier_has_productsBindingSource;
        private pet_store2DataSetTableAdapters.supplier_has_productsTableAdapter supplier_has_productsTableAdapter;
        private pet_store2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator supplier_has_productsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton supplier_has_productsBindingNavigatorSaveItem;
        private pet_store2DataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private pet_store2DataSetTableAdapters.petsTableAdapter petsTableAdapter;
        private System.Windows.Forms.BindingSource petsBindingSource;
    }
}