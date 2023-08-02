﻿using HRIS.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Class.Userlogin
{
    public class UserloginClass
    {
        public static bool checklogin(string username,string userpassword)
        {
            Cursor.Current = Cursors.WaitCursor;
           bool hasdata = false;
            string password = EncryptHashing.ComputeHash(userpassword); //EncryptHashing.GeneratePassword(userpassword);
            try
            {
                using (var dbContext = new HrisContext())
                {
                    var connectionString = dbContext.Database.GetConnectionString();
                    using (var connection = new SqlConnection(connectionString))
                    {
                        using (var command = new SqlCommand("dbo.sp_userlogin", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@userpassword", password);
                            connection.Open();
                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string? completename = reader["completename"].ToString();
                                    int id = reader.GetInt32("id");
                                    Properties.Settings.Default.completename = completename;
                                    Properties.Settings.Default.usercode = id;
                                    Properties.Settings.Default.Save();
                                    hasdata = true;
                                    Cursor.Current = Cursors.Default;
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect username or password!", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
            return hasdata;
        }
    }
}
