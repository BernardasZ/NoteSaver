﻿using DataModel.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ToDoList.Api.Validators;

namespace ToDoList.Api.Models.Task
{
    public class TaskModel : IValidatableObject
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TaskName { get; set; }
        public TaskStatusEnum Status { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            TaskValidator validator = new TaskValidator();

            validator.ValidateTaskId(Id);
            validator.ValidateUserId(UserId);
            validator.ValidateName(TaskName);

            return validator.GetValidationResults();
        }
    }
}
