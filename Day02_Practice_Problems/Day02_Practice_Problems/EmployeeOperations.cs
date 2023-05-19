using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day02_Practice_Problems
{
    public class EmployeeOperations
    {
        public static string ConnectingString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeeManagementService;Integrated Security=true";
        SqlConnection connection = new SqlConnection(ConnectingString);
        public void GetAllEmployeeDetails()
        {
            try
            {
                EmployeeDetails empdetails = new EmployeeDetails();
                using(this.connection)
                {
                    string queryE= @"select * from EmployeeRecord";
                    SqlCommand cmd = new SqlCommand(queryE, connection);
                    cmd.CommandType = CommandType.Text;
                    this.connection.Open();
                    SqlDataReader read = cmd.ExecuteReader();
                    if(read.HasRows)
                    {
                        while(read.Read())
                        {
                            empdetails.EmployeeId = read.GetInt32(0);
                            empdetails.Name = read.GetString(1);
                            empdetails.Age = read.GetInt32(2);
                            empdetails.Salary = read.GetInt32(3);
                            Console.WriteLine("Employee Id:"+empdetails.EmployeeId + "\n" + "Employee Name:" + empdetails.Name + "\n" + "Employee Age:" + empdetails.Age + "\n" + "Employee Salary:" + empdetails.Salary);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Revcords Found");
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
        public void AddEmployee(EmployeeDetails employeeDetails)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand cmd = new SqlCommand("AddEmployee", this.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", employeeDetails.Name);
                    cmd.Parameters.AddWithValue("@Age", employeeDetails.Age);
                    cmd.Parameters.AddWithValue("@Salary", employeeDetails.Salary);
                    this.connection.Open();
                    int rowseffected = cmd.ExecuteNonQuery();
                    this.connection.Close();
                    if (rowseffected > 0)
                    {
                        Console.WriteLine("Added Employee succesfully");
                    }
                    else
                        Console.WriteLine("Employee Added Unsuccessfull");
                }
            }
            catch(Exception ex )
            {
                throw new Exception (ex.Message);
            }
        }
        public void DeleteEmployee(int EmployeeId)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand cmd = new SqlCommand("DeleteEmployee", this.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                    this.connection.Open();
                    int rowseffected = cmd.ExecuteNonQuery();
                    this.connection.Close();
                    if (rowseffected > 0)
                    {
                        Console.WriteLine("Deleted Employee succesfully");
                    }
                    else
                        Console.WriteLine("Employee Delete Unsuccessfull");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpadteEmployee(int Id,string Name)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand cmd = new SqlCommand("UpdateEmployee", this.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeId", Id);
                    cmd.Parameters.AddWithValue("@Name",Name);
                    this.connection.Open();
                    int rowseffected = cmd.ExecuteNonQuery();
                    this.connection.Close();
                    if (rowseffected > 0)
                    {
                        Console.WriteLine("Updated Employee succesfully");
                    }
                    else
                        Console.WriteLine("Employee Updated Unsuccessfull");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<EmployeeDetails> emplist = new List<EmployeeDetails>();
        public void AddEmployeeToEmployeeManagementService(List<EmployeeDetails> emplist)
        {
            emplist.ForEach(EmployeeData =>
            {
                Console.WriteLine("Employee is adding to list :" + EmployeeData.Name);
                this.AddEmployee(EmployeeData);
                Console.WriteLine("Employee has added :" + EmployeeData.Name);
            });
        }
    }
}
