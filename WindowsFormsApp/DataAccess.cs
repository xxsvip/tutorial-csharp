using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp
{
    public class DataAccess
    {
        public List<People> GetPeople(string lastName)
        {
            
            using (IDbConnection connection = new MySqlConnection(Helper.CnnVal("mysqlDb")))
            {
                var peoples = connection.Query<People>("select id,first_name firstname,last_name lastName,email_address emailAddress,phone_num phoneNum from people where last_name = @lastName",new {lastName = lastName}).ToList();
                return peoples;
            }
        }
    }
}