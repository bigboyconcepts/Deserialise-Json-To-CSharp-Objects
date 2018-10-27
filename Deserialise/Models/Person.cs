using System;
using System.Collections.Generic;

namespace Deserialise.Models
{
    public class Person
    {
        public string name
        {
            get;
            set;
        }

        public int age
        {
            get;
            set;
        }

        public bool isAlive
        {
            get;
            set;
        }

        public string education
        {
            get;
            set;
        }

        public Address address
        {
            get;
            set;
        }

        public IList<ContactNumber> contactNumber
        {
            get;
            set;
        }
    }
}
