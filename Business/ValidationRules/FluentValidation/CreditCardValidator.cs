﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class CreditCardValidator : AbstractValidator<CreditCard>
    {
        public CreditCardValidator()
        {

        }

    }
}