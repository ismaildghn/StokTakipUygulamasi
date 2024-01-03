using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StokTakipUygulaması
{
    internal class Regex1
    {
        public static bool IsAlphanumeric(string input)
        {           
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9-]+$");

            return regex.IsMatch(input);
        }
    }
}
