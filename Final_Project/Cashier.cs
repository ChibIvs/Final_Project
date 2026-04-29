using Microsoft.Data.SqlClient;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        private Transaction transactionForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessSKU(string sku)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT product_name, price, unit, quantity FROM Productss WHERE sku = @sku", con);

                cmd.Parameters.AddWithValue("@sku", sku);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string name = reader["product_name"].ToString();
                        decimal price = Convert.ToDecimal(reader["price"]);
                        string unit = reader["unit"].ToString();
                        int stockQty = Convert.ToInt32(reader["quantity"]);

                        if (stockQty <= 0)
                        {
                            MessageBox.Show("Out of stock!");
                            return;
                        }

                        int qty = 1;
                        decimal amount = qty * price;

                        dataGridView1.Rows.Add(sku, name, qty, unit, price, amount);

                        UpdateSubtotal();
                    }
                    else
                    {
                        MessageBox.Show("Product not found!");
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button15_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;

            // editable ONLY qty
            dataGridView1.Columns[2].ReadOnly = false;

            // lock everything else
            dataGridView1.Columns[0].ReadOnly = true; // sku
            dataGridView1.Columns[1].ReadOnly = true; // name
            dataGridView1.Columns[3].ReadOnly = true; // unit
            dataGridView1.Columns[4].ReadOnly = true; // price
            dataGridView1.Columns[5].ReadOnly = true; // amount

            // hide SKU
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            const int num = 0;
            txtSku.Text += num.ToString();
        }
        private void btnNum1_Click(object sender, EventArgs e)
        {
            const int num = 1;
            txtSku.Text += num.ToString();
        }
        private void btnNum2_Click(object sender, EventArgs e)
        {
            const int num = 2;
            txtSku.Text += num.ToString();
        }
        private void btnNum3_Click(object sender, EventArgs e)
        {
            const int num = 3;
            txtSku.Text += num.ToString();
        }
        private void btnNum4_Click(object sender, EventArgs e)
        {
            const int num = 4;
            txtSku.Text += num.ToString();
        }
        private void btnNum5_Click(object sender, EventArgs e)
        {
            const int num = 5;
            txtSku.Text += num.ToString();
        }
        private void btnNum6_Click(object sender, EventArgs e)
        {
            const int num = 6;
            txtSku.Text += num.ToString();
        }
        private void btnNum7_Click(object sender, EventArgs e)
        {
            const int num = 7;
            txtSku.Text += num.ToString();
        }
        private void btnNum8_Click(object sender, EventArgs e)
        {
            const int num = 8;
            txtSku.Text += num.ToString();
        }
        private void btnNum9_Click(object sender, EventArgs e)
        {
            const int num = 9;
            txtSku.Text += num.ToString();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            const string clear = "";
            txtSku.Text = clear;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnPeriod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSku.Text))
            {
                MessageBox.Show("Enter SKU first!");
                return;
            }

            ProcessSKU(txtSku.Text.Trim());
            txtSku.Clear();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsku_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessSKU(txtSku.Text.Trim());
                txtSku.Clear();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSku.Text))
            {
                MessageBox.Show("Please enter SKU!");
                return;
            }

            ProcessSKU(txtSku.Text.Trim());
            txtSku.Clear();
            txtSku.Focus();
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 2)
            {
                RecalculateRow(e.RowIndex);
                UpdateSubtotal();
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.TextChanged -= Qty_TextChanged;
                    tb.TextChanged += Qty_TextChanged;
                }
            }
        }

        private void Qty_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null) return;

            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            RecalculateRow(rowIndex);
            UpdateSubtotal();
        }
        private void RecalculateRow(int rowIndex)
        {
            var row = dataGridView1.Rows[rowIndex];

            if (row.Cells[2].Value == null || row.Cells[4].Value == null)
                return;

            int qty;
            decimal price;

            if (!int.TryParse(row.Cells[2].Value.ToString(), out qty) ||
                !decimal.TryParse(row.Cells[4].Value.ToString(), out price))
                return;

            string sku = row.Cells[0].Value.ToString();

            int stockQty = 0;

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT quantity FROM Productss WHERE sku = @sku", con);

                cmd.Parameters.AddWithValue("@sku", sku);

                object result = cmd.ExecuteScalar();

                if (result != null)
                    stockQty = Convert.ToInt32(result);
            }

            if (qty > stockQty)
            {
                MessageBox.Show("Not enough stock!");

                row.Cells[2].Value = stockQty;
                qty = stockQty;
            }

            row.Cells[5].Value = qty * price;
        }

        private void UpdateSubtotal()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[5].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells[5].Value);
                }
            }

            txtSubTotal.Text = subtotal.ToString("0.00");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // =========================
            // 1. VALIDATION
            // =========================
            if (string.IsNullOrWhiteSpace(txtSubTotal.Text) ||
                string.IsNullOrWhiteSpace(paym.Text))
            {
                MessageBox.Show("Missing subtotal or payment!");
                return;
            }

            decimal subtotal;
            decimal payment;

            if (!decimal.TryParse(txtSubTotal.Text, out subtotal) ||
                !decimal.TryParse(paym.Text, out payment))
            {
                MessageBox.Show("Invalid number format!");
                return;
            }

            if (payment < subtotal)
            {
                MessageBox.Show("Insufficient payment!");
                return;
            }

            // =========================
            // 2. CONFIRMATION
            // =========================
            DialogResult confirm = MessageBox.Show(
                "Confirm payment?",
                "POS System",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.No)
                return;

            // =========================
            // 3. STOCK DEDUCTION & SAVE TO DATABASE
            // =========================
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                // Create Transaction
                SqlCommand transCmd = new SqlCommand(
                    "INSERT INTO Transactions (TransactionDate, TotalAmount) VALUES (@date, @total); SELECT SCOPE_IDENTITY();", con);

                transCmd.Parameters.AddWithValue("@date", DateTime.Now);
                transCmd.Parameters.AddWithValue("@total", subtotal);

                int transactionID = Convert.ToInt32(transCmd.ExecuteScalar());

                // Save Sales and Deduct Stock
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    string sku = row.Cells[0].Value.ToString();
                    string productName = row.Cells[1].Value.ToString();
                    int qty = Convert.ToInt32(row.Cells[2].Value);
                    string unit = row.Cells[3].Value.ToString(); // ✅ ADD THIS
                    decimal price = Convert.ToDecimal(row.Cells[4].Value);
                    decimal amount = Convert.ToDecimal(row.Cells[5].Value);

                    // Get ItemID from Productss table using SKU
                    SqlCommand getItemCmd = new SqlCommand(
                           "SELECT ProdID FROM Productss WHERE sku = @sku", con);
                    getItemCmd.Parameters.AddWithValue("@sku", sku);
                    object itemIdObj = getItemCmd.ExecuteScalar();

                    if (itemIdObj == null)
                    {
                        MessageBox.Show("Product not found: " + sku);
                        return;
                    }

                    int itemID = Convert.ToInt32(itemIdObj);

                    SqlCommand saleCmd = new SqlCommand(
 @"INSERT INTO Sales (SKU, Quantity, Price, Unit, Amount, TransactionID)
  VALUES (@sku, @qty, @price, @unit, @amount, @transID)", con);

                    saleCmd.Parameters.AddWithValue("@sku", sku);
                    saleCmd.Parameters.AddWithValue("@qty", qty);
                    saleCmd.Parameters.AddWithValue("@price", price);
                    saleCmd.Parameters.AddWithValue("@unit", unit);
                    saleCmd.Parameters.AddWithValue("@amount", amount);
                    saleCmd.Parameters.AddWithValue("@transID", transactionID);

                    saleCmd.ExecuteNonQuery();




                    // Deduct stock
                    SqlCommand stockCmd = new SqlCommand(
                        "UPDATE Productss SET quantity = quantity - @qty WHERE sku = @sku AND quantity >= @qty", con);

                    stockCmd.Parameters.AddWithValue("@qty", qty);
                    stockCmd.Parameters.AddWithValue("@sku", sku);

                    int result = stockCmd.ExecuteNonQuery();

                    if (result == 0)
                    {
                        MessageBox.Show("Not enough stock for SKU: " + sku);
                        return;
                    }
                }
            }

            // =========================
            // 4. FINAL COMPUTATION
            // =========================
            decimal change = payment - subtotal;
            txtChange.Text = change.ToString("0.00");

            // =========================
            // 5. SUCCESS ACTIONS
            // =========================
            MessageBox.Show("Payment successful!");

            dataGridView1.Rows.Clear();
            UpdateSubtotal();
            txtSku.Clear();
            paym.Clear();
            txtChange.Clear();

            // Refresh Transaction form automatically
            if (transactionForm != null && !transactionForm.IsDisposed)
            {
                transactionForm.RefreshData();
            }
        }

        private void btnVoid_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to void.");
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView1.Rows.Remove(row);
                }
                DialogResult result = MessageBox.Show(
                    "Void selected item?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;
            }

            UpdateSubtotal();
        }

        private void paym_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            if (transactionForm == null || transactionForm.IsDisposed)
            {
                transactionForm = new Transaction();
            }

            transactionForm.Show();
            transactionForm.BringToFront();
        }


    }
}
