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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { P_ID, SKU, P_Name, Description, Category, Quantity, Unit, Price });
            dataGridView1.Location = new Point(323, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(919, 590);
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
            panel1.BackColor = Color.Gray;
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
            panel1.Location = new Point(0, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 700);
            panel1.TabIndex = 34;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(139, 372);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(68, 21);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btndelete_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(108, 346);
            Updatebtn.Margin = new Padding(3, 2, 3, 2);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(68, 21);
            Updatebtn.TabIndex = 40;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // txtclear
            // 
            txtclear.Location = new Point(210, 346);
            txtclear.Margin = new Padding(3, 2, 3, 2);
            txtclear.Name = "txtclear";
            txtclear.Size = new Size(68, 21);
            txtclear.TabIndex = 39;
            txtclear.Text = "Clear";
            txtclear.UseVisualStyleBackColor = true;
            txtclear.Click += txtclear_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 190);
            label9.Name = "label9";
            label9.Size = new Size(68, 16);
            label9.TabIndex = 38;
            label9.Text = "Category";
            // 
            // button1
            // 
            button1.Location = new Point(21, 346);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(68, 21);
            button1.TabIndex = 37;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // procat
            // 
            procat.FormattingEnabled = true;
            procat.Items.AddRange(new object[] { "Frozen Food,", " Beverages", "Personal Care", "Household Supplies" });
            procat.Location = new Point(153, 185);
            procat.Margin = new Padding(3, 2, 3, 2);
            procat.Name = "procat";
            procat.Size = new Size(155, 23);
            procat.TabIndex = 36;
            // 
            // proprice
            // 
            proprice.Location = new Point(153, 307);
            proprice.Name = "proprice";
            proprice.Size = new Size(155, 23);
            proprice.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 309);
            label7.Name = "label7";
            label7.Size = new Size(52, 16);
            label7.TabIndex = 33;
            label7.Text = "PRICE";
            // 
            // prounit
            // 
            prounit.Location = new Point(153, 266);
            prounit.Name = "prounit";
            prounit.Size = new Size(155, 23);
            prounit.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 268);
            label6.Name = "label6";
            label6.Size = new Size(43, 16);
            label6.TabIndex = 31;
            label6.Text = "UNIT";
            // 
            // proquan
            // 
            proquan.Location = new Point(153, 222);
            proquan.Name = "proquan";
            proquan.Size = new Size(155, 23);
            proquan.TabIndex = 30;
            proquan.TextChanged += proquan_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 224);
            label5.Name = "label5";
            label5.Size = new Size(69, 16);
            label5.TabIndex = 29;
            label5.Text = "Quantity";
            // 
            // prodesc
            // 
            prodesc.Location = new Point(153, 150);
            prodesc.Name = "prodesc";
            prodesc.Size = new Size(155, 23);
            prodesc.TabIndex = 28;
            prodesc.TextChanged += Desc_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 152);
            label4.Name = "label4";
            label4.Size = new Size(108, 16);
            label4.TabIndex = 27;
            label4.Text = "DESCRIPTION";
            // 
            // proname
            // 
            proname.Location = new Point(153, 87);
            proname.Name = "proname";
            proname.Size = new Size(155, 23);
            proname.TabIndex = 26;
            proname.TextChanged += proname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(127, 16);
            label3.TabIndex = 25;
            label3.Text = "PRODUCT NAME";
            // 
            // prosku
            // 
            prosku.Location = new Point(153, 48);
            prosku.Name = "prosku";
            prosku.Size = new Size(155, 23);
            prosku.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(38, 16);
            label1.TabIndex = 23;
            label1.Text = "SKU";
            // 
            // proid
            // 
            proid.Location = new Point(153, 22);
            proid.Name = "proid";
            proid.Size = new Size(155, 23);
            proid.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(100, 16);
            label2.TabIndex = 21;
            label2.Text = "PRODUCT ID";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 670);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Stock";
            Text = "Stock";
            Load += Stock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}