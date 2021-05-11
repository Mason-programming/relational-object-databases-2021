
namespace pet_store2
{
    partial class Pet_Form
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
            System.Windows.Forms.Label pet_FNameLabel;
            System.Windows.Forms.Label pet_TypeLabel;
            System.Windows.Forms.Label pet_NutritionLabel;
            System.Windows.Forms.Label pet_BehaviorLabel;
            System.Windows.Forms.Label pet_IDLabel;
            System.Windows.Forms.Label c_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pet_Form));
            this.pet_LNameLabel = new System.Windows.Forms.Label();
            this.petsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.petsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.petsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pet_FNameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.pet_TypeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.pet_NutritionTextBox = new System.Windows.Forms.TextBox();
            this.pet_BehaviorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.pet_IDTextBox = new System.Windows.Forms.TextBox();
            this.c_IDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.petsTableAdapter = new pet_store2.pet_store2DataSetTableAdapters.petsTableAdapter();
            this.tableAdapterManager = new pet_store2.pet_store2DataSetTableAdapters.TableAdapterManager();
            pet_FNameLabel = new System.Windows.Forms.Label();
            pet_TypeLabel = new System.Windows.Forms.Label();
            pet_NutritionLabel = new System.Windows.Forms.Label();
            pet_BehaviorLabel = new System.Windows.Forms.Label();
            pet_IDLabel = new System.Windows.Forms.Label();
            c_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petsBindingNavigator)).BeginInit();
            this.petsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet_store2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pet_FNameLabel
            // 
            pet_FNameLabel.AutoSize = true;
            pet_FNameLabel.Location = new System.Drawing.Point(42, 121);
            pet_FNameLabel.Name = "pet_FNameLabel";
            pet_FNameLabel.Size = new System.Drawing.Size(125, 25);
            pet_FNameLabel.TabIndex = 1;
            pet_FNameLabel.Text = "Pet FName:";
            // 
            // pet_TypeLabel
            // 
            pet_TypeLabel.AutoSize = true;
            pet_TypeLabel.Location = new System.Drawing.Point(42, 289);
            pet_TypeLabel.Name = "pet_TypeLabel";
            pet_TypeLabel.Size = new System.Drawing.Size(104, 25);
            pet_TypeLabel.TabIndex = 5;
            pet_TypeLabel.Text = "Pet Type:";
            // 
            // pet_NutritionLabel
            // 
            pet_NutritionLabel.AutoSize = true;
            pet_NutritionLabel.Location = new System.Drawing.Point(42, 362);
            pet_NutritionLabel.Name = "pet_NutritionLabel";
            pet_NutritionLabel.Size = new System.Drawing.Size(136, 25);
            pet_NutritionLabel.TabIndex = 7;
            pet_NutritionLabel.Text = "Pet Nutrition:";
            // 
            // pet_BehaviorLabel
            // 
            pet_BehaviorLabel.AutoSize = true;
            pet_BehaviorLabel.Location = new System.Drawing.Point(42, 417);
            pet_BehaviorLabel.Name = "pet_BehaviorLabel";
            pet_BehaviorLabel.Size = new System.Drawing.Size(141, 25);
            pet_BehaviorLabel.TabIndex = 9;
            pet_BehaviorLabel.Text = "Pet Behavior:";
            // 
            // pet_IDLabel
            // 
            pet_IDLabel.AutoSize = true;
            pet_IDLabel.Location = new System.Drawing.Point(42, 501);
            pet_IDLabel.Name = "pet_IDLabel";
            pet_IDLabel.Size = new System.Drawing.Size(76, 25);
            pet_IDLabel.TabIndex = 11;
            pet_IDLabel.Text = "Pet ID:";
            // 
            // c_IDLabel
            // 
            c_IDLabel.AutoSize = true;
            c_IDLabel.Location = new System.Drawing.Point(43, 555);
            c_IDLabel.Name = "c_IDLabel";
            c_IDLabel.Size = new System.Drawing.Size(18, 25);
            c_IDLabel.TabIndex = 13;
            c_IDLabel.Text = " ";
            // 
            // pet_LNameLabel
            // 
            this.pet_LNameLabel.AutoSize = true;
            this.pet_LNameLabel.Location = new System.Drawing.Point(43, 220);
            this.pet_LNameLabel.Name = "pet_LNameLabel";
            this.pet_LNameLabel.Size = new System.Drawing.Size(0, 25);
            this.pet_LNameLabel.TabIndex = 3;
            // 
            // petsBindingNavigator
            // 
            this.petsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.petsBindingNavigator.BindingSource = this.petsBindingSource;
            this.petsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.petsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.petsBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.petsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.petsBindingNavigatorSaveItem});
            this.petsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.petsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.petsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.petsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.petsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.petsBindingNavigator.Name = "petsBindingNavigator";
            this.petsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.petsBindingNavigator.Size = new System.Drawing.Size(935, 50);
            this.petsBindingNavigator.TabIndex = 0;
            this.petsBindingNavigator.Text = "bindingNavigator1";
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
            // petsBindingSource
            // 
            this.petsBindingSource.DataMember = "pets";
            this.petsBindingSource.DataSource = this.pet_store2DataSet;
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
            // petsBindingNavigatorSaveItem
            // 
            this.petsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.petsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("petsBindingNavigatorSaveItem.Image")));
            this.petsBindingNavigatorSaveItem.Name = "petsBindingNavigatorSaveItem";
            this.petsBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 44);
            this.petsBindingNavigatorSaveItem.Text = "Save Data";
            this.petsBindingNavigatorSaveItem.Click += new System.EventHandler(this.petsBindingNavigatorSaveItem_Click);
            // 
            // pet_FNameRichTextBox
            // 
            this.pet_FNameRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petsBindingSource, "Pet_FName", true));
            this.pet_FNameRichTextBox.Location = new System.Drawing.Point(189, 118);
            this.pet_FNameRichTextBox.Name = "pet_FNameRichTextBox";
            this.pet_FNameRichTextBox.Size = new System.Drawing.Size(684, 50);
            this.pet_FNameRichTextBox.TabIndex = 2;
            this.pet_FNameRichTextBox.Text = "";
            // 
            // pet_TypeRichTextBox
            // 
            this.pet_TypeRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petsBindingSource, "Pet_Type", true));
            this.pet_TypeRichTextBox.Location = new System.Drawing.Point(189, 286);
            this.pet_TypeRichTextBox.Name = "pet_TypeRichTextBox";
            this.pet_TypeRichTextBox.Size = new System.Drawing.Size(684, 44);
            this.pet_TypeRichTextBox.TabIndex = 6;
            this.pet_TypeRichTextBox.Text = "";
            // 
            // pet_NutritionTextBox
            // 
            this.pet_NutritionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petsBindingSource, "Pet_Nutrition", true));
            this.pet_NutritionTextBox.Location = new System.Drawing.Point(189, 359);
            this.pet_NutritionTextBox.Name = "pet_NutritionTextBox";
            this.pet_NutritionTextBox.Size = new System.Drawing.Size(684, 31);
            this.pet_NutritionTextBox.TabIndex = 8;
            // 
            // pet_BehaviorRichTextBox
            // 
            this.pet_BehaviorRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petsBindingSource, "Pet_Behavior", true));
            this.pet_BehaviorRichTextBox.Location = new System.Drawing.Point(189, 414);
            this.pet_BehaviorRichTextBox.Name = "pet_BehaviorRichTextBox";
            this.pet_BehaviorRichTextBox.Size = new System.Drawing.Size(684, 53);
            this.pet_BehaviorRichTextBox.TabIndex = 10;
            this.pet_BehaviorRichTextBox.Text = "";
            // 
            // pet_IDTextBox
            // 
            this.pet_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petsBindingSource, "Pet_ID", true));
            this.pet_IDTextBox.Location = new System.Drawing.Point(189, 495);
            this.pet_IDTextBox.Name = "pet_IDTextBox";
            this.pet_IDTextBox.Size = new System.Drawing.Size(684, 31);
            this.pet_IDTextBox.TabIndex = 12;
            // 
            // c_IDTextBox
            // 
            this.c_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petsBindingSource, "C_ID", true));
            this.c_IDTextBox.Location = new System.Drawing.Point(863, 495);
            this.c_IDTextBox.Name = "c_IDTextBox";
            this.c_IDTextBox.Size = new System.Drawing.Size(10, 31);
            this.c_IDTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 69);
            this.button1.TabIndex = 15;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // petsTableAdapter
            // 
            this.petsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customer_has_productsTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.employees__use_productsTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.petsTableAdapter = this.petsTableAdapter;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.supplier_has_productsTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = pet_store2.pet_store2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Pet_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 730);
            this.Controls.Add(this.button1);
            this.Controls.Add(pet_FNameLabel);
            this.Controls.Add(this.pet_FNameRichTextBox);
            this.Controls.Add(this.pet_LNameLabel);
            this.Controls.Add(pet_TypeLabel);
            this.Controls.Add(this.pet_TypeRichTextBox);
            this.Controls.Add(pet_NutritionLabel);
            this.Controls.Add(this.pet_NutritionTextBox);
            this.Controls.Add(pet_BehaviorLabel);
            this.Controls.Add(this.pet_BehaviorRichTextBox);
            this.Controls.Add(pet_IDLabel);
            this.Controls.Add(this.pet_IDTextBox);
            this.Controls.Add(c_IDLabel);
            this.Controls.Add(this.c_IDTextBox);
            this.Controls.Add(this.petsBindingNavigator);
            this.Name = "Pet_Form";
            this.Text = "Pet_Form";
            this.Load += new System.EventHandler(this.Pet_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petsBindingNavigator)).EndInit();
            this.petsBindingNavigator.ResumeLayout(false);
            this.petsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet_store2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pet_store2DataSet pet_store2DataSet;
        private System.Windows.Forms.BindingSource petsBindingSource;
        private pet_store2DataSetTableAdapters.petsTableAdapter petsTableAdapter;
        private pet_store2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator petsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton petsBindingNavigatorSaveItem;
        private System.Windows.Forms.RichTextBox pet_FNameRichTextBox;
        private System.Windows.Forms.RichTextBox pet_TypeRichTextBox;
        private System.Windows.Forms.TextBox pet_NutritionTextBox;
        private System.Windows.Forms.RichTextBox pet_BehaviorRichTextBox;
        private System.Windows.Forms.TextBox pet_IDTextBox;
        private System.Windows.Forms.TextBox c_IDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label pet_LNameLabel;
    }
}