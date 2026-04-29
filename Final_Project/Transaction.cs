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
        }
        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            LoadTransactionData();
            LoadSalesData();
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
                    SELECT s.SaleID, p.product_name, s.Quantity, s.UnitPrice, s.Amount, s.TransactionID
                    FROM Sales s
                    INNER JOIN Productss p ON s.ItemID = p.ProdID
                    ORDER BY s.TransactionID DESC";
                
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int transactionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["TransactionID"].Value);
                FilterSalesByTransaction(transactionID);
            }
        }

        private void FilterSalesByTransaction(int transactionID)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = @"
                    SELECT s.SaleID, s.ItemID, p.product_name, s.Quantity, s.UnitPrice, s.Amount, s.TransactionID
                    FROM Sales s
                    INNER JOIN Productss p ON s.ItemID = p.id
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
            INNER JOIN Sales s ON p.ProdID = s.ItemID
            WHERE s.TransactionID = @id", con, trans);

                    restoreCmd.Parameters.AddWithValue("@id", transactionID);
                    restoreCmd.ExecuteNonQuery();

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
                    MessageBox.Show("Transaction voided!");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
