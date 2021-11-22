using AutoMapper;
using ContactProj.Application.Dto;
using ContactProj.Domain.Entities;

namespace ContactProj.Application.Mapper
{
	public sealed class AccountMapper : Profile
	{
		public AccountMapper()
		{
			CreateMap<Account, AccountCreationDto>().ReverseMap();
		}
	}
}
