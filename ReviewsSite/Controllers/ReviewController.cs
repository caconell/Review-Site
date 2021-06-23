using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using ReviewsSite.Repositories;

namespace ReviewsSite.Controllers
{
    public class ReviewController : Controller
    {
        public IRepository<Review> reviewRepo;
        public ReviewController(IRepository<Review> reviewRepo) 
        {
            this.reviewRepo = reviewRepo;   
        }

        public ViewResult Index()
        {
            return View(reviewRepo.GetAll());

        }

        public ViewResult Details(int id)
        {
            return View(reviewRepo.GetByID(id));
        }

        public IActionResult Create(int id)//product id
        {
            Product ProductToReview = reviewRepo.GetProductById(id);
            ViewBag.Product = ProductToReview;
            return View(new Review() { ProductId = id });
        }

        [HttpPost]

        public ActionResult Create(Review review)
        {
            reviewRepo.Create(review);
            return RedirectToAction("Details", new { id = review.Id });

        }

        public IActionResult Update(int id)
        {
            Review review = reviewRepo.GetByID(id);
            return View(review);
        }

        [HttpPost]
        public IActionResult Update(Review review)
        {
            reviewRepo.Update(review);
            ViewBag.ResultMessage = "Review Updated.";
            return RedirectToAction("Details", new { id = review.Id });
            //return View(review);
        }

        public IActionResult Delete(int id)
        {
            Review review = reviewRepo.GetByID(id);
            return View(review);
        }

        [HttpPost]
        public IActionResult Delete(Review obj)
        {
            //Course course = courseRepo.GetByID(obj.Id);
            reviewRepo.Delete(obj);

            return RedirectToAction("Index");
        }
    }

}
