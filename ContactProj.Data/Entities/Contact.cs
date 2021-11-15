using System;

namespace ContactProj.Data.Entities
{
	public class Contact
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }

		public Guid AccountId { get; set; }

		public Account Accounts { get; set; }
	}
}
