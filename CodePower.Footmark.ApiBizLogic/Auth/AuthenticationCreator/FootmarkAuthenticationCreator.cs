using CodePower.Footmark.DataAccess;
using CodePower.Footmark.Model.ContractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.ApiBizLogic.Auth
{
    public class FootmarkAuthenticationCreator : IUserAuthenticationCreator
    {
        public SignInCM AuthenticationUser(string userName, string password)
        {
            //Step 01. Feach user information.
            var dataVisitor = DataVisitor.Create<IUserDataVisitor>();
            var userInfo = dataVisitor.FeachUserInformation(userName);

            //Step 02. Check user information.
            if (userInfo == null)
            {
                //TO DO
                throw new Exception(string.Format("User does not exist, user name:{0}", userName));
            }

            if (userInfo.Password != password)
            {
                //TO DO
                throw new Exception("Username or password is incorrect");
            }

            //Step 03. build SignInCM entity with user information.
            return new SignInCM()
            {
                UserSysNo = userInfo.SysNo,
                UserName = userInfo.Name
            };
        }
    }
}
