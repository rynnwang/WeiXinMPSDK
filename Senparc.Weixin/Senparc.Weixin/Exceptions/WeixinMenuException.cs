/*----------------------------------------------------------------
    Copyright (C) 2015 Senparc
    
    文件名：WeixinException.cs
    文件功能描述：微信菜单异常处理类
    
    
    创建标识：Senparc - 20150211
    
    修改标识：Senparc - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

using System;

namespace Senparc.Weixin.Exceptions
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Senparc.Weixin.Exceptions.WeixinException" />
    public class WeixinMenuException : WeixinException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeixinMenuException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public WeixinMenuException(string message)
            : base(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeixinMenuException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public WeixinMenuException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
