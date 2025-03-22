using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Minnotra_Alerts_Windows_Application.App_Code.PropertiesDetails;

namespace Supplier_Management_System
{
    public partial class ProductCategories : Form
    {
        public ProductCategories()
        {
            InitializeComponent();
            loadGrid();


        }

        private void btnAddCategories_Click(object sender, EventArgs e)
        {
            string ProductCategories = txtCategories.Text;

            PropertiesDetails obj = new PropertiesDetails();

            BLL_Login bLLObj_ = new BLL_Login();

            obj.CatagorieName = ProductCategories;

            string status = bLLObj_.AddCategories(obj);

            if (status == "True")
            {
                MessageBox.Show("Categories Added Successfully");
                loadGrid();
            }
            else
            {
                MessageBox.Show("Failed to Add Categories");
            }

            txtCategories.Text = "";

        }

        public void loadGrid()
        {
            PropertiesDetails obj = new PropertiesDetails();

            BLL_Login bLLObj_ = new BLL_Login();

            DataTable dt = bLLObj_.GetCategories(obj);

            dataGridView1.DataSource = dt;

          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is part of the "Delete" column
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Confirm deletion
                var confirmResult = MessageBox.Show("Are you sure you want to delete this record?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    PropertiesDetails obj = new PropertiesDetails();

                    BLL_Login bLLObj_ = new BLL_Login();

                    int idToDelete = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["AutoID"].Value);

                    obj.AutoID = idToDelete;

                    bLLObj_.deleteCategories(obj);

                  
                   
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    loadGrid();

                    MessageBox.Show("Record deleted successfully!");
                }
            }
        }

    }
}
