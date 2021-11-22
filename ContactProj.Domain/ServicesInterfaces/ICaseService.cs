using System.Threading.Tasks;
using ContactProj.Application.Models;

namespace ContactProj.Application.Services
{
	public interface ICaseService
	{
		Task<CaseModel> CreateCaseAsync(CaseModel caseDto);
	}
}
