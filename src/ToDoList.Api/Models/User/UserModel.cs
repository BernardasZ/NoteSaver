﻿using DataModel.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using ToDoList.Api.Validators;

namespace ToDoList.Api.Models.User
{
    public class UserModel : IValidatableObject
    {
        public int UserId { get; set; }
        public UserRoleEnum Role { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            UserValidator validator = new UserValidator();

            validator.ValidateUserId(UserId);
            validator.ValidateName(UserName);
            validator.ValidateEmail(UserEmail);
            validator.ValidatePassword(Password);

            return validator.GetValidationResults();
        }
    }
}
