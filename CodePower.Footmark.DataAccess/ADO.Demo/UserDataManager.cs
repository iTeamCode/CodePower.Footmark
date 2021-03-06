﻿using CodePower.Framework.DataAccess;
using CodePower.Framework.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.DataAccess
{
    public class User
    {
        [DataMapping("ID", System.Data.DbType.Int16)]
        public int ID { get; set; }
    }
    public class DemoDataManager
    {
        private static DataManager _dataManager = DataManagerFactory.CreateDataManager(DataBaseType.SQLServer);

        public static bool AuthenticateUser(int churchId, string name, string pwd)
        {
            bool isPass = false;
            CustomerCommand command = _dataManager.CreateCustomerCommand("Dashboard.AuthenticateUser");
            command.SetParameterValue("@ChurchID", churchId);
            command.SetParameterValue("@Name", name);
            command.SetParameterValue("@Password", pwd);


            User user = command.ExecuteCommandToEntity<User>();
            try
            {
                isPass = Convert.ToBoolean(command.ExecuteCommandScalar());
            }
            catch
            {
                //Log here.
            }

            return isPass;
        }
    }
}
