﻿/*-------------------------------------------------------------
 *   auth: bouyei
 *   date: 2017/6/22 16:39:09
 *contact: 453840293@qq.com
 *profile: www.openthinking.cn
 *    Ltd: 
 *   guid: 1b01e1ab-209a-4898-8419-9dd1642abc6f
---------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouyei.BeidouLSP.JT808.Reponse
{
    /// <summary>
    /// 消息指令0x0700(行驶记录数据上传)
    /// </summary>
    public class REP_PB_0700
    {
        public REP_PB_0700()
        {
        }
        public PB0700 Deserialized(byte[] msgBody)
        {
            return new PB0700()
            {
                SerialNumber = msgBody.ToUInt16(),
                Command = msgBody[2],
                DataContent = msgBody.Copy(3, msgBody.Length - 3)
            };
        }
    }
}
