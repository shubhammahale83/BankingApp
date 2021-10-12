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
    public class UserRegisterDAL
    {
        public static string connectionStr = ConfigurationManager.ConnectionStrings["OnlineBanking"].ConnectionString;
        SqlConnection connect = new SqlConnection(connectionStr);
        public UserRegisterResponseBE UserRegisterSave(UserRegisterRequestBE request)
        {
            UserRegisterResponseBE response = new UserRegisterResponseBE();
            try {
                SqlCommand spcommand = new SqlCommand("procregistration", connect);
                spcommand.CommandType = System.Data.CommandType.StoredProcedure;
                spcommand.Parameters.AddWithValue("@Name", request.Name);
                spcommand.Parameters.AddWithValue("@Mnumber", request.Mnumber);
                spcommand.Parameters.AddWithValue("@Adharnumber", request.Adharnumber);
                spcommand.Parameters.AddWithValue("@Address", request.Address);
                spcommand.Parameters.AddWithValue("@Accno", request.Accno);
                spcommand.Parameters.AddWithValue("@Username", request.UserName);
                spcommand.Parameters.AddWithValue("@Password", request.Password);
                spcommand.Parameters.AddWithValue("@statement", request.Statement);
                
                SqlParameter statusParameter = spcommand.Parameters.Add("@STATUS", SqlDbType.Int);
                statusParameter.Direction = ParameterDirection.Output;

                connect.Open();
                spcommand.ExecuteNonQuery();
                response.Status = Convert.ToInt32(spcommand.Parameters["@STATUS"].Value);

            }
            catch (Exception ex) {
                response.ErrorMsg = ex.Message;
            }
            return response;
        }
    }       
}
