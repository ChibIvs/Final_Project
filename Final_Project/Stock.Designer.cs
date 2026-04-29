namespace Final_Project
{
    partial class Stock
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
            dataGridView1 = new DataGridView();
            P_ID = new DataGridViewTextBoxColumn();
            SKU = new DataGridViewTextBoxColumn();
            P_Name = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label8 = new Label();
            btnDelete = new Button();
            Updatebtn = new Button();
            txtclear = new Button();
            label9 = new Label();
            button1 = new Button();
            procat = new ComboBox();
            proprice = new TextBox();
            label7 = new Label();
            prounit = new TextBox();
            label6 = new Label();
            proquan = new TextBox();
            label5 = new Label();
            prodesc = new TextBox();
            label4 = new Label();
            proname = new TextBox();
            label3 = new Label();
            prosku = new TextBox();
            label1 = new Label();
            proid = new TextBox();
            label2 = new Label();
            panelHeader = new Panel();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 70, 150);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { P_ID, SKU, P_Name, Description, Category, Quantity, Unit, Price });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(333, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(919, 594);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // P_ID
            // 
            P_ID.Frozen = true;
            P_ID.HeaderText = "P_ID";
            P_ID.MinimumWidth = 6;
            P_ID.Name = "P_ID";
            P_ID.Width = 110;
            // 
            // SKU
            // 
            SKU.HeaderText = "SKU";
            SKU.MinimumWidth = 6;
            SKU.Name = "SKU";
            SKU.Width = 125;
            // 
            // P_Name
            // 
            P_Name.HeaderText = "P_Name";
            P_Name.MinimumWidth = 6;
            P_Name.Name = "P_Name";
            P_Name.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Unit
            // 
            Unit.HeaderText = "Unit";
            Unit.MinimumWidth = 6;
            Unit.Name = "Unit";
            Unit.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(Updatebtn);
            panel1.Controls.Add(txtclear);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(procat);
            panel1.Controls.Add(proprice);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(prounit);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(proquan);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(prodesc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(proname);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(prosku);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(proid);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 594);
            panel1.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(40, 70, 150);
            label8.Location = new Point(23, 10);
            label8.Name = "label8";
            label8.Size = new Size(201, 21);
            label8.TabIndex = 42;
            label8.Text = "PRODUCT INFORMATION";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(91, 433);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 35);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btndelete_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = Color.FromArgb(52, 152, 219);
            Updatebtn.Cursor = Cursors.Hand;
            Updatebtn.FlatAppearance.BorderSize = 0;
            Updatebtn.FlatStyle = FlatStyle.Flat;
            Updatebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Updatebtn.ForeColor = Color.White;
            Updatebtn.Location = new Point(113, 394);
            Updatebtn.Margin = new Padding(3, 2, 3, 2);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(95, 35);
            Updatebtn.TabIndex = 40;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = false;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // txtclear
            // 
            txtclear.BackColor = Color.LightGray;
            txtclear.Cursor = Cursors.Hand;
            txtclear.FlatAppearance.BorderSize = 0;
            txtclear.FlatStyle = FlatStyle.Flat;
            txtclear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtclear.Location = new Point(213, 394);
            txtclear.Margin = new Padding(3, 2, 3, 2);
            txtclear.Name = "txtclear";
            txtclear.Size = new Size(95, 35);
            txtclear.TabIndex = 39;
            txtclear.Text = "Clear";
            txtclear.UseVisualStyleBackColor = false;
            txtclear.Click += txtclear_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(40, 70, 150);
            label9.Location = new Point(12, 211);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 38;
            label9.Text = "Category";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 70, 150);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 394);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 35);
            button1.TabIndex = 37;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // procat
            // 
            procat.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            procat.FormattingEnabled = true;
            procat.Items.AddRange(new object[] { "Frozen Food,", " Beverages", "Personal Care", "Household Supplies" });
            procat.Location = new Point(153, 206);
            procat.Margin = new Padding(3, 2, 3, 2);
            procat.Name = "procat";
            procat.Size = new Size(155, 25);
            procat.TabIndex = 36;
            // 
            // proprice
            // 
            proprice.BorderStyle = BorderStyle.FixedSingle;
            proprice.Font = new Font("Segoe UI", 9.75F);
            proprice.Location = new Point(153, 338);
            proprice.Name = "proprice";
            proprice.Size = new Size(155, 25);
            proprice.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(40, 70, 150);
            label7.Location = new Point(11, 343);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 33;
            label7.Text = "PRICE";
            // 
            // prounit
            // 
            prounit.BorderStyle = BorderStyle.FixedSingle;
            prounit.Font = new Font("Segoe UI", 9.75F);
            prounit.Location = new Point(153, 298);
            prounit.Name = "prounit";
            prounit.Size = new Size(155, 25);
            prounit.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(40, 70, 150);
            label6.Location = new Point(11, 303);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 31;
            label6.Text = "UNIT";
            // 
            // proquan
            // 
            proquan.BorderStyle = BorderStyle.FixedSingle;
            proquan.Font = new Font("Segoe UI", 9.75F);
            proquan.Location = new Point(153, 252);
            proquan.Name = "proquan";
            proquan.Size = new Size(155, 25);
            proquan.TabIndex = 30;
            proquan.TextChanged += proquan_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(40, 70, 150);
            label5.Location = new Point(12, 257);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 29;
            label5.Text = "Quantity";
            // 
            // prodesc
            // 
            prodesc.BorderStyle = BorderStyle.FixedSingle;
            prodesc.Font = new Font("Segoe UI", 9.75F);
            prodesc.Location = new Point(153, 164);
            prodesc.Name = "prodesc";
            prodesc.Size = new Size(155, 25);
            prodesc.TabIndex = 28;
            prodesc.TextChanged += Desc_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(40, 70, 150);
            label4.Location = new Point(12, 169);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 27;
            label4.Text = "DESCRIPTION";
            // 
            // proname
            // 
            proname.BorderStyle = BorderStyle.FixedSingle;
            proname.Font = new Font("Segoe UI", 9.75F);
            proname.Location = new Point(153, 124);
            proname.Name = "proname";
            proname.Size = new Size(155, 25);
            proname.TabIndex = 26;
            proname.TextChanged += proname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(40, 70, 150);
            label3.Location = new Point(11, 129);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 25;
            label3.Text = "PRODUCT NAME";
            // 
            // prosku
            // 
            prosku.BorderStyle = BorderStyle.FixedSingle;
            prosku.Font = new Font("Segoe UI", 9.75F);
            prosku.Location = new Point(153, 84);
            prosku.Name = "prosku";
            prosku.Size = new Size(155, 25);
            prosku.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(40, 70, 150);
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 23;
            label1.Text = "SKU";
            // 
            // proid
            // 
            proid.BorderStyle = BorderStyle.FixedSingle;
            proid.Font = new Font("Segoe UI", 9.75F);
            proid.Location = new Point(153, 48);
            proid.Name = "proid";
            proid.Size = new Size(155, 25);
            proid.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(40, 70, 150);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 21;
            label2.Text = "PRODUCT ID";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(40, 70, 150);
            panelHeader.Controls.Add(label10);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1252, 70);
            panelHeader.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(24, 16);
            label10.Name = "label10";
            label10.Size = new Size(244, 30);
            label10.TabIndex = 0;
            label10.Text = " STOCK MANAGEMENT";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1252, 670);
            Controls.Add(panelHeader);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Stock";
            Text = "Stock";
            Load += Stock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label2;
        private TextBox proid;
        private TextBox proname;
        private Label label3;
        private TextBox prosku;
        private Label label1;
        private TextBox prodesc;
        private Label label4;
        private TextBox proprice;
        private Label label7;
        private TextBox prounit;
        private Label label6;
        private TextBox proquan;
        private Label label5;
        private Label label8;
        private ComboBox procat;
        private Button button1;
        private DataGridViewTextBoxColumn P_ID;
        private DataGridViewTextBoxColumn SKU;
        private DataGridViewTextBoxColumn P_Name;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Price;
        private Label label9;
        private Button txtclear;
        private Button Updatebtn;
        private Button btnDelete;
        private Panel panelHeader;
        private Label label10;
    }
}