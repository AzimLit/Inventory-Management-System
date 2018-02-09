using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class frmMainSTK : Form
    {
        public frmMainSTK()
        {
            //------------------Thread created for the Splash screen
            Thread t = new Thread(new ThreadStart(LoadigSplash));
            t.Start();
            //------------------------------------------------------

            InitializeComponent();

            for (int i = 0; i <= 1000; i++)
                Thread.Sleep(10);
            t.Abort(); // Complete
        }

        //---------------Splash form loading -------------
        void LoadigSplash()
        {
            frmSplasSTK frm = new frmSplasSTK();
            Application.Run(frm);
        }
        //------------------------------------------------

        //----- Modules for the interface---------------
        int varMenu = 0;

        public void varMenuState()
        {
            if (varMenu == 0)
            {
                varMenu = 1;
            }
            else
            {
                varMenu = 0;
            }


        }

        public void ReducePannels()
        {
            panelMenu01.Height = 95; // btnMenu01.Height + 5;
            panelMenu02.Height = 95; // btnMenu02.Height + 5;
            panelMenu03.Height = 95; // btnMenu03.Height + 5;
           
        }

        public void ReajustPanels()
        {
            panelMenu02.Top = panelMenu01.Bottom + 5;
            panelMenu03.Top = panelMenu02.Bottom + 5;
            
            
        }
        //Image bkg = Image.FromFile(@"D:\Documents\New folder\bkg0728.PNG");
        Image ArrowUp = Image.FromFile(@"C:\Users\aziml\source\repos\StockManagementSystem\StockManagementSystem\Images\Arrow_Horizontal_YallowBlue.png");
        Image ArrowDown = Image.FromFile(@"C:\Users\aziml\source\repos\StockManagementSystem\StockManagementSystem\Images\Arrow_Vertical_YellowBlue.png");
        //----------------------------------------------



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // The user wants to exit the application. Close everything down.
            Application.Exit();
        }

        private void frmMainSTK_Load(object sender, EventArgs e)
        {
            //----Call ReducePannels
            ReducePannels();

            //----Call ReajustPanel
            ReajustPanels();

            //-----------------ToolTiPs
            toolTipMainMenu.SetToolTip(btnUnit, "Add new Unit");
            toolTipMainMenu.SetToolTip(btnProduct, "Add/ Update Product");
            toolTipMainMenu.SetToolTip(btnDealer, "Add or Update Dealer");
            toolTipMainMenu.SetToolTip(btnUser, "Add New User");
            toolTipMainMenu.SetToolTip(btnSales, "Sale products");
            toolTipMainMenu.SetToolTip(btnPurchaseMaster, "Purchase products");

        }

        private void btnMenu01_Click(object sender, EventArgs e)
        {
            // Call varMenuState Methode/function
            varMenuState();

            if (varMenu == 0)
            {
                panelMenu01.Height = 95; // btnMenu01.Height + 5;
                btnMenu01.BackgroundImage = ArrowUp;

            }

            if (varMenu == 1)
            {
                panelMenu01.Height = 290;
                btnMenu01.BackgroundImage = ArrowDown;
            }


            // // Call ReajustPanel
            ReajustPanels();
        }

        private void btnMenu02_Click(object sender, EventArgs e)
        {
            // Call varMenuState Methode/function
            varMenuState();

            if (varMenu == 0)
            {
                panelMenu02.Height = 95; // btnMenu02.Height + 5;
                btnMenu02.BackgroundImage = ArrowUp;
            }

            if (varMenu == 1)
            {
                panelMenu02.Height = 290;
                btnMenu02.BackgroundImage = ArrowDown;
            }

            //-----Call ReajustPanel
            ReajustPanels();
        }

        private void btnMenu03_Click(object sender, EventArgs e)
        {
            // Call varMenuState Methode/function
            varMenuState();

            if (varMenu == 0)
            {
                panelMenu03.Height = 95; // btnMenu03.Height + 5;
                btnMenu03.BackgroundImage = ArrowUp;
            }

            if (varMenu == 1)
            {
                panelMenu03.Height = 290;
                btnMenu03.BackgroundImage = ArrowDown;
            }

            //----Call ReajustPanel
            ReajustPanels();
        }

        private void panelMenu02_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLblAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLblAddNewUnit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLblAddProdName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkAddDealer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmAddUser addUser = new frmAddUser();
            addUser.Show();
        }

        private void btnDealer_Click(object sender, EventArgs e)
        {
            frmDealerInfo addDealer = new frmDealerInfo();
            addDealer.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmAdd_ProductName addProdName = new frmAdd_ProductName();
            addProdName.Show();

        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            frmUnit addUnit = new frmUnit();
            addUnit.Show();
        }

        private void btnPrintConfig_Click(object sender, EventArgs e)
        {
            //frmPrinterConfig PrinterDialog = new frmPrinterConfig();
            //PrinterDialog.Show();

            frmTools AppTools = new frmTools();
            AppTools.Show();
        }

        private void btnPurchaseMaster_Click(object sender, EventArgs e)
        {
            frmPurchaseMaster PurchaseMaster = new frmPurchaseMaster();
            PurchaseMaster.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSales SalesApp = new frmSales();
            SalesApp.Show();
        }
    }
}
