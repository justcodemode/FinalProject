using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
	public class Customer : IEntity
	{
		//northwind de customerın id si string olarak tutuluyor.

		public string CustomerId { get; set; }
		public string ContactName { get; set; }
		public string CompanyName { get; set; }
		public string City { get; set; }
	}

}
