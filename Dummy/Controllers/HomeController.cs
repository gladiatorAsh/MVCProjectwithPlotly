using Dummy.Intermediate;
using Dummy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dummy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Show");
        }

        public ActionResult Show()
        {
            Graph graph = new Graph();
            graph.Init();

            return View(graph);
        }

        [HttpPost]
        public ActionResult Calculate(List<Point> points)
        {

            Distances obj = new Distances();
            var calculatedPoints = obj.CalculateAllDistances(points.First(i => i.Name.ToUpper() == "START"), points);
            var rankedPoints = obj.CalculateRanks(calculatedPoints);
            ViewBag.Message = "Your application description page.";
            Graph graph = new Graph();
            graph.points = rankedPoints.OrderBy(i => i.Rank).ToList();
            TempData["Graph"] = graph;
            return RedirectToAction("Display");
        }

        public ActionResult Display(Graph gh)
        {
            var data = (Graph)TempData["Graph"];

            // If no data is present, redirect to data entry form
            if (data == null)
            {
                return RedirectToAction("Show");
            }

            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}