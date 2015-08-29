using CodePower.Footmark.DataAccess;
using CodePower.Footmark.Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.ApiBizLogic.Auth
{
    class FootmarkUserInfomationCreator : IUserInfomationCreator
    {
        /// <summary>
        /// Get user information
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public CurrentUserDM GetUserInformation(AuthUserContext context)
        {
            var dataVisitor = DataVisitor.Create<IUserDataVisitor>();
            var userInfo = dataVisitor.FeachUserInformation(context.AuthUserId);
            return new CurrentUserDM
            {
                SysNo = userInfo.SysNo,
                UserName = userInfo.Name,
                //Common field
                CreateTime = userInfo.CreateTime,
                CreateUserSysNo = userInfo.CreateUserSysNo,
                CreateUserName = userInfo.CreateUserName,
                UpdateTime = userInfo.UpdateTime,
                UpdateUserSysNo = userInfo.UpdateUserSysNo,
                UpdateUserName = userInfo.UpdateUserName
            };
        }
    }
    
}
