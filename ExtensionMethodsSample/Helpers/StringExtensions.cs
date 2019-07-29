using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsSample.Helpers
{
    // 1. clasa statica
    public static class StringExtensions
    {

        //public bool IsNumeric(string inputString)
        //{
        //    int number;
        //    return int.TryParse(inputString, out number);
        //}

        // 2. metoda statica cu primul parametru this (de tipul obiectului caruia ii facem extension method)
        public static bool IsNumeric(this string inputString)
        {
            int number;
            return int.TryParse(inputString, out number);
        }
    }
}
