using CodePower.Footmark.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.ApiBizLogic
{
    public class UserBizManager
    {
        public static bool AuthenticateUser(int churchId, string name, string pwd)
        {
            //some logic code here.
            return UserDataManager.AuthenticateUser(churchId, name, pwd);
        }
    }
}
