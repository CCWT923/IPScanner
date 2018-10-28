﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;

namespace IPScanner
{
    class ProcessIP
    {
        public ProcessIP(List<string> AddList)
        {
            _addressInfoList = new List<AddressInfo>();
            ThreadCount = 2;
            _AddressList = AddList;
        }

        private List<string> _AddressList;
        private int _ThreadCount = 2;
        private List<AddressInfo> _addressInfoList;
        private int _MaxThreadCount = 200;
        private int _ProcessedCount = 0;

        /// <summary>
        /// 已处理的数量
        /// </summary>
        public int ProcessedCount
        {
            get
            {
                return _ProcessedCount;
            }
        }

        /// <summary>
        /// 返回处理后的IP地址的信息
        /// </summary>
        public struct AddressInfo
        {
            public string Address;
            public bool IsOnline;
            public string MacAddress;
            public string HostName;
        }

        /// <summary>
        /// 设置或者获取用于计算的线程数
        /// </summary>
        public int ThreadCount
        {
            get
            {
                return _ThreadCount;
            }
            set
            {
                if(value > _MaxThreadCount)
                {
                    _ThreadCount = _MaxThreadCount;
                }
                if(value < 1)
                {
                    _ThreadCount = 1;
                }
                else
                {
                    _ThreadCount = 0;
                }
            }
        }
        /// <summary>
        /// 设置用于处理的IP地址列表
        /// </summary>
        private List<string> AddressList
        {
            set
            {
                _AddressList = value;
            }
        }
        /// <summary>
        /// 开始启动每个线程
        /// </summary>
        public void Start()
        {
            for(int i = 0; i < ThreadCount; i++)
            {
                Thread thread = new Thread(new ThreadStart(GetAddressInfo));
                thread.Start();
            }
        }

        /// <summary>
        /// 获取每个IP地址的详细信息
        /// </summary>
        private void GetAddressInfo()
        {
            string tmpIp = "";
            lock (this)
            {
                if(_AddressList.Count > 0)
                {
                    tmpIp = _AddressList[0];
                    _AddressList.RemoveAt(0);
                }
                else
                {
                    return;
                }
            }

            IPAddress iPAddress = IPAddress.Parse(tmpIp);
            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send(iPAddress, 200);
            AddressInfo info = new AddressInfo();
            info.Address = tmpIp;
            //是否连通
            if(reply.Status == IPStatus.Success)
            {
                info.IsOnline = true;
                //获取主机名
                try
                {
                    IPHostEntry entry = Dns.GetHostEntry(tmpIp);
                    info.HostName = entry.HostName;
                }
                catch (Exception)
                {
                    info.HostName = "";
                }
                //获取MAC地址
                info.MacAddress = GetMac(tmpIp);
            }
            else
            {
                info.IsOnline = false;
            }
            
            _addressInfoList.Add(info);
            _ProcessedCount++;
        }

        /// <summary>
        /// 使用ARP获取Mac地址
        /// </summary>
        /// <param name="DestIP">目标IP</param>
        /// <param name="SrcIP">0</param>
        /// <param name="pMacAddr"></param>
        /// <param name="PhyAddLen"></param>
        /// <returns></returns>
        [DllImport("Iphlpapi.dll")]
        public static extern uint SendARP(uint DestIP, uint SrcIP, ref ulong pMacAddr, ref uint PhyAddLen);
        /// <summary>
        /// 获取MAC地址
        /// </summary>
        /// <param name="ip">IP地址</param>
        /// <returns>MAC地址</returns>
        private string GetMac(string ip)
        {
            IPAddress iPAddress = IPAddress.Parse(ip);
            uint destIP = System.BitConverter.ToUInt32(iPAddress.GetAddressBytes(),0);
            ulong pMacAdd = 0;
            uint phyAddLen = 6;
            uint err = SendARP(destIP,0,ref pMacAdd,ref phyAddLen);
            byte[] bytes1 = BitConverter.GetBytes(pMacAdd);
            return BitConverter.ToString(bytes1, 0, 6);
        }

    }
}
