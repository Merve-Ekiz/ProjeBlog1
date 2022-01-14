using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.ValidationFluent
{
   public class PostValidator:AbstractValidator<Post>
    {
        public PostValidator()
        {
            RuleFor(x => x.PostCaption).NotEmpty().WithMessage("lütfen Başlık kısmını doldurunuz..");
            RuleFor(x => x.PostCaption).MaximumLength(50).WithMessage("Lütfen 50 Karakterden kısa bir başlık giriniz..");
            RuleFor(x => x.PostContent).NotEmpty().WithMessage("lütfen içerik kısmını doldurunuz..");
            RuleFor(x => x.CreateDate).NotEmpty().WithMessage("lütfen oluşturma tarihini giriniz..");
        }
    }
}
