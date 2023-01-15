using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net;

namespace Pinger
{
    internal static class IPAddressValidator
    {
        public static bool ValidateFromString(string testString)
        {
            string pattern = "^((25[0-5]|(2[0-4]|1\\d|[1-9]|)\\d)\\.?\\b){4}$";
            return Regex.IsMatch(testString, pattern);
        }
    }
}
