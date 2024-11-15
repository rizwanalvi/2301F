using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
namespace LoginWeb.Model
{
    public class LoginDAO
    {
        SqlConnection _sqlCon = null;
        SqlCommand _cmd = null;
        public LoginDAO() {
            String _conStr = ConfigurationManager.ConnectionStrings["strConn"].ToString();
            _sqlCon = new SqlConnection(@_conStr);
        }
        public void RegisterUser(Loginc lg) {
            if (_sqlCon.State == System.Data.ConnectionState.Closed) {
                _sqlCon.Open();
            }
            _cmd = new SqlCommand("INSERT INTO LOGIN VALUES(@USERNAME,@PASSWORD)", _sqlCon);
            _cmd.Parameters.AddWithValue("@USERNAME", lg.UserName);
            _cmd.Parameters.AddWithValue("@PASSWORD", lg.Password);
            _cmd.ExecuteNonQuery();
        
        }

        public int LoginUser(Loginc lg) {
            if (_sqlCon.State == System.Data.ConnectionState.Closed)
            {
                _sqlCon.Open();
            }
            _cmd = new SqlCommand("SELECT COUNT(*) FROM Login WHERE USERNAME = @USERNAME AND PASS = @PASSWORD", _sqlCon);
            _cmd.Parameters.AddWithValue("@USERNAME", lg.UserName);
            _cmd.Parameters.AddWithValue("@PASSWORD", lg.Password);
            int _user = int.Parse(_cmd.ExecuteScalar().ToString());
            return _user;
        }
    }
}