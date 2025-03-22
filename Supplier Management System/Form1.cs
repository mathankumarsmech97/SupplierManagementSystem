using System.Data.Common;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Minnotra_Alerts_Windows_Application.App_Code.PropertiesDetails;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace Supplier_Management_System
{
    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string UserName = txtUserName.Text;
                string Password = txtpassword.Text;

                PropertiesDetails obj = new PropertiesDetails();

                BLL_Login bLLObj_ = new BLL_Login();

                obj.UserName = UserName;
                obj.Password = Password;

              string status =  bLLObj_.AuthUserDetails(obj);

                if (status == "True")
                {
                    MainMenu MainMenu = new MainMenu();
                    MainMenu.Show();

                    txtUserName.Text = "";
                    txtpassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }   
            }
            catch (Exception ex)
            {

            }






        }

       
    }
}
