using System;
using System.Collections.Generic;
using ContactProj.Data.Entities;

namespace ContactProj.Domain.Entities
{
	public class Account
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string IncidentName { get; set; }

		public Incident Incident { get; set; }

		public ICollection<Contact> Contacts { get; set; }
	}
}
