﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwdWarnings.Model
{
    /// <summary>
    /// General warning result type
    /// </summary>
    public class Warning
    {
        /// <summary>
        /// Id of the area
        /// </summary>
        public int AreaId { get; set; }

        /// <summary>
        /// Short name of the state
        /// </summary>
        public string StateShort { get; set; }

        /// <summary>
        /// Name of the state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Name of the Region
        /// </summary>
        public string RegionName { get; set; }

        /// <summary>
        /// Description of the warning
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Start time
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// End time
        /// </summary>
        public DateTime End { get; set; }

        /// <summary>
        /// Headline of the warning
        /// </summary>
        public string Headline { get; set; }

        /// <summary>
        /// Name of the event
        /// </summary>
        public string Event { get; set; }

        /// <summary>
        /// Instructions to do on the warning
        /// </summary>
        public string Instruction { get; set; }

        /// <summary>
        /// Type of the warning
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// Description of the warning type
        /// </summary>
        public int TypeDescription { get; set; }

        /// <summary>
        /// Level of the warning
        /// </summary>
        public int Level { get; set; }
    }
}
