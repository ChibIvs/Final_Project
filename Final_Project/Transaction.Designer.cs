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
            btnVoid = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            dataGridView3.Location = new Point(12, 34);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(644, 247);
            dataGridView3.TabIndex = 26;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // btnVoid
            // 
            btnVoid.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnVoid.Location = new Point(528, 287);
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
            ClientSize = new Size(665, 565);
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
        private Button btnVoid;
    }
}