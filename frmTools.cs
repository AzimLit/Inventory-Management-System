using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace StockManagementSystem
{
    public partial class frmTools : Form
    {
        public frmTools()
        {
            InitializeComponent();
        }

        private void pictMenu03_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintConfig_Click(object sender, EventArgs e)
        {
            printDialogTool.ShowDialog(); 
        }

        private void panelFloatingBlue_Paint(object sender, PaintEventArgs e)
        {
            toolTipTOOLS.SetToolTip(btnPrintConfig, "Printer configuration");
            toolTipTOOLS.SetToolTip(btnConverter, "Units Conveter tools");
            toolTipTOOLS.SetToolTip(btnMap, "Show Map");
            toolTipTOOLS.SetToolTip(btnStatistics, "Statistics Tools");
            toolTipTOOLS.SetToolTip(btnCalculator, "Calculator Tools");
            toolTipTOOLS.SetToolTip(btnInternetBrowner, "Internet browser");
            toolTipTOOLS.SetToolTip(btnCancelOperation, "Exit this module");
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Process.Start("Calc");
        }

        private void btnInternetBrowner_Click(object sender, EventArgs e)
        {

        }
    }
}
