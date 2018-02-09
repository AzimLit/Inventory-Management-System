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

    public partial class FrmLogin : Form
    {

        //---Pass the connection to DataBase
        //SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\AZIML\SOURCE\REPOS\STOCKMANAGEMENTSYSTEM\STOCKMANAGEMENTSYSTEM\INVENTORY.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aziml\source\repos\StockManagementSystem\StockManagementSystem\Inventory.mdf;Integrated Security=True");

        public FrmLogin()
        {
            InitializeComponent();
        }

        
        private void btnLoginOK_Click(object sender, EventArgs e)
        {
            int i = 0;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Registration where UserName='"+ txtUserName.Text +"' and PassWord='"+ txtPassW.Text +"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("This User name Pass word does not existe");
            }
            else
            {
                this.Hide();
                frmMainSTK MainUI = new frmMainSTK();
                MainUI.Show();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
