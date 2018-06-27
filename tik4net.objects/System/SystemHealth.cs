using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tik4net.Objects.System
{
    [TikEntity("/system/health", IsReadOnly = true, IsSingleton = true)]
    public class SystemHealth
    {
        /// <summary>
        /// fan-switch
        /// </summary>
        [TikProperty("fan-switch", IsReadOnly = true)]
        public string FanSwitch { get; private set; }

        /// <summary>
        /// fan-on-threshold
        /// </summary>
        [TikProperty("fan-on-threshold", IsReadOnly = true)]
        public int FanOnThreshold { get; private set; }

        /// <summary>
        /// voltage
        /// </summary>
        [TikProperty("voltage", IsReadOnly = true)]
        public float Voltage { get; private set; }

        /// <summary>
        /// temperature
        /// </summary>
        [TikProperty("temperature", IsReadOnly = true)]
        public int Temperature { get; private set; }
    }
}