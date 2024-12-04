using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Person_CustomerClasses
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chk_OnMailingList(object sender, EventArgs e)
        {

        }

        private void lbl_Output(object sender, EventArgs e)
        {

        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            // Create a new Customer object and set its properties
            Customer customer = new Customer
            {
                Name = txtBox_Name.Text,
                Address = txtBox_Address.Text,
                TelephoneNumber = txtBox_Phone.Text,
                CustomerNumber = int.TryParse(txtBox_Customer.Text, out int number) ? number : 0,
                OnMailingList = OnMailingList.Checked
            };

            // Display the customer information
            lbl_output.Text = $"Name: {customer.Name}\n" +
                              $"Address: {customer.Address}\n" +
                              $"Telephone: {customer.TelephoneNumber}\n" +
                              $"Customer Number: {customer.CustomerNumber}\n" +
                              $"On Mailing List: {customer.OnMailingList}";
        }

        public class Person
        {
            // Properties for the person's name, address, and telephone number
            public string Name { get; set; }
            public string Address { get; set; }
            public string TelephoneNumber { get; set; }
        }

        public class Customer : Person
        {
            // Properties for customer number and mailing list preference
            public int CustomerNumber { get; set; }
            public bool OnMailingList { get; set; }
        }

        private void OnMailingList_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_output_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtBox_Name.Clear();
            txtBox_Address.Clear();
            txtBox_Phone.Clear();
            txtBox_Customer.Clear();
            OnMailingList.Checked = false;
            lbl_output.Text = string.Empty; // Clear the output label
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
