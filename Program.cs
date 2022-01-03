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
            List<Employee> employeeList = new List<Employee>();
            //string connectionString = "Data Source=LAPTOP-K0H6TSU4;Initial Catalog=OFFICE_DB;Integrated Security=True;Pooling=False";
            //GetAllEmployees(connectionString);
            //CreateEmployee(connectionString);
            //UpdateEmployee(connectionString);
            //Console.WriteLine("enter ID to delete");
            //DeleteEmployee(connectionString, int.Parse(Console.ReadLine()));

            // managerDB path \\ 
            List<Manager> managerList = new List<Manager>();
            //string connectionString = "Data Source=LAPTOP-K0H6TSU4;Initial Catalog=ManagerDB;Integrated Security=True;Pooling=False";
            //GetAllManagers(connectionString);
            //CreateManager(connectionString);
            //UpadateManager(connectionString));
            //Console.WriteLine("enter ID to delete");
            //DeleteManager(connectionString,int.Parse(Console.ReadLine()));
           }
            static void GetAllEmployees(string connection,List<Employee> employeeList)
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
                               employeeList.Add(new Employee(dataReader.GetString(1),(dataReader.GetDateTime(2)).ToString(), dataReader.GetString(3), dataReader.GetInt32(4)));
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

            static void CreateEmployee(string connection)
            {

                try
                {
                 Console.WriteLine("Enter name:");
                 string name = Console.ReadLine();
                 Console.WriteLine("Enter birthday:");
                 string Birthyear = Console.ReadLine();
                 Console.WriteLine("Enter email:");
                 string email = Console.ReadLine();
                 Console.WriteLine("Enter salary:");
                 int salart = int.Parse(Console.ReadLine());
                    using (SqlConnection connection1 = new SqlConnection(connection))
                    {
                        connection1.Open();
                        string qury = $@"INSERT INTO Employees(Name,Birthyear,Email,Salart)
                        VALUES('{name}','{Birthyear}','{email}',{salart})";
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

            static void UpdateEmployee(string connection)
            {
                try
                {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter birthday:");
                string Birthyear = Console.ReadLine();
                Console.WriteLine("Enter email:");
                string email = Console.ReadLine();
                Console.WriteLine("Enter salary:");
                int salart = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter ID:");
                int id = int.Parse(Console.ReadLine());
                using (SqlConnection connection1 = new SqlConnection(connection))
                    {
                        connection1.Open();
                        string qury = $@"UPDATE Employees
                                         SET Name = '{name}'
                                          Birthyear ='{Birthyear}'
                                          Email = '{email}'
                                          Salart = {salart}   
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

            static void DeleteEmployee(string connection,int id)
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

            static void GetAllManagers(string connection, List<Manager> managerList)
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
                                Console.WriteLine(execute.GetString(2));
                                Console.WriteLine(execute.GetDateTime(3));
                                Console.WriteLine(execute.GetString(4));
                                Console.WriteLine(execute.GetString(5));
                                managerList.Add(new Manager(execute.GetString(1), execute.GetString(2), (execute.GetDateTime(3)).ToString(), execute.GetString(4), execute.GetString(5)));
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

            static void CreateManager(string connection)
            {

                try
                {
                Console.WriteLine("Enter first name:");
                string firstN = Console.ReadLine();
                Console.WriteLine("Enter last name:");
                string lastN = Console.ReadLine();
                Console.WriteLine("Enter first name:");
                string Birthday = Console.ReadLine();
                Console.WriteLine("Enter first name:");
                string Email = Console.ReadLine();
                Console.WriteLine("Enter first name:");
                string Department = Console.ReadLine();
                using (SqlConnection connection1 = new SqlConnection(connection))
                    {
                        connection1.Open();
                        string qury = $@"INSERT INTO Manager(FirstName,LastName,Birthday,Email,Department)
                        VALUES('{firstN}','{lastN}','{Birthday}','{Email}','{Department}')";
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

            static void UpadateManager(string connection)
            {
                try
                {
                Console.WriteLine("Enter first name:");
                string firstN = Console.ReadLine();
                Console.WriteLine("Enter last name:");
                string lastN = Console.ReadLine();
                Console.WriteLine("Enter first name:");
                string Birthday = Console.ReadLine();
                Console.WriteLine("Enter first name:");
                string Email = Console.ReadLine();
                Console.WriteLine("Enter first name:");
                string Department = Console.ReadLine();
                Console.WriteLine("Enter ID:");
                int id = int.Parse(Console.ReadLine());
                using (SqlConnection connection1 = new SqlConnection(connection))
                    {
                        connection1.Open();
                        string qury = $@"UPDATE Manager
                                         SET FirstName = '{firstN}'
                                             LastName ='{lastN}'
                                             Birthday ='{Birthday}'
                                             Email ='{Email}'
                                             Department ='{Department}'
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

            static void DeleteManager(string connection , int id)
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
