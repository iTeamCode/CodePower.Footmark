using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace CodePower.Footmark.ApiService.OAuth2
{
    public class OAuthPrincipal : IPrincipal
    {
        private OAuthIdentity _identity;
        public OAuthPrincipal(OAuthIdentity identity)
        {
            _identity = identity;
        }

        public IIdentity Identity
        {
            get { return _identity; }
        }

        public bool IsInRole(string role)
        {
            return _identity.Authorization.ContainsValue(role);
        }
    }
}