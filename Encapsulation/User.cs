using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class User
    {
        private string _username;
        public string UserName
        {
            get
            {
                return _username;
            }

            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value.Length >= 6 && value.Length <= 25)
                    {
                        _username = value;
                    }

                }
            }
        }   
            private string _password;
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                for(int i = 0;i < value.Length;i++)
                {
                    if(value.Length>=8 && value.Length<=25 && char.IsLower(value[i]) && char.IsUpper(value[i]) && char.IsDigit(value[i]) )
                        _password = value;
                }
                
            }
        }
        public bool HasDigit(string digit)
        {
            for(int i=0; i<digit.Length;i++)
            {
                if (char.IsDigit(digit[i]))
                    return true;
            }
            return false;
        }
        public bool HasUpper(string upper)
        {
            foreach (var item in upper)
            {
                if (char.IsUpper(item))
                    return true;
            }
            return false;

        }
        private string _hasLower;
        public bool HasLower(string lower)
        {
            foreach (var item in lower)
            {
                if (char.IsLower(item))
                    return true;
            }
            return false;


        }




    }
}
