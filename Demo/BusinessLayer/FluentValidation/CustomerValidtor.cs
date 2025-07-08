using EntityLayer;
using FluentValidation;

namespace BusinessLayer.FluentValidation;

public class CustomerValidtor : AbstractValidator<Customer>
{
    public CustomerValidtor()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("İsim boş Geçilemze");
        RuleFor(x => x.City).NotEmpty().WithMessage("Şehir boş geçilemez");
    }
}