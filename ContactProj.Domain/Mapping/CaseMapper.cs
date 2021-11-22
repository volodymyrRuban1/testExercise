using AutoMapper;
using ContactProj.Application.Dto;
using ContactProj.Application.Models;
using ContactProj.Domain.Entities;

namespace ContactProj.Application.Mapping
{
	public class CaseMapper : Profile
	{
		public CaseMapper()
		{
			CreateMap<Account, CaseModel>().ReverseMap();
			CreateMap<Contact, CaseModel>().ReverseMap();
			CreateMap<Incident, CaseModel>().ReverseMap();
			CreateMap<AccountCreationDto, CaseModel>().ReverseMap();
		}
	}
}
