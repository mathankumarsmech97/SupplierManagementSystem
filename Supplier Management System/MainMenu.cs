using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supplier_Management_System
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private async void btnProductCatagories_Click(object sender, EventArgs e)
        {
            ProductCategories ProductCategories = new ProductCategories();
            ProductCategories.Show();
        }

        private async void btnSupplierManagement_Click(object sender, EventArgs e)
        {
            SupplierManagement SupplierManagement = new SupplierManagement();
            SupplierManagement.Show();
        }

        private async void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            CustomerManagement CustomerManagement = new CustomerManagement();
            CustomerManagement.Show();
        }
    }
    
}
