using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication3.Model;
namespace WebApplication3.Model
{
    public class DAOStudent
    {
        SqlConnection _sqlConn = null;
        SqlCommand _cmd = null;

        public DAOStudent() {
            _sqlConn = new SqlConnection(@"Data Source=FACULTY-218;Initial Catalog=stddb2301F;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public void Create(Student std) {
            if (_sqlConn.State == System.Data.ConnectionState.Closed) { 
                _sqlConn.Open();
            }
            _cmd = new SqlCommand("INSERT INTO STUDENTS VALUES(@STDANME,@GRADE,@EMID)", _sqlConn);
            _cmd.Parameters.AddWithValue("@STDANME", std.StudentName);
            _cmd.Parameters.AddWithValue("@GRADE", std.Grade);
            _cmd.Parameters.AddWithValue("@EMID", std.EmailId);
            _cmd.ExecuteNonQuery();

        }
        public SqlDataReader Read()
        {
            if (_sqlConn.State == System.Data.ConnectionState.Closed)
            {
                _sqlConn.Open();
            }
            _cmd = new SqlCommand("SELECT * FROM STUDENTS", _sqlConn);

            return _cmd.ExecuteReader();

        }

        public void Update(Student std)
        {
            if (_sqlConn.State == System.Data.ConnectionState.Closed)
            {
                _sqlConn.Open();
            }
            _cmd = new SqlCommand("UPDATE STUDENTS SET STDNAME =@STDANME, GRADE= @GRADE,EMAILD =@EMID WHERE ID=@ID", _sqlConn);
            _cmd.Parameters.AddWithValue("@ID", std.StudentId);
            _cmd.Parameters.AddWithValue("@STDANME", std.StudentName);
            _cmd.Parameters.AddWithValue("@GRADE", std.Grade);
            _cmd.Parameters.AddWithValue("@EMID", std.EmailId);
            _cmd.ExecuteNonQuery();
        }
        public void Delete(int stdId)
        {
            if (_sqlConn.State == System.Data.ConnectionState.Closed)
            {
                _sqlConn.Open();
            }
            _cmd = new SqlCommand("DELETE FROM STUDENTS WHERE ID=@ID", _sqlConn);
            _cmd.Parameters.AddWithValue("@ID", stdId);
            _cmd.ExecuteNonQuery();
        }
    }
}