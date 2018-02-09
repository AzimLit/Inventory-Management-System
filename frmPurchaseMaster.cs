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
    public partial class frmPurchaseMaster : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aziml\source\repos\StockManagementSystem\StockManagementSystem\Inventory.mdf;Integrated Security=True");

        public frmPurchaseMaster()
        {
            InitializeComponent();
        }

        //--------The combobox with product
        public void Fill_ProductName()
        {
            cboProductName.Items.Clear();

            //---Fill the comboBox Product Name
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from Product_Name";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cboProductName.Items.Add(dr["ProductName"].ToString());
            }

        }
        //-------------------------------------------------------------------------------
        //--------The combobox with product
        public void Fill_DealerName()
        {
            cboDealerName.Items.Clear();

            //---Fill the comboBox Product Name
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from Dealer_Info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cboDealerName.Items.Add(dr["Dealer_Name"].ToString());
            }

        }
        //-------------------------------------------------------------------------------

        private void frmPurchaseMaster_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            Fill_ProductName();//---Fill Product Name
            Fill_DealerName(); //---Fill Dealer info

            toolTipPurchase.SetToolTip(btnAddPurchase, "Add Purchase Record");
            toolTipPurchase.SetToolTip(btnCancelPurchase, "Exit this module");
        }

        private void txtAddEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelPurchase_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-------- Get the unit
        private void cboProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //---Fill the comboBox Product Name
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from Product_Name Where ProductName='"+ cboProductName.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                lblUnit.Text= dr["Units"].ToString();
            }

        }

        private void txtProdictPrice_Leave(object sender, EventArgs e)
        {
            txtProductTotal.Text = Convert.ToString(Convert.ToInt32(txtProductQuantity.Text) * Convert.ToInt32(txtProdictPrice.Text));
        }

        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            int i;

            //---Fill the comboBox Product Name
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select* from Stock Where ProductName='" + cboProductName.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            i = Convert.ToInt32(dt1.Rows.Count.ToString());

            if (i == 0)
            {
                //---INSERT Purchase_Master
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert Into Purchase_Master Values ('" + cboProductName.Text + "','" + txtProductQuantity.Text + "','" + lblUnit.Text + "','" + txtProdictPrice.Text + "','" + txtProductTotal.Text + "','" + dtPickerPurchaseDate.Value.ToString("MM-DD-YYYY") + "','" + cboDealerName.Text + "','" + cboPurchaseType.Text + "','" + dtPickerExpDate.Value.ToString("MM-DD-YYYY") + "','" + txtProfit.Text + "')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record inserted succesfully");

                //---INSERT int Stock
                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "Insert Into Stock Values ('" + cboProductName.Text + "','" + txtProductQuantity.Text + "','" + lblUnit.Text + "')";
                cmd3.ExecuteNonQuery();   

                MessageBox.Show("Record inserted succesfully in stock");
            }
            else
            {  //---INSERT Query
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert Into Purchase_Master Values ('" + cboProductName.Text + "','" + txtProductQuantity.Text + "','" + lblUnit.Text + "','" + txtProdictPrice.Text + "','" + txtProductTotal.Text + "','" + dtPickerPurchaseDate.Value.ToString("MM-DD-YYYY") + "','" + cboDealerName.Text + "','" + cboPurchaseType.Text + "','" + dtPickerExpDate.Value.ToString("MM-DD-YYYY") + "','" + txtProfit.Text + "')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record inserted succesfully");


                //---INSERT int Stock to update Quantity
                SqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "Update Stock Set Product_Qty = Product_Qty + " + txtProductQuantity.Text + "  Where ProductName = '" + cboProductName.Text + "'";
                cmd5.ExecuteNonQuery();

                MessageBox.Show("Record (product Quantity) updated succesfully in stock");
            }

           
        }
    }
}
