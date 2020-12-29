using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem
{
    public abstract class Lift
    {
        public double AttemptOne { get; set; }
        public double AttemptTwo { get; set; }

        public double AttemptThree { get; set; }

        public abstract void TechnicalMiss(); //run this if it's not an outright miss of a lift
        //should this be an interface??? since not every lifter may need to implement this!!!
    }
}
