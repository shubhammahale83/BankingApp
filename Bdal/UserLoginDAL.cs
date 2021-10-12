using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBE;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BDAL
{
    public class UserLoginDAL
    {
        public static string connectionStr = ConfigurationManager.ConnectionStrings["OnlineBanking"].ConnectionString;
        SqlConnection connect = new SqlConnection(connectionStr);

        public UserLoginResponseBE UserLoginSave(UserLoginRequestBE request)
        {
            UserLoginResponseBE response = new UserLoginResponseBE();
            try
            {
                SqlCommand spcommand = new SqlCommand("CheckLog", connect);
                spcommand.CommandType = System.Data.CommandType.StoredProcedure;
                spcommand.Parameters.AddWithValue("@Username", request.UserName);
                spcommand.Parameters.AddWithValue("@Password", request.Password);
                
                SqlParameter statusParameter = spcommand.Parameters.Add("@STATUS", SqlDbType.Int);
                statusParameter.Direction = ParameterDirection.Output;

                connect.Open();
                spcommand.ExecuteNonQuery();
                response.Status = Convert.ToInt32(spcommand.Parameters["@STATUS"].Value);
                connect.Close();

            }
            catch (Exception ex)
            {
                response.ErrorMsg = ex.Message;
            }
            return response;
        }
    }
}
