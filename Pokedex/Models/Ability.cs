﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class Ability
    {
        public string name { get; set; }
        public string url { get; set; }
        List<Abilities> abilities { get; set;}
    }
}