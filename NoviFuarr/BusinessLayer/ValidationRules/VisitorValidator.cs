using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class VisitorValidator : AbstractValidator<Visitors>
	{
		public VisitorValidator()
		{
            RuleFor(x => x.Name).NotEmpty().WithMessage("*Ziyaretci adı alanı boş bırakılamaz");
			RuleFor(x => x.Surname).NotEmpty().WithMessage("*Soyad alanı boş bırakılamaz");
			RuleFor(x => x.WebAddress).NotEmpty().WithMessage("*Web site alanı boş bırakılamaz");
			RuleFor(x => x.Address).NotEmpty().WithMessage("*Adres alanı boş bırakılamaz");
			RuleFor(x => x.City).NotEmpty().WithMessage("*Sehir alanı boş bırakılamaz");
			RuleFor(x => x.Contry).NotEmpty().WithMessage("*Ulke alanı boş bırakılmaz");
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("*Firma adı alanı boş bırakılamaz");
			RuleFor(x => x.Email).NotEmpty().WithMessage("*E Posta alanı boş bırakılamaz");
			RuleFor(x => x.Description).NotEmpty().WithMessage("*Acıkama alanı boş bırakılamaz");
			RuleFor(x => x.PriceTyp).NotEmpty().WithMessage("*Bu alanda secim yapmalisiniz");
            RuleFor(x => x.Number1).NotEmpty().WithMessage("*Bu alan boş bırakılamaz");
			RuleFor(x => x.Number2).NotEmpty().WithMessage("*Bu alan boş birakılamaz");

		}
	}
}

