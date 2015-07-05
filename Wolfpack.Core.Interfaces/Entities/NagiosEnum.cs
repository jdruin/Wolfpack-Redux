using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wolfpack.Core.Interfaces.Entities
{
    public enum NagiosResult
    {
        // From 
        Ok = 0,  //Up
        Warning = 1, // UP or DOWN/UNREACHABLE*
        Critical = 2, // DOWN/UNREACHABLE
        Unknown = 3 // DOWN/UNREACHABLE
    };
}
