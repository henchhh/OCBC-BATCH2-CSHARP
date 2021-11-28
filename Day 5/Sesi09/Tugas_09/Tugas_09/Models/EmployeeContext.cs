using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Tugas_09.Models
{
    public class EmployeeContext
    {
        EmployeeItem employeeItem = new EmployeeItem();
        public string ConnectionString { get; set; }
        public EmployeeContext(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<EmployeeItem> GetAllEmployee()
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")
                        });
                    }
                }
            }
            return list;
        }

        public List<EmployeeItem> GetEmployee(int id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")
                        });
                    }
                }
            }
            return list;
        }
        public List<EmployeeItem> CreateEmployee(EmployeeItem employeeItem)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO employee VALUES(@id,@nama,@jenis_kelamin,@alamat)", conn);
                cmd.Parameters.AddWithValue("@id", employeeItem.id);
                cmd.Parameters.AddWithValue("@nama", employeeItem.nama);
                cmd.Parameters.AddWithValue("@jenis_kelamin", employeeItem.jenisKelamin);
                cmd.Parameters.AddWithValue("@alamat", employeeItem.alamat);
                cmd.ExecuteNonQuery();
            }
            return list;
        }

        public List<EmployeeItem> UpdateEmployee(EmployeeItem employeeItem)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE employee SET nama=@nama,jenis_kelamin=@jenis_kelamin,alamat=@alamat WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", employeeItem.id);
                cmd.Parameters.AddWithValue("@nama", employeeItem.nama);
                cmd.Parameters.AddWithValue("@jenis_kelamin", employeeItem.jenisKelamin);
                cmd.Parameters.AddWithValue("@alamat", employeeItem.alamat);
                cmd.ExecuteNonQuery();
            }
            return list;
        }

        public List<EmployeeItem> DeleteEmployee(EmployeeItem employeeItem)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM employee WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", employeeItem.id);
                cmd.ExecuteNonQuery();
            }
            return list;
        }
    }
}
