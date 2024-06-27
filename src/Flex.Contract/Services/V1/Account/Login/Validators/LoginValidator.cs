using FluentValidation;

namespace Flex.Contract.Services.V1.Account.Login.Validators
{
    public class LoginValidator : AbstractValidator<Query.Login>
    {
        public LoginValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}
