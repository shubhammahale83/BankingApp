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
    public class DepositeDAL
    {
        public static string connectionStr = ConfigurationManager.ConnectionStrings["OnlineBanking"].ConnectionString;
        SqlConnection connect = new SqlConnection(connectionStr);
        public DepositeResponseBE GetBalance(DepositeRequestBE request)
        {
            DepositeResponseBE response = new DepositeResponseBE();

            SqlCommand cmd = new SqlCommand("procdeposit", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accono", request.Accno);
            cmd.Parameters.AddWithValue("@ifsccode", request.ifsccode);
            SqlDataReader responsedr;
            connect.Open();
            responsedr = cmd.ExecuteReader();
            while (responsedr.Read())
            {
                response.currentbalance = (responsedr["Amount"].ToString());
            }
            connect.Close();
            return response;
        }
        public DepositeResponseBE GetDeposite(DepositeRequestBE request)
        {
            DepositeResponseBE response = new DepositeResponseBE();

            SqlCommand spCommand = new SqlCommand("depamt", connect);
            spCommand.CommandType = System.Data.CommandType.StoredProcedure;
            int a = Convert.ToInt32(response.currentbalance) + Convert.ToInt32(response.amount);
            spCommand.Parameters.AddWithValue("@accno", request.Accno.ToString());
            spCommand.Parameters.AddWithValue("@ifsccode", request.ifsccode.ToString());
            spCommand.Parameters.AddWithValue("@amount", a.ToString());
            SqlDataReader responsedr;
            connect.Open();
            responsedr = spCommand.ExecuteReader();
            while (responsedr.Read())
            {
                response.currentbalance = (responsedr["Amount"].ToString());
            }
            connect.Close();
            return response;
        }
    }
    
}
