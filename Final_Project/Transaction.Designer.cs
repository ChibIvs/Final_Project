namespace Final_Project
{
    partial class Transaction
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
            dataGridView1 = new DataGridView();
            Transact = new Label();
            Sales = new Label();
            dataGridView3 = new DataGridView();
            Trasaction_ID = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Total_Amount = new DataGridViewTextBoxColumn();
            Sale_ID = new DataGridViewTextBoxColumn();
            Item_ID = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Transaction_ID = new DataGridViewTextBoxColumn();
            btnVoid = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Trasaction_ID, Date, Total_Amount });
            dataGridView1.Location = new Point(12, 306);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(363, 247);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Transact
            // 
            Transact.AutoSize = true;
            Transact.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            Transact.Location = new Point(12, 284);
            Transact.Name = "Transact";
            Transact.Size = new Size(150, 19);
            Transact.TabIndex = 24;
            Transact.Text = "TRANSACTIONS";
            // 
            // Sales
            // 
            Sales.AutoSize = true;
            Sales.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            Sales.Location = new Point(12, 9);
            Sales.Name = "Sales";
            Sales.Size = new Size(67, 19);
            Sales.TabIndex = 25;
            Sales.Text = "SALES";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Sale_ID, Item_ID, Quantity, Unit, Price, Amount, Transaction_ID });
            dataGridView3.Location = new Point(12, 34);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(743, 247);
            dataGridView3.TabIndex = 26;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // Trasaction_ID
            // 
            Trasaction_ID.HeaderText = "Trasaction ID";
            Trasaction_ID.Name = "Trasaction_ID";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // Total_Amount
            // 
            Total_Amount.HeaderText = "Total Amount";
            Total_Amount.MaxInputLength = 3276722;
            Total_Amount.Name = "Total_Amount";
            Total_Amount.Width = 120;
            // 
            // Sale_ID
            // 
            Sale_ID.HeaderText = "Sale ID";
            Sale_ID.Name = "Sale_ID";
            // 
            // Item_ID
            // 
            Item_ID.HeaderText = "Item ID";
            Item_ID.Name = "Item_ID";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Unit
            // 
            Unit.HeaderText = "Unit";
            Unit.Name = "Unit";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            // 
            // Transaction_ID
            // 
            Transaction_ID.HeaderText = "Transaction ID";
            Transaction_ID.Name = "Transaction_ID";
            // 
            // btnVoid
            // 
            btnVoid.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnVoid.Location = new Point(627, 296);
            btnVoid.Name = "btnVoid";
            btnVoid.Size = new Size(128, 53);
            btnVoid.TabIndex = 27;
            btnVoid.Text = "VOID";
            btnVoid.UseVisualStyleBackColor = true;
            btnVoid.Click += btnVoid_Click;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 565);
            Controls.Add(btnVoid);
            Controls.Add(dataGridView3);
            Controls.Add(Sales);
            Controls.Add(Transact);
            Controls.Add(dataGridView1);
            Name = "Transaction";
            Text = "Transaction";
            Load += Transaction_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label Transact;
        private Label Sales;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Trasaction_ID;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Total_Amount;
        private DataGridViewTextBoxColumn Sale_ID;
        private DataGridViewTextBoxColumn Item_ID;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Transaction_ID;
        private Button btnVoid;
    }
}