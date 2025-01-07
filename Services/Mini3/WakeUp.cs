using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoint_TwoToFour.Services.Mini3
{
    public class WakeUp : IWakeUp
    {
        public string Awoken (string name, int time)
        {
            return "So your name is " + name + " and you woke up at a time of " + time  + "AM.";   
        }
    }
}