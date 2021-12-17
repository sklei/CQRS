using MediatR;
using CQRS.Repositories;
using FluentValidation;

namespace CQRS.Core.Todo;

public class CreateTodoCommandValidator : AbstractValidator<CreateTodoCommand>
{
    public CreateTodoCommandValidator()
    {
        RuleFor(v => v.Title)
            .MaximumLength(20)
                .WithMessage("Title maxlength is 20.")
            .NotEmpty()
                .WithMessage("Title can't be empty.");
        
        // Multiple validations are possible
        // RuleFor(v => v.Title)
        //     .EmailAddress();

        // This results in:
        // FluentValidation.ValidationException: Validation failed: 
        // -- Title: Title maxlength is 20. Severity: Error
        // -- Title: 'Title' is not a valid email address. Severity: Error
    }
}