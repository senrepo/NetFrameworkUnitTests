using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkUnitTests
{
    public class ConfigReader
    {
        public ConfigReader()
        {

        }

        public string GetFromEmailAddress()
        {
            return ConfigurationManager.AppSettings["FromEmailAddress"];
        }
        public string GetToEmailAddress()
        {
            return ConfigurationManager.AppSettings["ToEmailAddress"];
        }

    }
}
