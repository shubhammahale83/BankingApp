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
    public class WithdrawDAL
    {
        public static string connectionStr = ConfigurationManager.ConnectionStrings["OnlineBanking"].ConnectionString;
        SqlConnection connect = new SqlConnection(connectionStr);
        WithdrawResponseBE response = new WithdrawResponseBE();
        public WithdrawResponseBE GetBalance(WithdrawRequestBE request)
        {
            SqlCommand cmd = new SqlCommand("depamt", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accno", request.Accno);
            SqlDataReader responsedr;
            connect.Open();
            responsedr = cmd.ExecuteReader();
            while (responsedr.Read())
            {
                response.amount = Convert.ToInt32(responsedr["Amount"]);
            }
            connect.Close();
            return response;
        }

        public WithdrawResponseBE GetWithdraw(WithdrawRequestBE request)
        {
            SqlCommand cmd1 = new SqlCommand("procdeposit", connect);
            cmd1.CommandType = System.Data.CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@accno", request.Accno);
            SqlDataReader responsedr;
            connect.Open();
            responsedr = cmd1.ExecuteReader();
            while (responsedr.Read())
            {
                response.amount = Convert.ToInt32(responsedr["Amount"]);
            }

            SqlCommand cmd = new SqlCommand("procdepositcheck", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accno", request.Accno);
            cmd.Parameters.AddWithValue("@ifsccode", request.ifsccode);
            cmd.Parameters.AddWithValue("@amount", Convert.ToInt32(response.amount) + Convert.ToInt32(request.Amount));

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            return response;
        } 
    }
}
