﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsGaam
{
    public class Game
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Developer { get; set; }
        public string Category { get; set; }
        public int Music { get; set; }
        public int Audio { get; set; }
        public int Performance { get; set; }
        public int Visuals { get; set; }
        public string IsMultiPlayerMode { get; set; }
    }
}
