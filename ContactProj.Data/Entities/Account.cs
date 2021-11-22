using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ContactProj.Domain.Entities
{
	public class Account
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string IncidentName { get; set; }

		[JsonIgnore]
		public Incident Incident { get; set; }

		[JsonIgnore]
		public ICollection<Contact> Contacts { get; set; }
	}
}
