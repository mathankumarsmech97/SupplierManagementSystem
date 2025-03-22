using BLL;
using Microsoft.ApplicationBlocks.Data;


using Minnotra_Alerts_Windows_Application.App_Code.PropertiesDetails;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{/// 

	public class DAL_Login
	{

        public static string connetion1 = ConfigurationManager.ConnectionStrings["LocalSqlServer0"].ToString();
        

       
      
       
       
        public static DataTable GetCategories(PropertiesDetails bLL_Login)
        {
            try
            {


                return SqlHelper.ExecuteDataset(connetion1, CommandType.StoredProcedure, "GetCategories").Tables[0];



            }
            catch (Exception ex)
            {
                return null;
            }
;
        }
        public static string deleteCategories(PropertiesDetails bLL_Login)
        {
            try
            {


                SqlParameter[] objParam = new SqlParameter[1];
                objParam[0] = new SqlParameter("@AutoID", bLL_Login.AutoID);
                

                 SqlHelper.ExecuteScalar(connetion1,
                    CommandType.StoredProcedure, "deleteCategories", objParam);

                return "true";

            }
            catch (Exception ex)
            {
                return null;
            }
;
        }

        public static string DeleteSupplierManagementDetails(PropertiesDetails bLL_Login)
        {
            try
            {


                SqlParameter[] objParam = new SqlParameter[1];
                objParam[0] = new SqlParameter("@AutoID", bLL_Login.NAutoID);


                SqlHelper.ExecuteScalar(connetion1,
                   CommandType.StoredProcedure, "DeleteSupplierManagementDetails", objParam);

                return "true";

            }
            catch (Exception ex)
            {
                return null;
            }
;
        }

        public static string DeleteCustomerManagementDetails(PropertiesDetails bLL_Login)
        {
            try
            {


                SqlParameter[] objParam = new SqlParameter[1];
                objParam[0] = new SqlParameter("@AutoID", bLL_Login.NAutoID);


                SqlHelper.ExecuteScalar(connetion1,
                   CommandType.StoredProcedure, "DeleteCustomerManagementDetails", objParam);

                return "true";

            }
            catch (Exception ex)
            {
                return null;
            }
;
        }
        public static string AuthUserDetails(PropertiesDetails bLL_Login)
        {
            try
            {
               

                SqlParameter[] objParam = new SqlParameter[2];
                objParam[0] = new SqlParameter("@UserName", bLL_Login.UserName);
                objParam[1] = new SqlParameter("@Password", bLL_Login.Password);

                string status = SqlHelper.ExecuteScalar(connetion1,
                    CommandType.StoredProcedure, "AuthUserDetails", objParam).ToString();

                return status;

            }
            catch (Exception ex)
            {
                return null;
            }
;
        }
        public static string AddCategories(PropertiesDetails bLL_Login)
        {
            try
            {


                SqlParameter[] objParam = new SqlParameter[1];
                objParam[0] = new SqlParameter("@Categories", bLL_Login.CatagorieName);
              

                string status = SqlHelper.ExecuteScalar(connetion1,
                    CommandType.StoredProcedure, "AddCategories", objParam).ToString();

                return status;

            }
            catch (Exception ex)
            {
                return null;
            }
;
        }


        public static DataTable GetMeterDetails(PropertiesDetails bLL_Login)
        {
            try
            {
                SqlParameter[] objpar = new SqlParameter[1];



                

                string con = bLL_Login.Connstring;
                return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Usp_List_AllDevices").Tables[0];



            }
            catch (Exception ex)
            {
                return null;
            }
;
        }
        public static DataTable GetSupplierManagementDetails(PropertiesDetails bLL_Login)
        {
            try
            {


                SqlParameter[] objParam = new SqlParameter[1];
                objParam[0] = new SqlParameter("@CategorieID", bLL_Login.CategorieID);

                return SqlHelper.ExecuteDataset(connetion1, CommandType.StoredProcedure, "GetSupplierManagementDetails", objParam).Tables[0];



            }
            catch (Exception ex)
            {
                return null;
            }
;

        }

        public static DataTable GetCustomerManagementDetails(PropertiesDetails bLL_Login)
        {
            try
            {


              

                return SqlHelper.ExecuteDataset(connetion1, CommandType.StoredProcedure, "GetCustomerManagementDetails").Tables[0];



            }
            catch (Exception ex)
            {
                return null;
            }
;

        }

        public static string InsertSupplierManagementDetails(PropertiesDetails bLL_Login)
        {
            try
            {
                SqlParameter[] objpar = new SqlParameter[6];

                objpar[0] = new SqlParameter("@SupplierName", bLL_Login.SupplierName);
                objpar[1] = new SqlParameter("@GSTNo", bLL_Login.GSTNo);
                objpar[2] = new SqlParameter("@Email", bLL_Login.Email);
                objpar[3] = new SqlParameter("@SupplierAddress", bLL_Login.SupplierAddress);
                objpar[4] = new SqlParameter("@ContactNo", bLL_Login.ContactNo);
                objpar[5] = new SqlParameter("@CategorieID", bLL_Login.CategorieID);




                SqlHelper.ExecuteNonQuery(connetion1, CommandType.StoredProcedure, "InsertSupplierManagementDetails", objpar);

                return null;

            }
            catch (Exception ex)
            {
                return null;
            }
;
        }
        public static string InsertCustomerManagementDetails(PropertiesDetails bLL_Login)
        {
            try
            {
                SqlParameter[] objpar = new SqlParameter[4];

                objpar[0] = new SqlParameter("@CustomerName", bLL_Login.CustomerName);
                objpar[1] = new SqlParameter("@ContactNo", bLL_Login.ContactNo);
                objpar[2] = new SqlParameter("@CustomerPANCARD", bLL_Login.CustomerPANCARD);
                objpar[3] = new SqlParameter("@UserAddress", bLL_Login.UserAddress);
               




                SqlHelper.ExecuteNonQuery(connetion1, CommandType.StoredProcedure, "InsertCustomerManagementDetails", objpar);

                return null;

            }
            catch (Exception ex)
            {
                return null;
            }
;
        }

        public static string UpdateSupplierManagementDetails(PropertiesDetails bLL_Login)
        {
            try
            {
                SqlParameter[] objpar = new SqlParameter[6];

                objpar[0] = new SqlParameter("@AutoID", bLL_Login.NAutoID);
                objpar[1] = new SqlParameter("@SupplierName", bLL_Login.SupplierName);
                objpar[2] = new SqlParameter("@GSTNo", bLL_Login.GSTNo);
                objpar[3] = new SqlParameter("@Email", bLL_Login.Email);
                objpar[4] = new SqlParameter("@SupplierAddress", bLL_Login.SupplierAddress);
                objpar[5] = new SqlParameter("@ContactNo", bLL_Login.ContactNo);
               



                SqlHelper.ExecuteNonQuery(connetion1, CommandType.StoredProcedure, "UpdateSupplierManagementDetails", objpar);

                return null;

            }
            catch (Exception ex)
            {
                return null;
            }
;
        }
        public static string UpdateCustomerManagementDetails(PropertiesDetails bLL_Login)
        {
            try
            {
                SqlParameter[] objpar = new SqlParameter[5];

                objpar[0] = new SqlParameter("@AutoID", bLL_Login.NAutoID);
                objpar[1] = new SqlParameter("@CustomerName", bLL_Login.CustomerName);
                objpar[2] = new SqlParameter("@ContactNo", bLL_Login.ContactNo);
                objpar[3] = new SqlParameter("@CustomerPANCARD", bLL_Login.CustomerPANCARD);
                objpar[4] = new SqlParameter("@UserAddress", bLL_Login.UserAddress);





                SqlHelper.ExecuteNonQuery(connetion1, CommandType.StoredProcedure, "UpdateCustomerManagementDetails", objpar);

                return null;

            }
            catch (Exception ex)
            {
                return null;
            }
;
        }
    }
}
