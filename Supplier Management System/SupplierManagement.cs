using BLL;
using Minnotra_Alerts_Windows_Application.App_Code.PropertiesDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supplier_Management_System
{
    public partial class SupplierManagement : Form
    {
        bool status;
        public SupplierManagement()
        {
            InitializeComponent();

            loadDropDown();
            LoadGrid();
          
        }
        public void LoadGrid()
        {
            PropertiesDetails obj = new PropertiesDetails();

            BLL_Login bLLObj_ = new BLL_Login();

            obj.CategorieID = comCatagories.SelectedValue.ToString();

            DataTable dt = bLLObj_.GetSupplierManagementDetails(obj);
           

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }
        public void loadDropDown()
        {
            PropertiesDetails obj = new PropertiesDetails();

            BLL_Login bLLObj_ = new BLL_Login();

            DataTable dt = bLLObj_.GetCategories(obj);

            comCatagories.DataSource = dt;
            comCatagories.DisplayMember = "CategoriesName";
            comCatagories.ValueMember = "AutoID";

            status = true;

        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["Add"].Index == e.RowIndex >= 0)
            {
                try
                {
                    string comID = comCatagories.SelectedValue.ToString();
                    if (comID == "" || comID == null)
                    {
                        MessageBox.Show("Select Catagories");
                    }
                    else
                    {
                        int index = e.RowIndex;
                        DataGridViewRow select = dataGridView1.Rows[index];

                        PropertiesDetails obj = new PropertiesDetails();

                        BLL_Login bLLObj_ = new BLL_Login();

                        obj.SupplierName = select.Cells[4].Value.ToString();
                        obj.GSTNo = select.Cells[5].Value.ToString();
                        obj.Email = select.Cells[6].Value.ToString();
                        obj.SupplierAddress = select.Cells[7].Value.ToString();
                        obj.ContactNo = select.Cells[8].Value.ToString();
                        obj.CategorieID = comCatagories.SelectedValue.ToString();

                        bLLObj_.InsertSupplierManagementDetails(obj);

                        LoadGrid();

                        MessageBox.Show("Record deleted successfully!");
                    }
                   


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

                       

                        bLLObj_.DeleteSupplierManagementDetails(obj);

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


                    obj.SupplierName = select.Cells[4].Value.ToString();
                    obj.GSTNo = select.Cells[5].Value.ToString();
                    obj.Email = select.Cells[6].Value.ToString();
                    obj.SupplierAddress = select.Cells[7].Value.ToString();
                    obj.ContactNo = select.Cells[8].Value.ToString();
                    obj.CategorieID = comCatagories.SelectedValue.ToString();

                    bLLObj_.UpdateSupplierManagementDetails(obj);

                    LoadGrid();

                    MessageBox.Show("Updated deleted successfully!");






                }
                catch (Exception ex)
                {

                }
            }
        }

      

        private void comCatagories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(status == true)
            {
                LoadGrid();
            }
          
        }
    }
}
