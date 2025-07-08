using EntityLayer;
using FluentValidation;

namespace BusinessLayer.FluentValidation;

public class ProductValidator:AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün Adını Boş Geçemessiniz");
        RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün Adı en az 3 karakter olmalıdır");
        RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok sayısı boş olamz");
        RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat Boş Geçilemez");
    }
}