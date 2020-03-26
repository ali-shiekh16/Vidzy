﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<MembershipType> MembershipType { get; set; }

        public string Title
        {
            get
            {
                if (Customer.Id == 0)
                    return "Add Customer";
                return "Edit Customer";
            }
        }
    }
}