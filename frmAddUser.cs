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
    public partial class frmAddUser : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\AZIML\SOURCE\REPOS\STOCKMANAGEMENTSYSTEM\STOCKMANAGEMENTSYSTEM\INVENTORY.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aziml\source\repos\StockManagementSystem\StockManagementSystem\Inventory.mdf;Integrated Security=True");
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            int i = 0;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Registration where UserName='" + txtAddUserName.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                //SqlCommand cmd1 = con.CreateCommand();
                //cmd1.CommandType = CommandType.Text;
                //cmd1.CommandText = "Insert into Registration Values('"+ txtAddFirstName.Text + "','"+ txtAddLastName.Text + "','"+ txtAddUserName.Text + "','"+ txtAddPassWord.Text + "','"+ txtAddEmail.Text + "','"+ txtAddContact.Text + "')";
                //cmd1.ExecuteNonQuery();


                //---Pass in the SubQuery
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "Insert into Registration Values('" + txtAddFirstName.Text + "','" + txtAddLastName.Text + "','" + txtAddUserName.Text + "','" + txtAddPassWord.Text + "','" + txtAddEmail.Text + "','" + txtAddContact.Text + "')";
                cmd1.ExecuteNonQuery();



                //-- Clean the screen
                txtAddFirstName.Text = "";
                txtAddLastName.Text = "";
                txtAddUserName.Text = "";
                txtAddPassWord.Text = "";
                txtAddEmail.Text = "";
                txtAddContact.Text = "";

                //--Dispaly on the grid
                DisplayUser();

                MessageBox.Show("User Record eneterd successfully");
            }
            else
            {
                MessageBox.Show("This User name already existd, please choose another");
            }

        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            DisplayUser();

            toolTipUser.SetToolTip(btnDeleteUser, "Detele selected item");
            toolTipUser.SetToolTip(btnAddNewUser, "Click here to Add the New User");
            toolTipUser.SetToolTip(btnCancelAddUser, "Cancel operations");
        }

        public void DisplayUser()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Registration";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridViewUSER.DataSource = dt;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(dataGridViewUSER.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Registration Where id="+ id +"";

            cmd.ExecuteNonQuery();

            DisplayUser();
            //MessageBox.Show(dataGridViewUSER.SelectedCells[0].Value.ToString());
        }

        private void btnCancelAddUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTipUser_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
