using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ContactProj.Domain.Entities
{
	public class Incident
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string Name { get; set; }

		public string Description { get; set; }

		[JsonIgnore]
		public ICollection<Account> Account { get; set; }
	}
}
