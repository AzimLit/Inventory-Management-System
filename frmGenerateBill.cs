using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StockManagementSystem
{
    public partial class frmGenerateBill : Form
    {
       
        int J;
        int Tot = 0;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aziml\source\repos\StockManagementSystem\StockManagementSystem\Inventory.mdf;Integrated Security=True");

        public frmGenerateBill()
        {
            InitializeComponent();
        }

        public void get_value(int i)
        {
            J = i;
        }

        private void frmGenerateBill_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            DataSetBill ds = new DataSetBill();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Order_User Where id="+J+"";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);

            //--------------------For Table Two----------------------------------------

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "Select * From Order_Item Where id=" + J + "";
            cmd2.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(ds.DataTable2);
            da2.Fill(dt2);

            //--------------------------------------------------------------------------------

            Tot = 0;
            foreach (DataRow dr2 in dt2.Rows)
            {
                Tot = Tot + Convert.ToInt32(dr2["Total"].ToString());
            }

            CrystalReport1 myReport = new CrystalReport1();
            myReport.SetDataSource(ds);
            myReport.SetParameterValue("Total", Tot.ToString());
            crystalReportViewer1.ReportSource = myReport;
        }
    }
}
