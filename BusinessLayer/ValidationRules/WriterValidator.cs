using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı boş geçilemez");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("soyad boş geçilemez");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("hakkında boş geçilemez");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("ünvan boş geçilemez");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("en az 2 karakter girişi yapınız");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("en fazla 50 karakter girişi yapınız");


        }

    }
}
