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
    public partial class frmAdd_ProductName : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aziml\source\repos\StockManagementSystem\StockManagementSystem\Inventory.mdf;Integrated Security=True");

        public frmAdd_ProductName()
        {
            InitializeComponent();
        }

        public void Fill_DropDown()
        {
            cmbSelectProdUnit.Items.Clear();

            //---Fill the comboBox
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from Units";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                cmbSelectProdUnit.Items.Add(dr["unit"].ToString());
            }

        }
        //-------------------------------------------------------------------------------
        public void Fill_DataGrid()
        {
            //---Fill the DataGrid
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from Product_Name";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridViewProdName.DataSource = dt;
        }
        //-------------------------------------------------------------------------------



        private void frmAdd_ProductName_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            Fill_DropDown();// ---> Fill Combobox

            Fill_DataGrid(); //--> Fill Datagrid


            toolTipAddProdName.SetToolTip(btnUpdateProdName, "Update selected item");
            toolTipAddProdName.SetToolTip(btnAddProdName, "Click here to Add the New Product");
            toolTipAddProdName.SetToolTip(dataGridViewProdName, "Click on the grid or Item to Update");
            toolTipAddProdName.SetToolTip(panelGrid, "Click on the grid or Item to Update");
            toolTipAddProdName.SetToolTip(btnCancelProdName, "Cancel operations");
            
           
        }
        //-------------------------------------------------------------------------------

        private void btnCancelProdName_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-------------------------------------------------------------------------------

        private void btnAddProdName_Click(object sender, EventArgs e)
        {
            //---Pass in the SubQuery
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Product_Name Values('" + txtAddProductName.Text + "','" + cmbSelectProdUnit.SelectedItem.ToString() + "')";
            cmd.ExecuteNonQuery();

            txtAddProductName.Text = "";

            Fill_DataGrid(); //--> Fill Datagrid
            MessageBox.Show("Record Inserted successfully");
        }
        //-----------------------------Update-------------------------------------------
        private void btnUpdateProdName_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dataGridViewProdName.SelectedCells[0].Value.ToString());

            MessageBox.Show(i.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Product_Name Set ProductName='" + txtUpdateProduct.Text + "' , units='" + cmbUpdateProduct.SelectedItem.ToString() + "'  Where id='" + i + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            Fill_DataGrid(); //--> Fill Datagrid
            MessageBox.Show("Record Inserted successfully");
        }
        //-------------------------------------------------------------------------------


        private void dataGridViewProdName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panelUpdate.Visible = true;

            int i = Convert.ToInt32(dataGridViewProdName.SelectedCells[0].Value.ToString());

            //-----------------------------------------------------------
            cmbUpdateProduct.Items.Clear();

            //---Fill the comboBox
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select* from Units";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);

            foreach (DataRow dr2 in dt2.Rows)
            {
                cmbUpdateProduct.Items.Add(dr2["unit"].ToString());
            }

            //-----------------------------------------------------------
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from Product_Name Where id='" +i+ "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                txtUpdateProduct.Text = dr["ProductName"].ToString();
                cmbUpdateProduct.SelectedItem = dr["Units"].ToString();
            }


            


        }
    }
}
