using System.Threading.Tasks;
using ContactProj.Application.Services;
using ContactProj.Domain.Entities;

namespace ContactProj.Application.Models
{

	public class CaseModel
	{
		public Account Account { get; set; }

#nullable enable
		public Contact? Contact { get; set; }
		public Incident? Incident { get; set; }
	}
}
