﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class Game : Application
    {
        public double requiredEffectiveMemory;

        public Game(double requiredEffectiveMemory)
        {
            this.requiredEffectiveMemory = requiredEffectiveMemory;
        }
    }
}
