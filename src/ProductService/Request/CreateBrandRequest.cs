﻿using FluentValidation;
using ProductService.Helper;

namespace ProductService.Request;

public class CreateBrandRequest
{
    public string Name { get; set; }
}

public class CreateBrandRequestValidator : AbstractValidator<CreateBrandRequest>
{
    public CreateBrandRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotNull()
            .NotEmpty()
            .WithMessage("Name can not be null or empty");
    }
}
