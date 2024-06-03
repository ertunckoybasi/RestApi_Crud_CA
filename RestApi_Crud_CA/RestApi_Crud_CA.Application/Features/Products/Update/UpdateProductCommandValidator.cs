using FluentValidation;

namespace Application.Features.Products.Update;

public sealed class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("Ürün Adı Boş Olamaz")
            .MinimumLength(3)
            .WithMessage("Ürün Adı en az 3 karakter olmalıdır");
        RuleFor(p => p.SKU)
            .MinimumLength(10)
            .WithMessage("Barkod en az 10 karakter olmalıdır");
    }

}
