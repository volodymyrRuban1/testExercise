using AutoMapper;
using ContactProj.Application.Dto;
using ContactProj.Domain.Entities;

namespace ContactProj.Application.Mapper
{
	public sealed class ContactMapper : Profile
	{
		public ContactMapper()
		{
			CreateMap<Contact, AccountCreationDto>().ReverseMap();
		}
	}
}
