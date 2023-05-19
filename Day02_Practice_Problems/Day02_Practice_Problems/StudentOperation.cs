using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Day02_Practice_Problems
{
    public class StudentOperation
    {
       public static string ConnectingString= "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDetails2; Integrated Security=true";
        SqlConnection connection=new SqlConnection(ConnectingString);
        public void GetAllStudentDetails()
        {
            try
            {
                StudentDetails studentdetails = new StudentDetails();
                using (this.connection)
                {
                    string query = @"select * from Student";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.CommandType = CommandType.Text;
                    this.connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            studentdetails.Name = reader.GetString(0);
                            studentdetails.Age = reader.GetInt32(1);
                            float Grade = (float)reader.GetDouble(2);
                            Console.WriteLine("Student name:"+studentdetails.Name + "\n" +"Student Age :"+ studentdetails.Age + "\n" +"Student Grade:"+ studentdetails.Grade);
                        }
                    }
                    else
                    {
                        Console.WriteLine("NO RECORDS AVAILABLE");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}
