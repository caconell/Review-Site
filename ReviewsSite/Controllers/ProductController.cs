using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Repositories;
using System;

namespace ReviewsSite.Controllers
{



	public class ProductController : Controller
	{

		public ProductRepository repo;
		public ProductController()
		{
			repo = new ProductRepository();
		}

		public ViewResult Index()
		{
			return View(repo.GetAll());

		}

		public ViewResult Details(int id)
        {
			return View(repo.GetByID(id));
        }






	}
}
