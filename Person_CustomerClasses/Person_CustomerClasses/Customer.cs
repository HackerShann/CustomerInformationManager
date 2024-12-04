using System;

namespace Person_CustomerClasses
{
    public class Customer : Person
    {
        // Properties for customer number and mailing list preference
        public int CustomerNumber { get; set; }
        public bool OnMailingList { get; set; }
    }
}
