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
    public partial class frmDealerInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aziml\source\repos\StockManagementSystem\StockManagementSystem\Inventory.mdf;Integrated Security=True");

        public frmDealerInfo()
        {
            InitializeComponent();
        }

        public void DisplayDealer()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Dealer_Info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridViewDealer.DataSource = dt;
        }

        private void frmDealerInfo_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            DisplayDealer();
            //--------------------------------- btnUpdateDealer-----------------------------------

            toolTipDealer.SetToolTip(btnDeleteDealer, "Detele selected Dealer");
            toolTipDealer.SetToolTip(btnUpdateDealer, "Select Dealer and Click here to Update");
            toolTipDealer.SetToolTip(btnAddNewDealer, "Click here to Add the New Dealer");
            toolTipDealer.SetToolTip(btnCancelOperation, "Cancel operations");
        }

        private void btnAddNewDealer_Click(object sender, EventArgs e)
        {
            //---Pass in the SubQuery
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Dealer_Info Values('" + txtDealerName.Text + "', '" + txtCompanyName.Text + "', '" + txtDealerContact.Text + "', '" + txtAddress.Text + "', '" + txtCity.Text + "')";
            cmd.ExecuteNonQuery();

            //---Reset
            txtDealerName.Text = "";
            txtCompanyName.Text = "";
            txtDealerContact.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";

            DisplayDealer();

            MessageBox.Show("Record inserted successfully");

        }
        //--------------------------------------------------------------------------------------

        private void btnDeleteDealer_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(dataGridViewDealer.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Dealer_Info Where id=" + id + "";

            cmd.ExecuteNonQuery();

            DisplayDealer();
            MessageBox.Show("Record Deleted successfully");
        }
        //--------------------------------------------------------------------------------------

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //---------------------------------------------------------------------------------------

        private void btnUpdateDealer_Click(object sender, EventArgs e)
        {
            if (txtDealerName.Text == "")
            {
                //-----------Case where No Dealer was Selected
                MessageBox.Show(" No Dealer was Selected ! Pleas Dubble click the Grid below to select record you want to update.");

            }
            else
            {
                //-----------Case where Dealer was Selected

                
                //----------------------------------------------------------------------------

                string message = "Do you really want to Update this Dealer's informations ?";

                string title = "Update this Dealer Redord";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;



                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)

                {

                    //-----------Add codes here

                    int id;
                    id = Convert.ToInt32(dataGridViewDealer.SelectedCells[0].Value.ToString());

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Update Dealer_Info Set Dealer_Name='"+ txtDealerName.Text + "', Dealer_Company_Name='"+ txtCompanyName.Text + "', Dealer_Contact='"+ txtDealerContact.Text + "',  Address='"+ txtAddress.Text + "',  City='"+ txtCity.Text + "'  Where id=" + id + "";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    DisplayDealer();
                    MessageBox.Show("Dealer's Record Updated !");
                }

                else

                {
                    //-----------Add codes here
                    DisplayDealer();
                    MessageBox.Show("Operation canceled");

                }


            }

        }

        private void dataGridViewDealer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //------No action here!
        }

        //-------------------Doubleclick the Data Grid to bring on the form Dealer you want to Upddate--------
        private void dataGridViewDealer_DoubleClick(object sender, EventArgs e) 
        {
            int id;
            id = Convert.ToInt32(dataGridViewDealer.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Dealer_Info Where id=" + id + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                txtDealerName.Text = dr["Dealer_Name"].ToString();
                txtCompanyName.Text = dr["Dealer_Company_Name"].ToString();
                txtDealerContact.Text = dr["Dealer_Contact"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                txtCity.Text = dr["City"].ToString();

            }

        }
    }
}
