using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace StockManagementSystem
{
    public partial class frmSales : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aziml\source\repos\StockManagementSystem\StockManagementSystem\Inventory.mdf;Integrated Security=True");

        //--- Clear the temp Data table
        DataTable dt = new DataTable();

        int InStock = 0;  //Check stock availability 

        int Tot = 0;


        public frmSales()
        {
            InitializeComponent();
        }

            
        //------------------------------Delete Article-=-------------------------------------------
        private void btnDeleteSales_Click(object sender, EventArgs e)
        {
            try
            {
                Tot = 0;
                dt.Rows.RemoveAt(Convert.ToInt32(dataGridViewSales.CurrentCell.RowIndex.ToString()));
                foreach(DataRow dr1 in dt.Rows)
                {
                    Tot = Tot + Convert.ToInt32(dr1["Total"].ToString());
                    lblTotalSales.Text = Tot.ToString();
                }
            }
            catch (Exception ex)
            {

                //throw;
            }
            
        }

        //-----------------------------------------------------------------------------------------
        

        private void frmSales_Load(object sender, EventArgs e)
        {

            toolTipSales.SetToolTip(btnAddPurchase, "Add Item");
            toolTipSales.SetToolTip(btnDeleteSales, "Click here to Delete Record");
            toolTipSales.SetToolTip(btnSave, "Save Record");
            toolTipSales.SetToolTip(BtnPrint, "Print Invoice");
            //--------------------------------------------------------------------------

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            //---------------- Clear the temp Data table
            dt.Clear();
            dt.Columns.Add("Product");
            dt.Columns.Add("Price");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Total");

        }

        //------------------SAVE and PRINT Bill--------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            string OrderID = "";

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "Insert Into Order_User Values('"+ txtFirstName.Text + "', '"+ txtLastName.Text + "', '"+ cboBillType.Text + "', '" + dtPickerBillDate.Value.ToString("mm/dd/yyyy") + "')";
            cmd1.ExecuteNonQuery();




            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1 * from Order_User order by id desc"; 
            cmd2.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.Fill(dt2);

            foreach (DataRow dr2 in dt2.Rows)
            {
                OrderID= dr2["id"].ToString();
            }

            foreach (DataRow dr in dt.Rows)
            {
                int Qty_Var= 0;
                string Pname = "";

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "Insert Into Order_Item Values('" + OrderID.ToString() + "', '" + dr["Product"].ToString() + "', '" + dr["Price"].ToString() + "', '" + dr["Qty"].ToString() + "', '" + dr["Total"].ToString() + "')";
                cmd3.ExecuteNonQuery();

                //-----------Update Stock------------------------

                Qty_Var = Convert.ToInt32(dr["Qty"].ToString());
                Pname = dr["Product"].ToString();

                SqlCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "Update Stock Set Product_Qty= Product_Qty - "+ Qty_Var +" Where ProductName='"+ Pname.ToString() + "'";
                cmd6.ExecuteNonQuery();

            }
            // Clear all TextBoxes
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtProduct.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";
            lblTotalSales.Text = "0.00";

            dt.Clear();
            dataGridViewSales.DataSource = dt;

            MessageBox.Show("Record inserted successfully");
        }

        //------------------------- txtProduct Key UP----------------------
        private void txtProduct_KeyUp(object sender, KeyEventArgs e)
        {
            listProdName.Visible = true;
            listProdName.Items.Clear();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Stock where ProductName like('" + txtProduct.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                listProdName.Items.Add(dr["ProductName"].ToString());

                // We could ad stock quatnity here ===========================<<<<<<<
                InStock = 0;
                InStock = Convert.ToInt32(dr["Product_Qty"].ToString());
                labelTest.Text = "";

                labelTest.Text = Convert.ToString(InStock);

            }
        }

        //------------------------- txtProduct Key Down----------------------

        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listProdName.Focus();
                listProdName.SelectedIndex = 0;
            }
        }

        private void listProdName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    this.listProdName.SelectedIndex = this.listProdName.SelectedIndex + 1;
                }

                if (e.KeyCode == Keys.Up)
                {
                    this.listProdName.SelectedIndex = this.listProdName.SelectedIndex - 1;
                }

                if (e.KeyCode == Keys.Enter)
                {
                    txtProduct.Text = listProdName.SelectedItem.ToString();
                    listProdName.Visible = false;
                    txtPrice.Focus();

                }

            }
            catch (Exception ex)
            {

                //throw;
            }   
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 * from Purchase_Master where Product_Name='" + txtProduct.Text + "' order by id desc";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                txtPrice.Text=dr["Product_Price"].ToString();
            }
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = Convert.ToString(Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtQty.Text));
            }
            catch (Exception ex)
            {

                //throw;
            }
        }

        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            

            if (Convert.ToInt32(txtQty.Text)>InStock)
            {
                MessageBox.Show("This much value is not available");

            }
            else
            {
                DataRow dr = dt.NewRow();
               
                dr["Product"] = txtProduct.Text;
                dr["Price"] = txtPrice.Text;
                dr["Qty"] = txtQty.Text;
                dr["Total"] = txtTotal.Text;

                dt.Rows.Add(dr);
                dataGridViewSales.DataSource = dt;

                Tot = Tot + Convert.ToInt32(dr["Total"].ToString());

                lblTotalSales.Text = Tot.ToString();

            }

            txtProduct.Text ="";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";


            txtProduct.Focus();

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            string OrderID = "";

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "Insert Into Order_User Values('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + cboBillType.Text + "', '" + dtPickerBillDate.Value.ToString("mm/dd/yyyy") + "')";
            cmd1.ExecuteNonQuery();




            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1 * from Order_User order by id desc";
            cmd2.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.Fill(dt2);

            foreach (DataRow dr2 in dt2.Rows)
            {
                OrderID = dr2["id"].ToString();
            }

            foreach (DataRow dr in dt.Rows)
            {
                int Qty_Var = 0;
                string Pname = "";

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "Insert Into Order_Item Values('" + OrderID.ToString() + "', '" + dr["Product"].ToString() + "', '" + dr["Price"].ToString() + "', '" + dr["Qty"].ToString() + "', '" + dr["Total"].ToString() + "')";
                cmd3.ExecuteNonQuery();

                //-----------Update Stock------------------------

                Qty_Var = Convert.ToInt32(dr["Qty"].ToString());
                Pname = dr["Product"].ToString();

                SqlCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "Update Stock Set Product_Qty= Product_Qty - " + Qty_Var + " Where ProductName='" + Pname.ToString() + "'";
                cmd6.ExecuteNonQuery();

            }
            // Clear all TextBoxes
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtProduct.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";
            lblTotalSales.Text = "0.00";

            dt.Clear();
            dataGridViewSales.DataSource = dt;
            //--------------------------------------------------------------
            frmGenerateBill GenBill = new frmGenerateBill();
            GenBill.get_value(Convert.ToInt32(OrderID.ToString()));
            GenBill.Show();
        }
    }
}
