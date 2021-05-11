
namespace pet_store2
{
    partial class Employee_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Form));
            System.Windows.Forms.Label employ_IDLabel;
            System.Windows.Forms.Label employ_FNameLabel;
            System.Windows.Forms.Label employ_LNmaeLabel;
            System.Windows.Forms.Label employ_JobTitleLabel;
            System.Windows.Forms.Label employ_SalaryLabel;
            System.Windows.Forms.Label employ_DOBLabel;
            this.pet_store2DataSet = new pet_store2.pet_store2DataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new pet_store2.pet_store2DataSetTableAdapters.employeeTableAdapter();
            this.tableAdapterManager = new pet_store2.pet_store2DataSetTableAdapters.TableAdapterManager();
            this.employeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.employeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employ_IDTextBox = new System.Windows.Forms.TextBox();
            this.employ_FNameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.employ_LNmaeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.employ_JobTitleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.employ_SalaryTextBox = new System.Windows.Forms.TextBox();
            this.employ_DOBTextBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            employ_IDLabel = new System.Windows.Forms.Label();
            employ_FNameLabel = new System.Windows.Forms.Label();
            employ_LNmaeLabel = new System.Windows.Forms.Label();
            employ_JobTitleLabel = new System.Windows.Forms.Label();
            employ_SalaryLabel = new System.Windows.Forms.Label();
            employ_DOBLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pet_store2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).BeginInit();
            this.employeeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pet_store2DataSet
            // 
            this.pet_store2DataSet.DataSetName = "pet_store2DataSet";
            this.pet_store2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.pet_store2DataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customer_has_productsTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.employees__use_productsTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.petsTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.supplier_has_productsTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = pet_store2.pet_store2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeBindingNavigator
            // 
            this.employeeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeeBindingNavigator.BindingSource = this.employeeBindingSource;
            this.employeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeeBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.employeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeeBindingNavigatorSaveItem});
            this.employeeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeeBindingNavigator.Name = "employeeBindingNavigator";
            this.employeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeeBindingNavigator.Size = new System.Drawing.Size(990, 42);
            this.employeeBindingNavigator.TabIndex = 0;
            this.employeeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
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
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
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
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
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
            // employeeBindingNavigatorSaveItem
            // 
            this.employeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeBindingNavigatorSaveItem.Image")));
            this.employeeBindingNavigatorSaveItem.Name = "employeeBindingNavigatorSaveItem";
            this.employeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.employeeBindingNavigatorSaveItem.Text = "Save Data";
            this.employeeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeeBindingNavigatorSaveItem_Click);
            // 
            // employ_IDLabel
            // 
            employ_IDLabel.AutoSize = true;
            employ_IDLabel.Location = new System.Drawing.Point(70, 89);
            employ_IDLabel.Name = "employ_IDLabel";
            employ_IDLabel.Size = new System.Drawing.Size(115, 25);
            employ_IDLabel.TabIndex = 1;
            employ_IDLabel.Text = "Employ ID:";
            // 
            // employ_IDTextBox
            // 
            this.employ_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Employ_ID", true));
            this.employ_IDTextBox.Location = new System.Drawing.Point(253, 86);
            this.employ_IDTextBox.Name = "employ_IDTextBox";
            this.employ_IDTextBox.Size = new System.Drawing.Size(664, 31);
            this.employ_IDTextBox.TabIndex = 2;
            // 
            // employ_FNameLabel
            // 
            employ_FNameLabel.AutoSize = true;
            employ_FNameLabel.Location = new System.Drawing.Point(70, 126);
            employ_FNameLabel.Name = "employ_FNameLabel";
            employ_FNameLabel.Size = new System.Drawing.Size(164, 25);
            employ_FNameLabel.TabIndex = 3;
            employ_FNameLabel.Text = "Employ FName:";
            // 
            // employ_FNameRichTextBox
            // 
            this.employ_FNameRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Employ_FName", true));
            this.employ_FNameRichTextBox.Location = new System.Drawing.Point(253, 123);
            this.employ_FNameRichTextBox.Name = "employ_FNameRichTextBox";
            this.employ_FNameRichTextBox.Size = new System.Drawing.Size(664, 96);
            this.employ_FNameRichTextBox.TabIndex = 4;
            this.employ_FNameRichTextBox.Text = "";
            // 
            // employ_LNmaeLabel
            // 
            employ_LNmaeLabel.AutoSize = true;
            employ_LNmaeLabel.Location = new System.Drawing.Point(70, 228);
            employ_LNmaeLabel.Name = "employ_LNmaeLabel";
            employ_LNmaeLabel.Size = new System.Drawing.Size(163, 25);
            employ_LNmaeLabel.TabIndex = 5;
            employ_LNmaeLabel.Text = "Employ LNmae:";
            // 
            // employ_LNmaeRichTextBox
            // 
            this.employ_LNmaeRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Employ_LNmae", true));
            this.employ_LNmaeRichTextBox.Location = new System.Drawing.Point(253, 225);
            this.employ_LNmaeRichTextBox.Name = "employ_LNmaeRichTextBox";
            this.employ_LNmaeRichTextBox.Size = new System.Drawing.Size(664, 96);
            this.employ_LNmaeRichTextBox.TabIndex = 6;
            this.employ_LNmaeRichTextBox.Text = "";
            // 
            // employ_JobTitleLabel
            // 
            employ_JobTitleLabel.AutoSize = true;
            employ_JobTitleLabel.Location = new System.Drawing.Point(70, 330);
            employ_JobTitleLabel.Name = "employ_JobTitleLabel";
            employ_JobTitleLabel.Size = new System.Drawing.Size(177, 25);
            employ_JobTitleLabel.TabIndex = 7;
            employ_JobTitleLabel.Text = "Employ Job Title:";
            // 
            // employ_JobTitleRichTextBox
            // 
            this.employ_JobTitleRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Employ_JobTitle", true));
            this.employ_JobTitleRichTextBox.Location = new System.Drawing.Point(253, 327);
            this.employ_JobTitleRichTextBox.Name = "employ_JobTitleRichTextBox";
            this.employ_JobTitleRichTextBox.Size = new System.Drawing.Size(664, 96);
            this.employ_JobTitleRichTextBox.TabIndex = 8;
            this.employ_JobTitleRichTextBox.Text = "";
            // 
            // employ_SalaryLabel
            // 
            employ_SalaryLabel.AutoSize = true;
            employ_SalaryLabel.Location = new System.Drawing.Point(70, 432);
            employ_SalaryLabel.Name = "employ_SalaryLabel";
            employ_SalaryLabel.Size = new System.Drawing.Size(156, 25);
            employ_SalaryLabel.TabIndex = 9;
            employ_SalaryLabel.Text = "Employ Salary:";
            // 
            // employ_SalaryTextBox
            // 
            this.employ_SalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Employ_Salary", true));
            this.employ_SalaryTextBox.Location = new System.Drawing.Point(253, 429);
            this.employ_SalaryTextBox.Name = "employ_SalaryTextBox";
            this.employ_SalaryTextBox.Size = new System.Drawing.Size(664, 31);
            this.employ_SalaryTextBox.TabIndex = 10;
            // 
            // employ_DOBLabel
            // 
            employ_DOBLabel.AutoSize = true;
            employ_DOBLabel.Location = new System.Drawing.Point(70, 469);
            employ_DOBLabel.Name = "employ_DOBLabel";
            employ_DOBLabel.Size = new System.Drawing.Size(140, 25);
            employ_DOBLabel.TabIndex = 11;
            employ_DOBLabel.Text = "Employ DOB:";
            // 
            // employ_DOBTextBox
            // 
            this.employ_DOBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Employ_DOB", true));
            this.employ_DOBTextBox.Location = new System.Drawing.Point(253, 466);
            this.employ_DOBTextBox.Name = "employ_DOBTextBox";
            this.employ_DOBTextBox.Size = new System.Drawing.Size(664, 31);
            this.employ_DOBTextBox.TabIndex = 12;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(388, 530);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(225, 61);
            this.submit.TabIndex = 13;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(990, 623);
            this.Controls.Add(this.submit);
            this.Controls.Add(employ_IDLabel);
            this.Controls.Add(this.employ_IDTextBox);
            this.Controls.Add(employ_FNameLabel);
            this.Controls.Add(this.employ_FNameRichTextBox);
            this.Controls.Add(employ_LNmaeLabel);
            this.Controls.Add(this.employ_LNmaeRichTextBox);
            this.Controls.Add(employ_JobTitleLabel);
            this.Controls.Add(this.employ_JobTitleRichTextBox);
            this.Controls.Add(employ_SalaryLabel);
            this.Controls.Add(this.employ_SalaryTextBox);
            this.Controls.Add(employ_DOBLabel);
            this.Controls.Add(this.employ_DOBTextBox);
            this.Controls.Add(this.employeeBindingNavigator);
            this.Name = "Employee_Form";
            this.Text = "Employee_Form";
            this.Load += new System.EventHandler(this.Employee_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pet_store2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).EndInit();
            this.employeeBindingNavigator.ResumeLayout(false);
            this.employeeBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pet_store2DataSet pet_store2DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private pet_store2DataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private pet_store2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employeeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox employ_IDTextBox;
        private System.Windows.Forms.RichTextBox employ_FNameRichTextBox;
        private System.Windows.Forms.RichTextBox employ_LNmaeRichTextBox;
        private System.Windows.Forms.RichTextBox employ_JobTitleRichTextBox;
        private System.Windows.Forms.TextBox employ_SalaryTextBox;
        private System.Windows.Forms.TextBox employ_DOBTextBox;
        private System.Windows.Forms.Button submit;
    }
}