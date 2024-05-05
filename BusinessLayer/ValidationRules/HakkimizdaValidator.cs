using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class HakkimizdaValidator : AbstractValidator<Hakkimizda> 
    {
        public HakkimizdaValidator()
        {
            RuleFor(x => x.Aciklama).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz.");
            RuleFor(x => x.Resim1).NotEmpty().WithMessage("Görsel seçiniz.");
            RuleFor(x => x.Aciklama).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik bir açıklama ekleyin.");
            RuleFor(x => x.Aciklama).MaximumLength(1500).WithMessage("Lütfen açıklamayı en fazla 1500 karakter olacak biçimde düzenleyin.");
        }
    }
}
