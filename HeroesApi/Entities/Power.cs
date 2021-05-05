﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesApi.Entities
{
    public class Power
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsOverpowered { get; set; }
    }
}
