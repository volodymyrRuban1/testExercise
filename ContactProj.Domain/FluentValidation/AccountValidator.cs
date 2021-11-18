using FluentValidation;

namespace ContactProj.Application.FluentValidation
{
	public class AccountValidator : AbstractValidator<Domain.Entities.Account>
	{
		public AccountValidator()
		{

		}
	}
}
