using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace IPScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IPAddress iP_Start;
        IPAddress iP_End;
        List<String> AddressesList;

        private void Btn_Scan_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            iP_Start = new IPAddress(IPBox_BeginAddress.GetAddressBytes());
            iP_End = new IPAddress(IPBox_EndAddress.GetAddressBytes());
            AddressesList = GetAddresses(iP_Start.ToString(), iP_End.ToString());

            if(AddressesList == null)
            {
                //输入不正确
            }

            listView1.BeginUpdate();//防止闪烁
            ListViewItem mainItem;
            for(int i = 0; i < AddressesList.Count; i++)
            {
                mainItem = listView1.Items.Add((i + 1).ToString());
                mainItem.SubItems.Add(AddressesList[i]);
            }
            listView1.EndUpdate();

        }

        private bool CheckIPAddress()
        {
            //TODO检查输入IP的有效性
            return true;
        }
        /// <summary>
        /// 获取两个地址范围之间的所有IP
        /// </summary>
        /// <param name="startAdd">开始地址</param>
        /// <param name="endAdd">结束地址</param>
        /// <returns></returns>
        private List<string> GetAddresses(string startAdd, string endAdd)
        {
            List<String> addressesList = new List<string>();
            IPSection section_Start = GetIPSection(startAdd);
            IPSection section_End = GetIPSection(endAdd);
            if(!section_Start.success || !section_End.success)
            {
                return null;
            }

            if(section_Start.Section1 == section_End.Section1 && section_Start.Section2 == section_End.Section2)
            {
                int start = section_Start.Section3 < section_End.Section3 ? section_Start.Section3 : section_End.Section3;
                int end = section_Start.Section3 > section_End.Section3 ? section_Start.Section3 : section_End.Section3;
                for(int i = start; i <= end; i++)
                {
                    //第一次
                    if (end > i && i == start)
                    {
                        for (int j = section_Start.Section4; j <= 255; j++)
                        {
                            addressesList.Add(section_Start.Section1 + "." + section_Start.Section2 + "." + i.ToString() + "." + j.ToString());
                        }
                    }
                    //中间的
                    else if (end > i && i != start)
                    {
                        for (int j = 1; j <= 255; j++)
                        {
                            addressesList.Add(section_Start.Section1 + "." + section_Start.Section2 + "." + i.ToString() + "." + j.ToString());
                        }
                    }
                    //最后
                    else
                    {
                        for (int j = section_Start.Section4; j <= section_Start.Section4; j++)
                        {
                            addressesList.Add(section_Start.Section1 + "." + section_Start.Section2 + "." + i.ToString() + "." + j.ToString());
                        }
                    }
                }
            }
            else
            {
                return null;
            }

            return addressesList;
        }

        public struct IPSection
        {
            public byte Section1;
            public byte Section2;
            public byte Section3;
            public byte Section4;
            public bool success;
        }
        /// <summary>
        /// 将IP地址转换为四个数字
        /// </summary>
        /// <returns></returns>
        private IPSection GetIPSection(string ipAddress)
        {
            IPSection iPSection = new IPSection();
            try
            {
                var s = ipAddress.Split('.');
                if(s.Length != 4)
                {
                    iPSection.success = false;
                    return iPSection;
                }
                iPSection.Section1 = byte.Parse(s[0]);
                iPSection.Section2 = byte.Parse(s[1]);
                iPSection.Section3 = byte.Parse(s[2]);
                iPSection.Section4 = byte.Parse(s[3]);
            }
            catch(Exception)
            {
                iPSection.success = false;
                return iPSection;
            }

            iPSection.success = true;
            return iPSection;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //获取本机IP
            string hostName = Dns.GetHostName();
            IPAddress[] addressLists = Dns.GetHostAddresses(hostName);
            for(int i = 0; i < addressLists.Length; i++)
            {
                //判断是否属于IPV4地址
                if(addressLists[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    //处理当前的IPV4地址
                }
            }
        }
    }
}
