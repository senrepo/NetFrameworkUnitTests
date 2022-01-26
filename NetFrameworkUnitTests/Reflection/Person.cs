using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkUnitTests
{
    public class Person
    {
        private string _afield;


        private string GetAFieldValue()
        {
            string retvalue = "";
            if (_afield == "") retvalue = "test";
            if (_afield == "something") retvalue = "test something";

            return retvalue;
        }
    }
}
