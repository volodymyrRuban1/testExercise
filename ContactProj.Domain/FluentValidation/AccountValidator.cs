using System.Runtime.InteropServices.ComTypes;
using ContactProj.Data.Context;
using FluentValidation;

namespace ContactProj.Data.FluentValidation
{
	public class AccountValidator : AbstractValidator<Entities.Account>
	{
		public AccountValidator()
		{

		}
	}
}
