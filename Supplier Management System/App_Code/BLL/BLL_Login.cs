using System;

/// <summary>
/// Summary description for BLL_Login
/// </summary>
/// 

using DAL;
using System.Data;

using Minnotra_Alerts_Windows_Application.App_Code.PropertiesDetails;

namespace BLL
{
	public class BLL_Login
	{
        #region Properties


       


        #endregion




        //public DataTable AlertGetSp(PropertiesDetails properties)
        //{

        //    try
        //    {
        //        return DAL_Login.AlertGetSp(properties);
        //    }
        //    catch
        //    {
        //        return null;
        //    }
           
        //}
        public DataTable GetSupplierManagementDetails(PropertiesDetails properties)
        {

            try
            {
                return DAL_Login.GetSupplierManagementDetails(properties);
            }
            catch
            {
                return null;
            }

        }
        public DataTable GetCustomerManagementDetails(PropertiesDetails properties)
        {

            try
            {
                return DAL_Login.GetCustomerManagementDetails(properties);
            }
            catch
            {
                return null;
            }

        }
        public string deleteCategories(PropertiesDetails properties)
        {

            try
            {
                return DAL_Login.deleteCategories(properties);
            }
            catch
            {
                return null;
            }

        }

        public string DeleteSupplierManagementDetails(PropertiesDetails properties)
        {

            try
            {
                return DAL_Login.DeleteSupplierManagementDetails(properties);
            }
            catch
            {
                return null;
            }

        }
        public string DeleteCustomerManagementDetails(PropertiesDetails properties)
        {

            try
            {
                return DAL_Login.DeleteCustomerManagementDetails(properties);
            }
            catch
            {
                return null;
            }

        }


        public DataTable GetCategories(PropertiesDetails properties)
        {

            try
            {
                return DAL_Login.GetCategories(properties);
            }
            catch
            {
                return null;
            }

        }
        public string AuthUserDetails(PropertiesDetails properties)
        {

            try
            {
                return DAL_Login.AuthUserDetails(properties);
            }
            catch
            {
                return null;
            }

        }
        public string AddCategories(PropertiesDetails properties)
        {

            try
            {
                return DAL_Login.AddCategories(properties);
            }
            catch
            {
                return null;
            }

        }



        public string InsertSupplierManagementDetails(PropertiesDetails properties)
        {

            try
            {
                return DAL_Login.InsertSupplierManagementDetails(properties);
            }
            catch
            {
                return null;
            }

        }

        public string InsertCustomerManagementDetails(PropertiesDetails properties)
        {

            try
            {
                return DAL_Login.InsertCustomerManagementDetails(properties);
            }
            catch
            {
                return null;
            }

        }

        public string UpdateSupplierManagementDetails(PropertiesDetails properties)
        {

            try
            {
                return DAL_Login.UpdateSupplierManagementDetails(properties);
            }
            catch
            {
                return null;
            }

        }
        public string UpdateCustomerManagementDetails(PropertiesDetails properties)
        {

            try
            {
                return DAL_Login.UpdateCustomerManagementDetails(properties);
            }
            catch
            {
                return null;
            }

        }
    }
}