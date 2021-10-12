using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyCSOB
{
    public static class Helper
    {
        public static string ConnectingString(string databaseName)
        {
            return ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;
        }
    }
}
