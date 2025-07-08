using EntityLayer;
using FluentValidation;

namespace BusinessLayer.FluentValidation;

public class CtegoryValidator : AbstractValidator<Category>
{
    public CtegoryValidator()
    {
        RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Ktegori adı boş geçilemez");
    }
}