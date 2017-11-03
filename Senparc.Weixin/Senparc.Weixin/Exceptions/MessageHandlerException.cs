/*----------------------------------------------------------------
    Copyright (C) 2015 Senparc
    
    文件名：MessageHandlerException.cs
    文件功能描述：微信消息异常处理类
    
    
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
    public class MessageHandlerException : WeixinException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageHandlerException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public MessageHandlerException(string message, Exception inner = null)
            : base(message, inner)
        {
        }
    }
}
