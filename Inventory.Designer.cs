
namespace M2_Project
{
    partial class Inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgInventory = new System.Windows.Forms.DataGridView();
            this.inventoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityLevelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodChargeVATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g4Pmb2024DataSet = new M2_Project.G4Pmb2024DataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboQuantity = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboUpdateQ = new System.Windows.Forms.ComboBox();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.taInventory = new M2_Project.G4Pmb2024DataSetTableAdapters.InventoryTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g4Pmb2024DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.dgInventory);
            this.groupBox1.Location = new System.Drawing.Point(19, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1097, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product List";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(923, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 53);
            this.button4.TabIndex = 4;
            this.button4.Text = "Add Product";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(923, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update Product";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(923, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Low Stock";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(923, 246);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(113, 53);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Product";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgInventory
            // 
            this.dgInventory.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgInventory.AutoGenerateColumns = false;
            this.dgInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgInventory.ColumnHeadersHeight = 29;
            this.dgInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryIDDataGridViewTextBoxColumn,
            this.prodDescriptionDataGridViewTextBoxColumn,
            this.prodPriceDataGridViewTextBoxColumn,
            this.quantityLevelsDataGridViewTextBoxColumn,
            this.prodChargeVATDataGridViewTextBoxColumn});
            this.dgInventory.DataSource = this.inventoryBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInventory.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgInventory.Location = new System.Drawing.Point(7, 20);
            this.dgInventory.Name = "dgInventory";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgInventory.RowHeadersWidth = 50;
            this.dgInventory.Size = new System.Drawing.Size(813, 291);
            this.dgInventory.TabIndex = 0;
            // 
            // inventoryIDDataGridViewTextBoxColumn
            // 
            this.inventoryIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.inventoryIDDataGridViewTextBoxColumn.DataPropertyName = "InventoryID";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.inventoryIDDataGridViewTextBoxColumn.HeaderText = "InventoryID";
            this.inventoryIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inventoryIDDataGridViewTextBoxColumn.Name = "inventoryIDDataGridViewTextBoxColumn";
            this.inventoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.inventoryIDDataGridViewTextBoxColumn.Width = 87;
            // 
            // prodDescriptionDataGridViewTextBoxColumn
            // 
            this.prodDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prodDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProdDescription";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDescriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.prodDescriptionDataGridViewTextBoxColumn.HeaderText = "ProdDescription";
            this.prodDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodDescriptionDataGridViewTextBoxColumn.Name = "prodDescriptionDataGridViewTextBoxColumn";
            this.prodDescriptionDataGridViewTextBoxColumn.Width = 107;
            // 
            // prodPriceDataGridViewTextBoxColumn
            // 
            this.prodPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prodPriceDataGridViewTextBoxColumn.DataPropertyName = "ProdPrice";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.NullValue = null;
            this.prodPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.prodPriceDataGridViewTextBoxColumn.HeaderText = "ProdPrice";
            this.prodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodPriceDataGridViewTextBoxColumn.Name = "prodPriceDataGridViewTextBoxColumn";
            this.prodPriceDataGridViewTextBoxColumn.Width = 78;
            // 
            // quantityLevelsDataGridViewTextBoxColumn
            // 
            this.quantityLevelsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantityLevelsDataGridViewTextBoxColumn.DataPropertyName = "QuantityLevels";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLevelsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.quantityLevelsDataGridViewTextBoxColumn.HeaderText = "QuantityLevels";
            this.quantityLevelsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityLevelsDataGridViewTextBoxColumn.Name = "quantityLevelsDataGridViewTextBoxColumn";
            this.quantityLevelsDataGridViewTextBoxColumn.Width = 102;
            // 
            // prodChargeVATDataGridViewTextBoxColumn
            // 
            this.prodChargeVATDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prodChargeVATDataGridViewTextBoxColumn.DataPropertyName = "ProdCharge_VAT";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.NullValue = null;
            this.prodChargeVATDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.prodChargeVATDataGridViewTextBoxColumn.HeaderText = "ProdCharge_VAT";
            this.prodChargeVATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodChargeVATDataGridViewTextBoxColumn.Name = "prodChargeVATDataGridViewTextBoxColumn";
            this.prodChargeVATDataGridViewTextBoxColumn.Width = 115;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.g4Pmb2024DataSet;
            // 
            // g4Pmb2024DataSet
            // 
            this.g4Pmb2024DataSet.DataSetName = "G4Pmb2024DataSet";
            this.g4Pmb2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.comboQuantity);
            this.groupBox2.Controls.Add(this.btnAddProduct);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtVat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(19, 423);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Product";
            this.groupBox2.Visible = false;
            // 
            // comboQuantity
            // 
            this.comboQuantity.FormattingEnabled = true;
            this.comboQuantity.Location = new System.Drawing.Point(191, 141);
            this.comboQuantity.Name = "comboQuantity";
            this.comboQuantity.Size = new System.Drawing.Size(126, 21);
            this.comboQuantity.TabIndex = 8;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddProduct.Location = new System.Drawing.Point(363, 153);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(128, 57);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click_1);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(191, 37);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(287, 20);
            this.txtDescription.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(191, 88);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(287, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(191, 193);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(126, 20);
            this.txtVat.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Product Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Product VAT Charge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Choose Quantity Levels";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Product Description";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.comboUpdateQ);
            this.groupBox3.Controls.Add(this.txtUpdatePrice);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(629, 423);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 256);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Product";
            this.groupBox3.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(214, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 57);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update Product";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboUpdateQ
            // 
            this.comboUpdateQ.FormattingEnabled = true;
            this.comboUpdateQ.Location = new System.Drawing.Point(214, 88);
            this.comboUpdateQ.Name = "comboUpdateQ";
            this.comboUpdateQ.Size = new System.Drawing.Size(248, 21);
            this.comboUpdateQ.TabIndex = 5;
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(214, 29);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(240, 20);
            this.txtUpdatePrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity Levels";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Price";
            // 
            // taInventory
            // 
            this.taInventory.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(311, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 40);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Enter Product Description";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1208, 691);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g4Pmb2024DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgInventory;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private G4Pmb2024DataSet g4Pmb2024DataSet;
        private G4Pmb2024DataSetTableAdapters.InventoryTableAdapter taInventory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboQuantity;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboUpdateQ;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityLevelsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodChargeVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}