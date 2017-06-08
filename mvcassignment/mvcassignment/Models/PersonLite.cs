﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcassignment.Models
{
    public class PersonLite
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Apartment { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string HomePhone { get; set; }
    }
}