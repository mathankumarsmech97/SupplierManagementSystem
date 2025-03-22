using BLL;
using Minnotra_Alerts_Windows_Application.App_Code.PropertiesDetails;
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
    public partial class CustomerManagement : Form
    {
        public CustomerManagement()
        {
            InitializeComponent();
            LoadGrid();
        }
        public void LoadGrid()
        {
            PropertiesDetails obj = new PropertiesDetails();

            BLL_Login bLLObj_ = new BLL_Login();

          

            DataTable dt = bLLObj_.GetCustomerManagementDetails(obj);


            dataGridView1.DataSource = dt;
            dataGridView1.Columns[3].Visible = false;
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Add"].Index == e.RowIndex >= 0)
            {
                try
                {
                  
                
                    
                        int index = e.RowIndex;
                        DataGridViewRow select = dataGridView1.Rows[index];

                        PropertiesDetails obj = new PropertiesDetails();

                        BLL_Login bLLObj_ = new BLL_Login();

                        obj.CustomerName = select.Cells[4].Value.ToString();
                        obj.ContactNo = select.Cells[5].Value.ToString();
                        obj.CustomerPANCARD = select.Cells[6].Value.ToString();
                        obj.UserAddress = select.Cells[7].Value.ToString();
                      

                        bLLObj_.InsertCustomerManagementDetails(obj);

                        LoadGrid();

                        MessageBox.Show("Record deleted successfully!");
                   



                }
                catch (Exception ex)
                {

                }
            }

            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index == e.RowIndex >= 0)
            {
                try
                {

                    var confirmResult = MessageBox.Show("Are you sure you want to delete this record?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        PropertiesDetails obj = new PropertiesDetails();

                        BLL_Login bLLObj_ = new BLL_Login();
                        int index = e.RowIndex;
                        DataGridViewRow select = dataGridView1.Rows[index];


                        obj.NAutoID = select.Cells[3].Value.ToString();



                        bLLObj_.DeleteCustomerManagementDetails(obj);

                        LoadGrid();

                        MessageBox.Show("Record deleted successfully!");
                    }





                }
                catch (Exception ex)
                {

                }
            }

            if (e.ColumnIndex == dataGridView1.Columns["update"].Index == e.RowIndex >= 0)
            {
                try
                {

                    int index = e.RowIndex;
                    DataGridViewRow select = dataGridView1.Rows[index];

                    PropertiesDetails obj = new PropertiesDetails();

                    BLL_Login bLLObj_ = new BLL_Login();

                    obj.NAutoID = select.Cells[3].Value.ToString();


                    obj.CustomerName = select.Cells[4].Value.ToString();
                    obj.ContactNo = select.Cells[5].Value.ToString();
                    obj.CustomerPANCARD = select.Cells[6].Value.ToString();
                    obj.UserAddress = select.Cells[7].Value.ToString();




                    bLLObj_.UpdateCustomerManagementDetails(obj);

                    LoadGrid();

                    MessageBox.Show("Updated deleted successfully!");






                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
