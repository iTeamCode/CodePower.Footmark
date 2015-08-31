using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Framework.Common.Exception
{
    /// <summary>
    /// Bussiness Exception
    /// </summary>
    public class BusinessException : System.Exception
    {
        #region constructor
        /// <summary>
        /// create business exception
        /// </summary>
        public BusinessException() : this(string.Empty) { }
        /// <summary>
        /// create business exception
        /// </summary>
        /// <param name="message">message</param>
        public BusinessException(string message) : this(message, null) { }
        /// <summary>
        /// create business exception
        /// </summary>
        /// <param name="message">message</param>
        /// <param name="statusCode">Http status code</param>
        public BusinessException(string message, HttpStatusCode statusCode) : this(message, null, statusCode) { }
        /// <summary>
        /// create business exception
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="innerException">inner exception.</param>
        public BusinessException(string message, System.Exception innerException) : this(message, innerException, HttpStatusCode.OK) { }
        /// <summary>
        /// create business exception
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="innerException">exception.</param>
        /// <param name="statusCode">Http status code</param>
        public BusinessException(string message, System.Exception innerException, HttpStatusCode statusCode)
            : base(message, innerException)
        {
            this.StatusCode = statusCode;
        }
        #endregion constructor

        /// <summary>
        /// get or set 'Status Code' ,  it will affect the HTTP status code in response.
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }
    }
}
