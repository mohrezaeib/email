using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp
{
    public class Email
    {
        public Boolean validate(string address)
        {
            if (!address.Contains("@"))
                return false;
            return true;

        }
    }
}
