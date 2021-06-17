using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;

namespace ReviewsSite.Controllers
{



	public class ProductController : Controller
	{

		public IRepository<Product> productRepo;
		public ProductController(IRepository<Product> productRepo)
		{
			this.productRepo = productRepo;
		}

		public ViewResult Index()
		{
			return View(productRepo.GetAll());

		}

		public ViewResult Details(int id)
        {
			return View(productRepo.GetByID(id));
        }






	}
}
