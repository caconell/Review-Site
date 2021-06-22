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

		public ViewResult Create()
        {
				
				return View(new Product());			

		}

		[HttpPost]
		public IActionResult Create(Product model)
		{
			productRepo.Create(model);
			return RedirectToAction("Update", new { id = model.Id });
		}

		public IActionResult Update(int id)
		{
			Product product = productRepo.GetByID(id);
			return View(product);
		}

		[HttpPost]
		public IActionResult Update(Product model)
        {
			productRepo.Update(model);
			return RedirectToAction("Index");
        }

		public ViewResult Details(int id)
        {
			return View(productRepo.GetByID(id));
        }




	}
}
