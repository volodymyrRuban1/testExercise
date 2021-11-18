﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ContactProj.Domain.Entities;

namespace ContactProj.Data.Entities
{
	public class Incident
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string Name { get; set; }

		public string Description { get; set; }

		public ICollection<Account> Account { get; set; }
	}
}
