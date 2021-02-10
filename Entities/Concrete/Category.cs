using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
	public class Category : IEntity
	{
		//Çıplak Class Kalmasın standartı ; eğerki bir klan interface almıyorsa ilerde sorun yaşarsın. bu varlıklarımızı işaretleme yani gruplama eğilimine gideriz. 
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }

	}

}
