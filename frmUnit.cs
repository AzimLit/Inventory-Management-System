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
    public partial class frmUnit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aziml\source\repos\StockManagementSystem\StockManagementSystem\Inventory.mdf;Integrated Security=True");

        public frmUnit()
        {
            InitializeComponent();
        }

        private void frmUnit_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            DisplayUnit();

            

            toolTipUnits.SetToolTip(btnDeleteUnit, "Detele selected Unit");
            toolTipUnits.SetToolTip(btnAddNewUnit, "Click here to Add the New Unit");
            toolTipUnits.SetToolTip(btnCancelUnitAdd, "Cancel operations");
        }

        public void DisplayUnit()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Units";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridViewUNIT.DataSource = dt;
        }

        private void btnAddNewUnit_Click(object sender, EventArgs e)
        {

            int count = 0;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from Units where unit='" + txtAddUnit.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            count = Convert.ToInt32(dt1.Rows.Count.ToString());

            if (count == 0)
            {
                //---Pass in the SubQuery
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Units Values('" + txtAddUnit.Text + "')";
                cmd.ExecuteNonQuery();

                DisplayUnit();
            }
            else
            {
                MessageBox.Show("This Unit already exist");
            }
         
        }

        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(dataGridViewUNIT.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Units Where id=" + id + "";

            cmd.ExecuteNonQuery();

            DisplayUnit();
            //MessageBox.Show(dataGridViewUSER.SelectedCells[0].Value.ToString());
        }

        private void btnCancelUnitAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
