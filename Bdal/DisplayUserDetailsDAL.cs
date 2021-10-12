using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using BBE;

namespace BDAL
{
    public class DisplayUserDetailsDAL
    {
        public static string connectionStr = ConfigurationManager.ConnectionStrings["OnlineBanking"].ConnectionString;
        SqlConnection connect = new SqlConnection(connectionStr);

        public DisplayUserDetailsResponseBE GetAllUserDetails()
        {
            DisplayUserDetailsResponseBE response = new DisplayUserDetailsResponseBE();
            SqlCommand spCommand = new SqlCommand("DisplayUserDetails", connect);
            spCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter userdetailsda = new SqlDataAdapter(spCommand);
            DataSet userdetailsds = new DataSet();
            userdetailsda.Fill(userdetailsds);
            response.UserDetails = new List<UserRegisterRequestBE>();
            foreach(DataRow row in userdetailsds.Tables[0].Rows)
            {
                UserRegisterRequestBE users = new UserRegisterRequestBE();
                users.CustomerID = row["CustomerID"].ToString();
                users.Address = row["Address"].ToString();
                users.Mnumber = row["Mnumber"].ToString();
                users.Accno = row["Accno"].ToString();
                users.Password = row["Password"].ToString();
                users.Name = row["Name"].ToString();
                response.UserDetails.Add(users);
            }
            return response;
        }
    }
}
