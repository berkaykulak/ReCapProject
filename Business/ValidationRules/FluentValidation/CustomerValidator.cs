﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c.UserId).NotEmpty();
            RuleFor(c => c.CompanyName).MinimumLength(2);
        }
    }
}