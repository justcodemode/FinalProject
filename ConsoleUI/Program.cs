using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
	//SOLID
	// openclosed principle : yeni bir özellik ekliyorsan mevcuttaki hiçbir koduna dokunamazsın
	class Program
	{
		static void Main(string[] args)
		{
			ProductManager productManager = new ProductManager(new EfProductDal());
			foreach (var product in productManager.GetByUnitPrice(40,100))
			{
				Console.WriteLine(product.ProductName);
			}
			
		}
	}
}
