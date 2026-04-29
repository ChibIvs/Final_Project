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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            label5 = new Label();
            label1 = new Label();
            dataGridView3 = new DataGridView();
            dataGridView1 = new DataGridView();
            Transact = new Label();
            Sales = new Label();
            btnVoid = new Button();
            panel2 = new Panel();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            txtsales = new TextBox();
            txttransactions = new TextBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 51, 153);
            panelHeader.Controls.Add(label5);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(987, 60);
            panelHeader.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(22, 38);
            label5.Name = "label5";
            label5.Size = new Size(189, 15);
            label5.TabIndex = 24;
            label5.Text = "View and manage all sales record";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(248, 30);
            label1.TabIndex = 0;
            label1.Text = "SALES & TRANSACTIONS";
            // 
            // dataGridView3
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.Location = new Point(9, 33);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(664, 247);
            dataGridView3.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(9, 312);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(664, 247);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // Transact
            // 
            Transact.AutoSize = true;
            Transact.BackColor = Color.Transparent;
            Transact.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Transact.ForeColor = Color.FromArgb(0, 51, 153);
            Transact.Location = new Point(9, 290);
            Transact.Name = "Transact";
            Transact.Size = new Size(131, 21);
            Transact.TabIndex = 24;
            Transact.Text = "TRANSACTIONS";
            // 
            // Sales
            // 
            Sales.AutoSize = true;
            Sales.BackColor = Color.Transparent;
            Sales.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Sales.ForeColor = Color.FromArgb(0, 51, 153);
            Sales.Location = new Point(9, 11);
            Sales.Name = "Sales";
            Sales.Size = new Size(56, 21);
            Sales.TabIndex = 25;
            Sales.Text = "SALES";
            Sales.Click += Sales_Click;
            // 
            // btnVoid
            // 
            btnVoid.BackColor = Color.FromArgb(254, 202, 202);
            btnVoid.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnVoid.ForeColor = Color.DarkRed;
            btnVoid.Location = new Point(12, 53);
            btnVoid.Name = "btnVoid";
            btnVoid.Size = new Size(243, 80);
            btnVoid.TabIndex = 27;
            btnVoid.Text = "VOID TRANSACTIONS\r\n\r\nremove selected transactions\r\n";
            btnVoid.UseVisualStyleBackColor = false;
            btnVoid.Click += btnVoid_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnVoid);
            panel2.Location = new Point(679, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 178);
            panel2.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 51, 153);
            label7.Location = new Point(3, 8);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 48;
            label7.Text = "ACTIONS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 51, 153);
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(150, 17);
            label3.TabIndex = 42;
            label3.Text = "TOTAL TRANSACTIONS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 51, 153);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(89, 17);
            label2.TabIndex = 41;
            label2.Text = "TOTAL SALES";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Transact);
            panel1.Controls.Add(Sales);
            panel1.Controls.Add(dataGridView3);
            panel1.Location = new Point(12, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 574);
            panel1.TabIndex = 41;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtsales);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txttransactions);
            panel3.Location = new Point(679, 232);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 327);
            panel3.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 51, 153);
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(92, 21);
            label6.TabIndex = 47;
            label6.Text = "SUMMARY";
            // 
            // txtsales
            // 
            txtsales.BorderStyle = BorderStyle.FixedSingle;
            txtsales.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtsales.Location = new Point(12, 80);
            txtsales.Multiline = true;
            txtsales.Name = "txtsales";
            txtsales.Size = new Size(243, 36);
            txtsales.TabIndex = 44;
            txtsales.TextAlign = HorizontalAlignment.Center;
            txtsales.TextChanged += txtsales_TextChanged;
            // 
            // txttransactions
            // 
            txttransactions.BorderStyle = BorderStyle.FixedSingle;
            txttransactions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txttransactions.Location = new Point(12, 161);
            txttransactions.Multiline = true;
            txttransactions.Name = "txttransactions";
            txttransactions.Size = new Size(243, 36);
            txttransactions.TabIndex = 45;
            txttransactions.TextAlign = HorizontalAlignment.Center;
            txttransactions.TextChanged += txttransactions_TextChanged;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 647);
            Controls.Add(panelHeader);
            Controls.Add(panel1);
            Name = "Transaction";
            Text = "Transaction";
            Load += Transaction_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Label label1;
        private Label label5;
        private DataGridView dataGridView3;
        private DataGridView dataGridView1;
        private Label Transact;
        private Label Sales;
        private Button btnVoid;
        private Panel panel2;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox txtsales;
        private Label label7;
        private Panel panel3;
        private Label label6;
        private TextBox txttransactions;
    }
}