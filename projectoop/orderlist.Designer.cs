namespace projectoop
{
    partial class orderlist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.projectoopDataSet3 = new projectoop.projectoopDataSet3();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new projectoop.projectoopDataSet3TableAdapters.orderTableAdapter();
            this.friedChickenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.franceFryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beefBurgerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chickenBurgerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheesePizzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beefPizzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chickenPizzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subSandwichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smokySandwichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheeseSandwichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mistyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chocolateCakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iceCreamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cocaColaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectoopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order From Table 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order From Table 2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.friedChickenDataGridViewTextBoxColumn,
            this.franceFryDataGridViewTextBoxColumn,
            this.beefBurgerDataGridViewTextBoxColumn,
            this.chickenBurgerDataGridViewTextBoxColumn,
            this.cheesePizzaDataGridViewTextBoxColumn,
            this.beefPizzaDataGridViewTextBoxColumn,
            this.chickenPizzaDataGridViewTextBoxColumn,
            this.subSandwichDataGridViewTextBoxColumn,
            this.smokySandwichDataGridViewTextBoxColumn,
            this.cheeseSandwichDataGridViewTextBoxColumn,
            this.mistyDataGridViewTextBoxColumn,
            this.chocolateCakeDataGridViewTextBoxColumn,
            this.iceCreamDataGridViewTextBoxColumn,
            this.cocaColaDataGridViewTextBoxColumn,
            this.teaDataGridViewTextBoxColumn,
            this.coffieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1009, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(32, 270);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1009, 136);
            this.dataGridView2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(805, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // projectoopDataSet3
            // 
            this.projectoopDataSet3.DataSetName = "projectoopDataSet3";
            this.projectoopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.projectoopDataSet3;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // friedChickenDataGridViewTextBoxColumn
            // 
            this.friedChickenDataGridViewTextBoxColumn.DataPropertyName = "Fried Chicken";
            this.friedChickenDataGridViewTextBoxColumn.HeaderText = "Fried Chicken";
            this.friedChickenDataGridViewTextBoxColumn.Name = "friedChickenDataGridViewTextBoxColumn";
            // 
            // franceFryDataGridViewTextBoxColumn
            // 
            this.franceFryDataGridViewTextBoxColumn.DataPropertyName = "France Fry";
            this.franceFryDataGridViewTextBoxColumn.HeaderText = "France Fry";
            this.franceFryDataGridViewTextBoxColumn.Name = "franceFryDataGridViewTextBoxColumn";
            // 
            // beefBurgerDataGridViewTextBoxColumn
            // 
            this.beefBurgerDataGridViewTextBoxColumn.DataPropertyName = "Beef Burger";
            this.beefBurgerDataGridViewTextBoxColumn.HeaderText = "Beef Burger";
            this.beefBurgerDataGridViewTextBoxColumn.Name = "beefBurgerDataGridViewTextBoxColumn";
            // 
            // chickenBurgerDataGridViewTextBoxColumn
            // 
            this.chickenBurgerDataGridViewTextBoxColumn.DataPropertyName = "Chicken Burger";
            this.chickenBurgerDataGridViewTextBoxColumn.HeaderText = "Chicken Burger";
            this.chickenBurgerDataGridViewTextBoxColumn.Name = "chickenBurgerDataGridViewTextBoxColumn";
            // 
            // cheesePizzaDataGridViewTextBoxColumn
            // 
            this.cheesePizzaDataGridViewTextBoxColumn.DataPropertyName = "Cheese Pizza";
            this.cheesePizzaDataGridViewTextBoxColumn.HeaderText = "Cheese Pizza";
            this.cheesePizzaDataGridViewTextBoxColumn.Name = "cheesePizzaDataGridViewTextBoxColumn";
            // 
            // beefPizzaDataGridViewTextBoxColumn
            // 
            this.beefPizzaDataGridViewTextBoxColumn.DataPropertyName = "Beef Pizza";
            this.beefPizzaDataGridViewTextBoxColumn.HeaderText = "Beef Pizza";
            this.beefPizzaDataGridViewTextBoxColumn.Name = "beefPizzaDataGridViewTextBoxColumn";
            // 
            // chickenPizzaDataGridViewTextBoxColumn
            // 
            this.chickenPizzaDataGridViewTextBoxColumn.DataPropertyName = "Chicken Pizza";
            this.chickenPizzaDataGridViewTextBoxColumn.HeaderText = "Chicken Pizza";
            this.chickenPizzaDataGridViewTextBoxColumn.Name = "chickenPizzaDataGridViewTextBoxColumn";
            // 
            // subSandwichDataGridViewTextBoxColumn
            // 
            this.subSandwichDataGridViewTextBoxColumn.DataPropertyName = "Sub Sandwich";
            this.subSandwichDataGridViewTextBoxColumn.HeaderText = "Sub Sandwich";
            this.subSandwichDataGridViewTextBoxColumn.Name = "subSandwichDataGridViewTextBoxColumn";
            // 
            // smokySandwichDataGridViewTextBoxColumn
            // 
            this.smokySandwichDataGridViewTextBoxColumn.DataPropertyName = "Smoky Sandwich";
            this.smokySandwichDataGridViewTextBoxColumn.HeaderText = "Smoky Sandwich";
            this.smokySandwichDataGridViewTextBoxColumn.Name = "smokySandwichDataGridViewTextBoxColumn";
            // 
            // cheeseSandwichDataGridViewTextBoxColumn
            // 
            this.cheeseSandwichDataGridViewTextBoxColumn.DataPropertyName = "Cheese Sandwich";
            this.cheeseSandwichDataGridViewTextBoxColumn.HeaderText = "Cheese Sandwich";
            this.cheeseSandwichDataGridViewTextBoxColumn.Name = "cheeseSandwichDataGridViewTextBoxColumn";
            // 
            // mistyDataGridViewTextBoxColumn
            // 
            this.mistyDataGridViewTextBoxColumn.DataPropertyName = "Misty";
            this.mistyDataGridViewTextBoxColumn.HeaderText = "Misty";
            this.mistyDataGridViewTextBoxColumn.Name = "mistyDataGridViewTextBoxColumn";
            // 
            // chocolateCakeDataGridViewTextBoxColumn
            // 
            this.chocolateCakeDataGridViewTextBoxColumn.DataPropertyName = "Chocolate Cake";
            this.chocolateCakeDataGridViewTextBoxColumn.HeaderText = "Chocolate Cake";
            this.chocolateCakeDataGridViewTextBoxColumn.Name = "chocolateCakeDataGridViewTextBoxColumn";
            // 
            // iceCreamDataGridViewTextBoxColumn
            // 
            this.iceCreamDataGridViewTextBoxColumn.DataPropertyName = "Ice Cream";
            this.iceCreamDataGridViewTextBoxColumn.HeaderText = "Ice Cream";
            this.iceCreamDataGridViewTextBoxColumn.Name = "iceCreamDataGridViewTextBoxColumn";
            // 
            // cocaColaDataGridViewTextBoxColumn
            // 
            this.cocaColaDataGridViewTextBoxColumn.DataPropertyName = "coca cola";
            this.cocaColaDataGridViewTextBoxColumn.HeaderText = "coca cola";
            this.cocaColaDataGridViewTextBoxColumn.Name = "cocaColaDataGridViewTextBoxColumn";
            // 
            // teaDataGridViewTextBoxColumn
            // 
            this.teaDataGridViewTextBoxColumn.DataPropertyName = "Tea";
            this.teaDataGridViewTextBoxColumn.HeaderText = "Tea";
            this.teaDataGridViewTextBoxColumn.Name = "teaDataGridViewTextBoxColumn";
            // 
            // coffieDataGridViewTextBoxColumn
            // 
            this.coffieDataGridViewTextBoxColumn.DataPropertyName = "Coffie";
            this.coffieDataGridViewTextBoxColumn.HeaderText = "Coffie";
            this.coffieDataGridViewTextBoxColumn.Name = "coffieDataGridViewTextBoxColumn";
            // 
            // orderlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 550);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "orderlist";
            this.Text = "orderlist";
            this.Load += new System.EventHandler(this.orderlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectoopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private projectoopDataSet3 projectoopDataSet3;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private projectoopDataSet3TableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn friedChickenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn franceFryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beefBurgerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chickenBurgerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheesePizzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beefPizzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chickenPizzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subSandwichDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smokySandwichDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheeseSandwichDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mistyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chocolateCakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iceCreamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cocaColaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffieDataGridViewTextBoxColumn;
    }
}