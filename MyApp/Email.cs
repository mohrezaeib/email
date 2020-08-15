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
            if (!address.Contains("."))
                return false;
            if (address.Length < 4 )
                return false;
            return true;
            //edited again on master 

        }
    }
}
