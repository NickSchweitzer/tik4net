﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tik4net.Objects.Ip.Firewall
{
    /// <summary>
    /// /ip/firewall/mangle
    /// </summary>
    [TikEntity("/ip/firewall/mangle", IncludeDetails = true)]
    public class FirewallMangle
    {
        /// <summary>
        /// .id
        /// </summary>
        [TikProperty(".id", IsReadOnly = true, IsMandatory = true)]
        public string Id { get; private set; }

        /// <summary>
        /// chain
        /// </summary>
        [TikProperty("chain")]
        public string Chain { get; set; }

        /// <summary>
        /// action
        /// </summary>
        [TikProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// new-priority
        /// </summary>
        [TikProperty("new-priority")]
        public long NewPriority { get; set; }

        /// <summary>
        /// passthrough
        /// </summary>
        [TikProperty("passthrough")]
        public bool Passthrough { get; set; }

        /// <summary>
        /// src-address-list
        /// </summary>
        [TikProperty("src-address-list")]
        public string SrcAddressList { get; set; }

        /// <summary>
        /// invalid
        /// </summary>
        [TikProperty("invalid", IsReadOnly = true)]
        public bool Invalid { get; private set; }

        /// <summary>
        /// dynamic
        /// </summary>
        [TikProperty("dynamic", IsReadOnly = true)]
        public bool Dynamic { get; private set; }

        /// <summary>
        /// disabled
        /// </summary>
        [TikProperty("disabled")]
        public bool Disabled { get; set; }

        /// <summary>
        /// new-packet-mark
        /// </summary>
        [TikProperty("new-packet-mark")]
        public string NewPacketMark { get; set; }

        /// <summary>
        /// comment
        /// </summary>
        [TikProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// dst-address-list
        /// </summary>
        [TikProperty("dst-address-list")]
        public string DstAddressList { get; set; }

        /// <summary>
        /// protocol
        /// </summary>
        [TikProperty("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// src-address
        /// </summary>
        [TikProperty("src-address")]
        public string SrcAddress { get; set; }

        /// <summary>
        /// dst-address
        /// </summary>
        [TikProperty("dst-address")]
        public string DstAddress { get; set; }

        /// <summary>
        /// jump-target
        /// </summary>
        [TikProperty("jump-target")]
        public string JumpTarget { get; set; }

        /// <summary>
        /// address-list
        /// </summary>
        [TikProperty("address-list")]
        public string AddressList { get; set; }

        /// <summary>
        /// address-list-timeout
        /// </summary>
        [TikProperty("address-list-timeout")]
        public string AddressListTimeout { get; set; }
    }

}