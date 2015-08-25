using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.ApiBizLogic.Auth
{
    /// <summary>
    /// interface for OAuth process work flow.
    /// </summary>
    public interface IOAuth
    {
        /// <summary>
        /// Create access token
        /// </summary>
        /// <returns>json object entity</returns>
        object GenerateAccessToken();
    }
}
