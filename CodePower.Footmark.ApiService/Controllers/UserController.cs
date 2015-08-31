using CodePower.Footmark.Model.ContractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CodePower.Footmark.ApiService.Controllers
{
    public class UserController : BaseController
    {

        [HttpPost]
        public IList<UserCM> SignIn([FromBody]UserCM user)
        {
            user.SysNo = 1;
            if (user != null)
            {
                string data = string.Format("['UserName':'{0}','Password','{1}']", user.Name, user.Password);
            }
            var users = new List<UserCM>();
            users.Add(user);
            users.Add(new UserCM() { SysNo = 2, Name = "Lucas", Password = "888" });
            return users;
        }

        [HttpPost]
        public bool SignOut([FromBody]int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public bool Create([FromBody]UserCM user)
        {
            return true;
        }
	}
}