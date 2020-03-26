using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Min18IfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == Customer.Unknown || customer.MembershipTypeId == Customer.PayAsYouGo)
                return ValidationResult.Success;

            if (!customer.BirthDate.HasValue)
                return new ValidationResult("Date of Birth is required.");

            var customerAge = DateTime.Now.Year - customer.BirthDate.Value.Year;

            if (customerAge >= 18)
                return ValidationResult.Success;

            return new ValidationResult("Customer needs to be at least 18 years old membership types other than pay as you go.");
        }
    }
}