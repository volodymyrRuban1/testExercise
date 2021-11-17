using ContactProj.Domain.Entities;
using FluentValidation;

namespace ContactProj.Application.FluentValidation
{
	public class ContactValidator : AbstractValidator<Contact>
	{
		public ContactValidator()
		{
			RuleFor(c => c.Email)
				.EmailAddress()
				.WithMessage("Invalid email!");

		}
	}
}
