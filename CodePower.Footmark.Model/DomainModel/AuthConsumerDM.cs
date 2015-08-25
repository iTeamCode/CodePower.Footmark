using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.Model.DomainModel
{
    public class AuthConsumerDM
    {
        /// <summary>
        /// get or set 'AuthConsumerID'
        /// </summary>
        public int AuthConsumerID { get; set; }
        /// <summary>
        /// get or set 'ConsumerAppID'
        /// </summary>
        public int ConsumerAppID { get; set; }
        /// <summary>
        /// get or set 'Consumer Name'
        /// </summary>
        public string ConsumerName { get; set; }
        /// <summary>
        /// get or set 'Consumer Key'
        /// </summary>
        public string ConsumerKey { get; set; }
        /// <summary>
        /// get or set 'Consumer Secret'
        /// </summary>
        public string ConsumerSecret { get; set; }
        /// <summary>
        /// get or set 'IsEnabled'
        /// </summary>
        public bool IsEnabled { get; set; }

        public virtual ICollection<AuthTokenDM> Tokens { get; set; }
    }
}
