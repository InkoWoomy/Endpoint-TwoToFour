using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoint_TwoToFour.Services.Mini3
{
    public interface IWakeUp
    {
        string Awoken (string name, int time);
    }
}