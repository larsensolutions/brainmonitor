using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrainMonitor
{
    class UserProfile
    {

        private string _firstName;
        private string _lastName;

        public UserProfile(string lastName, string firstName)
        { 
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public string getFirstName { get { return _firstName; } }
        public string getLastName { get { return _lastName; } }


    }
}
