using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    internal static class StringExtension
    {
        public static string Cut(this String thisObj, int range)
        {
            if (thisObj.Count() <= range) return thisObj;
            else return thisObj.Substring(0, range) + "...";
        }
    }
}
