using System.Collections.Generic;

namespace ContactProj.Data.Entities
{
	public class Incident
	{
		public string Name { get; set; }

		public string Description { get; set; }
		public ICollection<Account> Account { get; set; }
	}
}
