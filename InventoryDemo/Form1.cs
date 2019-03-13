using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryDemo
{
    public partial class Form1 : Form
    {
        String OrderDetails = "{0, -20}{1, -20}{2, -20}{3, -20}{4, -20}{5, -20}{6, -20}";

        public Form1()
        {
            InitializeComponent();
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstOuput.Items.Add(String.Format(OrderDetails, "Customer ID" , "Firstname" , "Surname" , "Order Made" , "Method of Payment" , "Order Date" , "Price"));
           
            cmbOrderMade.Items.Add("Select Order");
            cmbOrderMade.Items.Add("Account");
            cmbOrderMade.Items.Add("Telephone");
            cmbOrderMade.Items.Add("Instore Order");
            cmbOrderMade.Items.Add("Online Order");


            cmbPayment.Items.Add("Payment Method");
            cmbPayment.Items.Add("Cash");
            cmbPayment.Items.Add("Master Card");
            cmbPayment.Items.Add("Visa Card");
            cmbPayment.Items.Add("Direct Debit");

            lstBrand.Items.Add("Pakistani");
            lstBrand.Items.Add("Turkish");
            lstBrand.Items.Add("Chinese");
            lstBrand.Items.Add("Arabic");
            lstBrand.Items.Add("USA");
            lstBrand.Items.Add("Canadian");

            chkBeans.Checked = false;
            chkFullSet.Checked = false;
            chkRice.Checked = false;
            chkMeat.Checked = false;

            rbEight.Checked = false;
            rbFour.Checked = false;
            rbOne.Checked = false;
            rbTwo.Checked = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to Exit" , "Inventroy System" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);

            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtFirstName.Clear();
            txtSurname.Clear();
            chkBeans.Checked = false;
            chkFullSet.Checked = false;
            chkRice.Checked = false;
            chkMeat.Checked = false;

            rbEight.Checked = false;
            rbFour.Checked = false;
            rbOne.Checked = false;
            rbTwo.Checked = false;


            lstBrand.SelectedItems.Clear();
            lstOuput.Items.Clear();
            lstOuput.Items.Add(String.Format(OrderDetails, "Customer ID", "Firstname", "Surname", "Order Made", "Method of Payment", "Order Date", "price"));
            cmbOrderMade.Text = "Select Order";
            cmbPayment.Text = "Payment Method";
        }

        private void btnAddMore_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtFirstName.Clear();
            txtSurname.Clear();
            chkBeans.Checked = false;
            chkFullSet.Checked = false;
            chkRice.Checked = false;
            chkMeat.Checked = false;

            rbEight.Checked = false;
            rbFour.Checked = false;
            rbOne.Checked = false;
            rbTwo.Checked = false;


            lstBrand.SelectedItems.Clear();
            cmbOrderMade.Text = "Select Order";
            cmbPayment.Text = "Payment Method";
        }

        private void btnOrderItems_Click(object sender, EventArgs e)
        {
            String ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price;

            double Turkish_Price = 4.59;
            double Canadian_Price = 5.59;
            double Pakistani_Price = 6.59;
            double Chinese_Price = 7.59;
            double USA_Price = 8.59;


            ID = txtCustomerID.Text;
            Firstname = txtFirstName.Text;
            Surname = txtSurname.Text;
            SelectOrder = cmbOrderMade.Text;
            SelectType = cmbPayment.Text;
            SelectDate = dateTimePicker1.Text;

            if(lstBrand.Text == "")
            {
                MessageBox.Show("You must Select a brand" , "Brands" , MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
     
            }
            else if((chkBeans.Checked == false) && (chkMeat.Checked == false) && (chkRice.Checked == false))
            {
                MessageBox.Show("You must Select a Item", "Items", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if ((rbOne.Checked == false) && (rbTwo.Checked == false) && (rbFour.Checked == false) && (rbEight.Checked == false))
            {
                MessageBox.Show("You must Select a Qauntity", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            //***********************************************************************************************//


            if (lstBrand.Text == "Canadian" && chkBeans.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format("{0:C}", (Canadian_Price * 1));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname , SelectOrder, SelectType , SelectDate, Price));
            }
            else if (lstBrand.Text == "Canadian" && chkBeans.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format("{0:C}", (Canadian_Price * 2));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Canadian" && chkBeans.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format("{0:C}", (Canadian_Price * 4));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Canadian" && chkBeans.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format("{0:C}", (Canadian_Price * 8));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //***********************************************************************************************//


            if (lstBrand.Text == "Pakistani" && chkBeans.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format("{0:C}", (Pakistani_Price * 1));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Pakistani" && chkBeans.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format("{0:C}", (Pakistani_Price * 2));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Pakistani" && chkBeans.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format("{0:C}", (Pakistani_Price * 4));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Pakistani" && chkBeans.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format("{0:C}", (Pakistani_Price * 8));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }


            //***********************************************************************************************//


            if (lstBrand.Text == "Turkish" && chkBeans.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format("{0:C}", (Turkish_Price * 1));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Turkish" && chkBeans.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format("{0:C}", (Turkish_Price * 2));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Turkish" && chkBeans.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format("{0:C}", (Turkish_Price * 4));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Turkish" && chkBeans.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format("{0:C}", (Turkish_Price * 8));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //***********************************************************************************************//


            if (lstBrand.Text == "Chinese" && chkBeans.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format("{0:C}", (Chinese_Price * 1));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Chinese" && chkBeans.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format("{0:C}", (Chinese_Price * 2));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Chinese" && chkBeans.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format("{0:C}", (Chinese_Price * 4));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Chinese" && chkBeans.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format("{0:C}", (Chinese_Price * 8));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }

            //***********************************************************************************************//


            if (lstBrand.Text == "USA" && chkBeans.Checked == true && rbOne.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 1));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "USA" && chkBeans.Checked == true && rbTwo.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 2));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "USA" && chkBeans.Checked == true && rbFour.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 4));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "USA" && chkBeans.Checked == true && rbEight.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 8));
                lstOuput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }





        }

        private void chkFullSet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFullSet.Checked)
            {
                chkMeat.Checked = true;
                chkRice.Checked = true;
                chkBeans.Checked = true;
            }
            else
            {
                chkBeans.Checked = false;
                chkMeat.Checked = false;
                chkRice.Checked = false;
            }
        }
    }
}
