﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KushtPor
{
    public class Drink
    {
        /// <summary>
        /// Drinks Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Driks Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Driks Price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Driks Volume
        /// </summary>
        public double Volume { get; set; }

        /// <summary>
        /// Restaurants Name
        /// </summary>
        public string Restaurant { get; set; }
    }
}
