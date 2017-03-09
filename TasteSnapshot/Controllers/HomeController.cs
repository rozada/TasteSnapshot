using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteSnapshot.Helpers;
using TasteSnapshot.DAL;
using TasteSnapshot.ViewModels;

namespace TasteSnapshot.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            YummyViewModel vm = YummyHelper.GetFeaturedYummyItem();
            return View(vm);
        }

        [HttpPost]
        public ActionResult GetYummy()
        {
            return View("Index");
            //return this.Json(YummyHelper.GetFeaturedYummyItem());
        }

        [HttpPost]
        public JsonResult Upload()
        {
            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i]; //Uploaded file
                                                            //Use the following properties to get file's name, size and MIMEType
                int fileSize = file.ContentLength;
                string fileName = file.FileName;
                string mimeType = file.ContentType;
                System.IO.Stream fileContent = file.InputStream;
                //To save file, use SaveAs method

                YummyViewModel vm = new YummyViewModel();             

                var content = new byte[file.ContentLength];
                file.InputStream.Read(content, 0, file.ContentLength);

                TSContext dbContext = new TSContext();
                dbContext.Yummies.ToList()[0].Photo = content;
                dbContext.SaveChanges();
                //assignment.FileLocation = content;


                file.SaveAs(Server.MapPath("~/") + fileName); //File will be saved in application root
            }
            return Json("Uploaded " + Request.Files.Count + " files");
        }

        [HttpPost]
        public FileContentResult Show()
        {
            TSContext dbContext = new TSContext();
            var imageData = dbContext.Yummies.ToList()[0].Photo;
            return new FileContentResult(imageData, "image/jpg");
        }

        [HttpGet]
        public FileContentResult ShowImage()
        {
            TSContext dbContext = new TSContext();
            var imageData = dbContext.Yummies.ToList()[0].Photo;
            return new FileContentResult(imageData, "image/jpg");
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