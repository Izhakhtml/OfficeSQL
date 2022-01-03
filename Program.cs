using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // offifeDB path \\
            //List<Employee> employeeList = new List<Employee>();
            //string connectionString = "Data Source=LAPTOP-K0H6TSU4;Initial Catalog=OFFICE_DB;Integrated Security=True;Pooling=False";
            //GetAllEmployees(connectionString);
            //CreateEmployee(connectionString);
            //Console.WriteLine("enter ID");
            //updateEmployee(connectionString,int.Parse(Console.ReadLine()));
            //Console.WriteLine("enter ID to delete");
            //DeleteEmployee(connectionString, int.Parse(Console.ReadLine()));

            // managerDB path \\ 
            //List<Manager> managerList = new List<Manager>();
            //string connectionString = "Data Source=LAPTOP-K0H6TSU4;Initial Catalog=ManagerDB;Integrated Security=True;Pooling=False";
            //GetAllManagers(connectionString);
            //CreateManager(connectionString);
            //Console.WriteLine("enter ID");
            //UpadateManager(connectionString,int.Parse(Console.ReadLine()));
            //Console.WriteLine("enter ID to delete");
            //DeleteManager(connectionString,int.Parse(Console.ReadLine()));

            void GetAllEmployees(string connection)
            {
                try
                {
                    using (SqlConnection connection1 = new SqlConnection(connection))
                    {
                        connection1.Open();
                        string qury = @"SELECT * FROM Employees";
                        SqlCommand command = new SqlCommand(qury, connection1);
                        SqlDataReader dataReader = command.ExecuteReader();
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                Console.WriteLine(dataReader.GetString(1));
                                Console.WriteLine(dataReader.GetDateTime(2));
                                Console.WriteLine(dataReader.GetString(3));
                                Console.WriteLine(dataReader.GetInt32(4));
                            }
                        }
                        else
                        {
                            Console.WriteLine("the table empty");
                        }
                        connection1.Close();
                    }

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            void CreateEmployee(string connection)
            {

                try
                {
                    using (SqlConnection connection1 = new SqlConnection(connection))
                    {
                        connection1.Open();
                        string qury = $@"INSERT INTO Employees(Name,Birthyear,Email,Salart)
                        VALUES('{Console.ReadLine()}','{Console.ReadLine()}','{ Console.ReadLine()}',{int.Parse(Console.ReadLine())})";
                        SqlCommand command = new SqlCommand(qury, connection1);
                        int Execute = command.ExecuteNonQuery();
                        Console.WriteLine(Execute);
                        connection1.Close();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            void updateEmployee(string connection,int id)
            {
                try
                {
                    using(SqlConnection connection1 = new SqlConnection(connection))
                    {
                        connection1.Open();
                        string qury = $@"UPDATE Employees
                                         SET Name = '{Console.ReadLine()}'
                                          Birthyear ='{Console.ReadLine()}'
                                          Email = '{Console.ReadLine()}'
                                          Salart = {int.Parse(Console.ReadLine())}   
                                         WHERE Id={id}";
                        SqlCommand command = new SqlCommand(qury,connection1);
                        int Execute = command.ExecuteNonQuery();
                        Console.WriteLine(Execute);
                        connection1.Close();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            void DeleteEmployee(string connection,int id)
            {
                try
                {
                    using (SqlConnection connection1 = new SqlConnection(connection))
                    {
                        connection1.Open();
                        string qury = $@"DELETE FROM Employees WHERE Id={id}";
                        SqlCommand command = new SqlCommand(qury, connection1);
                        int Execute = command.ExecuteNonQuery();
                        Console.WriteLine(Execute);
                        connection1.Close();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            void GetAllManagers(string connection)
            {
                try
                {
                    using (SqlConnection connection1 = new SqlConnection(connection))
                    {
                        connection1.Open();
                        string qury = $@"SELECT * FROM Manager";
                        SqlCommand command = new SqlCommand(qury, connection1);
                        SqlDataReader execute = command.ExecuteReader();
                        if (execute.HasRows)
                        {
                            while (execute.Read())
                            {
                                Console.WriteLine(execute.GetString(1));
                                Console.WriteLine(execute.GetDateTime(2));
                                Console.WriteLine(execute.GetString(3));
                                Console.WriteLine(execute.GetInt32(4));
                            }
                        }
                        else
                        {
                            Console.WriteLine("the table empty");
                        }
                        connection1.Close();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            void CreateManager(string connection)
            {

                try
                {
                    using (SqlConnection connection1 = new SqlConnection(connection))
                    {
                        connection1.Open();
                        string qury = $@"INSERT INTO Manager(FirstName,LastName,Birthday,Email,Department)
                        VALUES('{Console.ReadLine()}','{ Console.ReadLine()}','{Console.ReadLine()}','{Console.ReadLine()}','{Console.ReadLine()}')";
                        SqlCommand command = new SqlCommand(qury, connection1);
                        int Execute = command.ExecuteNonQuery();
                        Console.WriteLine(Execute);
                        connection1.Close();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            void UpadateManager(string connection, int id)
            {
                try
                {
                    using (SqlConnection connection1 = new SqlConnection(connection))
                    {
                        connection1.Open();
                        string qury = $@"UPDATE Manager
                                         SET FirstName = '{Console.ReadLine()}'
                                             LastName ='{Console.ReadLine()}'
                                             Birthday ='{Console.ReadLine()}'
                                             Email ='{Console.ReadLine()}'
                                             Department ='{Console.ReadLine()}'
                                         WHERE Id={id}";
                        SqlCommand command = new SqlCommand(qury, connection1);
                        int Execute = command.ExecuteNonQuery();
                        Console.WriteLine(Execute);
                        connection1.Close();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            void DeleteManager(string connection , int id)
            {
                try
                {
                    using (SqlConnection connection1 = new SqlConnection(connection))
                    {
                        connection1.Open();
                        string qury = $@"DELETE FROM Manager WHERE Id={id}";
                        SqlCommand command = new SqlCommand(qury, connection1);
                        int Execute = command.ExecuteNonQuery();
                        Console.WriteLine(Execute);
                        connection1.Close();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
