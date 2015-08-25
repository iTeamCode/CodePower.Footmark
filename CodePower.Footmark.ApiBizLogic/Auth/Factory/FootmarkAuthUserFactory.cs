using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.ApiBizLogic.Auth
{
    public class FootmarkAuthUserFactory : AuthUserFactory
    {
        public FootmarkAuthUserFactory(ConsumerApp consumer) : base(consumer) { }

        #region override base class.
        protected override IUserInfomationCreator BuildUserInfomationCreator()
        {
            throw new NotImplementedException();
        }

        protected override IUserAuthorizationCreator BuildUserAuthorizationCreator()
        {
            throw new NotImplementedException();
        }

        protected override IUserAuthenticationCreator BuildUserAuthenticationCreator()
        {
            throw new NotImplementedException();
        }
        #endregion override base class.
    }
}
