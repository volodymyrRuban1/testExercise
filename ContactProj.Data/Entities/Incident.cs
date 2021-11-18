using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactProj.Domain.Entities
{
	public class Incident
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public ICollection<Account> Account { get; set; }
	}
}
