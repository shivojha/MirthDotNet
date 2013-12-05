﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MirthDotNet.Model
{
    [Serializable]
    [XmlRoot("list")]
    public class DashboardStatusList
    {
        public DashboardStatusList()
        {
            this.DashboardStatuses = new List<DashboardStatus>();
            this.ChannelStatuses = new List<DashboardStatus>();
        }

        [XmlElement("dashboardStatus")]
        public List<DashboardStatus> DashboardStatuses { get; set; }

        /// <summary>
        /// Deprecated in Mirth 3.x
        /// </summary>
        [XmlElement("channelStatus")]
        public List<DashboardStatus> ChannelStatuses { get; set; }
    }
}
