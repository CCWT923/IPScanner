using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPScanner
{
    static class Pub
    {
        /// <summary>
        /// 存储处理后的IP地址的信息
        /// </summary>
        public struct AddressInfo
        {
            public string Address;
            public bool IsOnline;
            public string MacAddress;
            public string HostName;
        }
    }
}
