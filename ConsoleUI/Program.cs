﻿using System;
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
			//ProductTest();
			CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
			foreach (var category in categoryManager.GetAll())
			{
				Console.WriteLine(category.CategoryName);
			}

		}

		private static void ProductTest()
		{
			ProductManager productManager = new ProductManager(new EfProductDal());
			foreach (var product in productManager.GetByUnitPrice(40, 100))
			{
				Console.WriteLine(product.ProductName);
			}
		}
	}
}
