using System;

namespace Senparc.Weixin.Exceptions
{
    /// <summary>
    /// 微信自定义异常基类
    /// </summary>
    /// <seealso cref="System.ApplicationException" />
    public class WeixinException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeixinException"/> class.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        public WeixinException(string message)
            : base(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeixinException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public WeixinException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
