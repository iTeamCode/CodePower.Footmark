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
            return new FootmarkUserInfomationCreator();
        }

        protected override IUserAuthorizationCreator BuildUserAuthorizationCreator()
        {
            return new NoAuthorizationCreator();
        }

        protected override IUserAuthenticationCreator BuildUserAuthenticationCreator()
        {
            return new FootmarkAuthenticationCreator();
        }
        #endregion override base class.
    }
}
