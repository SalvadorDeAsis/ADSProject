﻿using System.ComponentModel.DataAnnotations;

namespace ADSProject.Validation
{
    public class CustomRequired : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || value.ToString() == "0"){
                return new ValidationResult(ErrorMessage);
            }
            return ValidationResult.Success;
            
        }
    }
}
