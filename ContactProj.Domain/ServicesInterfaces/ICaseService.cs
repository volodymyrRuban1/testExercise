using System.Threading.Tasks;
using ContactProj.Application.Models;

namespace ContactProj.Application.ServicesInterfaces
{
	public interface ICaseService
	{
		Task<CaseModel> CreateCaseAsync(CaseModel caseDto);
	}
}
