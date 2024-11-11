using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace WebAppImageData.Model
{
    public class StudenDAO
    {
        SqlConnection _sqlConn = null;
        public StudenDAO() {
            String _Config = System.Configuration.ConfigurationManager.ConnectionStrings["dbConn"].ToString();
            _sqlConn = new SqlConnection(@_Config);
        }

        public void Create(Student std) {
            if (_sqlConn.State == System.Data.ConnectionState.Closed)
            {
                _sqlConn.Open();
                SqlCommand _cmd = new SqlCommand("INSERT INTO STUDENTS VALUES(@STDNAME,@IMGPATH)", _sqlConn);
                _cmd.Parameters.AddWithValue("@STDNAME", std.StudentName);
                _cmd.Parameters.AddWithValue("@IMGPATH", std.ImgPath);
                _cmd.ExecuteNonQuery();
                _sqlConn.Close();
            }
        }
        public SqlDataReader Read() {
            SqlDataReader _dRead = null;
            if (_sqlConn.State == System.Data.ConnectionState.Closed)
            {
                _sqlConn.Open();
                SqlCommand _cmd = new SqlCommand("SELECT * FROM STUDENTS", _sqlConn);
                _dRead = _cmd.ExecuteReader();
            }
            return _dRead;

        }
    }
}