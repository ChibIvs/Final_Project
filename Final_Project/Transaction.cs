using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Final_Project
{
    public partial class Transaction : Form
    {
        public void RefreshData()
        {
            LoadTransactionData();
            LoadSalesData();
            LoadSummaryData();
        }
        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            LoadTransactionData();
            LoadSalesData();
            LoadSummaryData();
        }

        private void LoadTransactionData()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT TransactionID, TransactionDate, TotalAmount FROM Transactions ORDER BY TransactionDate DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void LoadSalesData()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = @"
    SELECT 
        s.SaleID, 
        s.Quantity, 
        s.Price, 
        s.Unit, 
        s.Amount, 
        s.TransactionID
    FROM Sales s
    ORDER BY s.TransactionID DESC";


                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
            }
        }

        private void dataGridView1_CellCoClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int transactionID = Convert.ToInt32(
                dataGridView1.Rows[e.RowIndex].Cells["TransactionID"].Value);

            LoadSalesByTransaction(transactionID);
        }

        private void LoadSalesByTransaction(int transactionID)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = @"
            SELECT 
                SaleID,
                Quantity,
                Price,
                Unit,
                Amount,
                TransactionID
            FROM Sales
            WHERE TransactionID = @id";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@id", transactionID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
            }
        }

        private void FilterSalesByTransaction(int transactionID)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = @"
    SELECT 
        s.SaleID, 
        s.Quantity, 
        s.Price, 
        s.Unit, 
        s.Amount, 
        s.TransactionID
    FROM Sales s
    WHERE s.TransactionID = @transID";


                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@transID", transactionID);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
            }
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to void.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to void this transaction?",
                "Confirm Void",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.No)
                return;

            int transactionID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TransactionID"].Value);

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();

                try
                {
                    // ✅ RESTORE STOCK
                    SqlCommand restoreCmd = new SqlCommand(@"
UPDATE p
SET p.quantity = p.quantity + s.Quantity
FROM Productss p
JOIN Sales s ON p.sku = s.SKU
WHERE s.TransactionID = @id", con, trans);

                    restoreCmd.Parameters.AddWithValue("@id", transactionID);

                    int affected = restoreCmd.ExecuteNonQuery();
                    if (affected == 0)
                    {
                        MessageBox.Show("No stock restored (check SKU match!)");
                    }


                    // Delete sales
                    SqlCommand deleteSales = new SqlCommand(
    "DELETE FROM Sales WHERE TransactionID = @id", con, trans);

                    deleteSales.Parameters.AddWithValue("@id", transactionID);
                    deleteSales.ExecuteNonQuery();

                    // Delete transaction
                    SqlCommand deleteTrans = new SqlCommand(
    "DELETE FROM Transactions WHERE TransactionID = @id", con, trans);

                    deleteTrans.Parameters.AddWithValue("@id", transactionID);
                    deleteTrans.ExecuteNonQuery();

                    trans.Commit();
                    MessageBox.Show("Transaction voided + stock restored!");

                    RefreshData();

                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int transactionID = Convert.ToInt32(
                dataGridView1.Rows[e.RowIndex].Cells["TransactionID"].Value);

            LoadSalesByTransaction(transactionID);
        }
        private void LoadSummaryData()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                // 🔹 TOTAL SALES
                SqlCommand totalSalesCmd = new SqlCommand(
                    "SELECT ISNULL(SUM(TotalAmount), 0) FROM Transactions", con);

                decimal totalSales = Convert.ToDecimal(totalSalesCmd.ExecuteScalar());

                // 🔹 TOTAL TRANSACTIONS
                SqlCommand totalTransCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Transactions", con);

                int totalTransactions = Convert.ToInt32(totalTransCmd.ExecuteScalar());

                // 🔹 DISPLAY TO TEXTBOXES
                txtsales.Text = totalSales.ToString("0.00");
                txttransactions.Text = totalTransactions.ToString();
            }
        }

        private void Sales_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtsales_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttransactions_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttodaysale_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
