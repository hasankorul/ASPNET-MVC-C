using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {

            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu adı boş geçilemez");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("kullanıcı adı boş geçilemez");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("en az 3 karakter girişi yapınız");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("en az 3 karakter girişi yapınız");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("en fazla 50 karakter girişi yapınız");



        }
    }   
}
