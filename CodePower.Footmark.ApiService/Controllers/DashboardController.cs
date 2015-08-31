using CodePower.Footmark.ApiService.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CodePower.Footmark.ApiService.Controllers
{
    [RoutePrefix("api/dashboard")]
    public class DashboardController : BaseController
    {
        [HttpGet]
        [Route("feach")]
        public object FeachAmtInformation()
        {
            
            return new
            {
                SysNo = CurrentUser.SysNo,
                Name = CurrentUser.UserName,
                ApplicationId = this.Consumer
            };
        }
    }
}
