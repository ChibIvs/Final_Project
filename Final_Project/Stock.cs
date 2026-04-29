using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Stock : Form
    {
        private void DisplayProduct()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM Productss";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);


                dataGridView1.Columns.Clear();


                dataGridView1.DataSource = dt;
            }
        }


        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            DisplayProduct();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(prosku.Text) ||
                    string.IsNullOrWhiteSpace(proname.Text) ||
                    string.IsNullOrWhiteSpace(prodesc.Text) ||
                    string.IsNullOrWhiteSpace(procat.Text) ||
                    string.IsNullOrWhiteSpace(proquan.Text) ||
                    string.IsNullOrWhiteSpace(prounit.Text) ||
                    string.IsNullOrWhiteSpace(proprice.Text))
                {
                    MessageBox.Show("Missing INFORMATION");
                    return;
                }

                if (!int.TryParse(proquan.Text, out int quantity) ||
                    !decimal.TryParse(proprice.Text, out decimal price))
                {
                    MessageBox.Show("Invalid quantity or price!");
                    return;
                }

                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    // ✅ CHECK DUPLICATE SKU
                    SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Productss WHERE sku = @sku", con);
                    checkCmd.Parameters.AddWithValue("@sku", prosku.Text);

                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("SKU already exists!");
                        return;
                    }

                    SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO Productss 
                (sku, product_name, product_Description, prod_category, quantity, unit, price)
                VALUES 
                (@sk, @pn, @pdes, @pcat, @pquan, @punit, @pprice)", con);

                    cmd.Parameters.AddWithValue("@sk", prosku.Text);
                    cmd.Parameters.AddWithValue("@pn", proname.Text);
                    cmd.Parameters.AddWithValue("@pdes", prodesc.Text);
                    cmd.Parameters.AddWithValue("@pcat", procat.Text);
                    cmd.Parameters.AddWithValue("@pquan", quantity);
                    cmd.Parameters.AddWithValue("@punit", prounit.Text);
                    cmd.Parameters.AddWithValue("@pprice", price);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product inserted successfully.");
                }

                DisplayProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void proquan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtclear_Click(object sender, EventArgs e)
        {
            proid.Clear();
            proname.Clear();
            prosku.Clear();
            prodesc.Clear();
            procat.SelectedIndex = -1;
            proquan.Clear();
            prounit.Clear();
            proprice.Clear();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(proid.Text))
                {
                    MessageBox.Show("Select a product first!");
                    return;
                }

                if (!int.TryParse(proquan.Text, out int quantity) ||
                    !decimal.TryParse(proprice.Text, out decimal price))
                {
                    MessageBox.Show("Invalid quantity or price!");
                    return;
                }

                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        @"UPDATE Productss SET 
                sku = @sk,
                product_name = @pn,
                product_Description = @pdes,
                prod_category = @pcat,
                quantity = @pquan,
                unit = @punit,
                price = @pprice
                WHERE ProdID = @id", con);

                    cmd.Parameters.AddWithValue("@id", proid.Text);
                    cmd.Parameters.AddWithValue("@sk", prosku.Text);
                    cmd.Parameters.AddWithValue("@pn", proname.Text);
                    cmd.Parameters.AddWithValue("@pdes", prodesc.Text);
                    cmd.Parameters.AddWithValue("@pcat", procat.Text);
                    cmd.Parameters.AddWithValue("@pquan", quantity);
                    cmd.Parameters.AddWithValue("@punit", prounit.Text);
                    cmd.Parameters.AddWithValue("@pprice", price);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Product updated successfully.");
                DisplayProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                proid.Text = row.Cells["ProdID"].Value?.ToString() ?? "";
                prosku.Text = row.Cells["sku"].Value?.ToString() ?? "";
                proname.Text = row.Cells["product_name"].Value?.ToString() ?? "";
                prodesc.Text = row.Cells["product_Description"].Value?.ToString() ?? "";
                procat.Text = row.Cells["prod_category"].Value?.ToString() ?? "";
                proquan.Text = row.Cells["quantity"].Value?.ToString() ?? "";
                prounit.Text = row.Cells["unit"].Value?.ToString() ?? "";
                proprice.Text = row.Cells["price"].Value?.ToString() ?? "";
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(proid.Text))
                {
                    MessageBox.Show("Select a product first.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Delete this product?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;

                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Productss WHERE ProdID = @id", con);

                    cmd.Parameters.AddWithValue("@id", proid.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Deleted successfully!");
                DisplayProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void proname_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
