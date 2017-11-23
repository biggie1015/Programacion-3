using Microsoft.Win32;
using Parcial2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Parcial2.Controllers
{
    public class HomeController : Controller
    {
        Contexto db = new Contexto();
        Registro registro = new Registro();
        Usuarios user = new Usuarios();
      

        public ActionResult Registrarse()
        {
            return View();

        }

        
        public ActionResult Usuarios(Usuarios user)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public JsonResult Create(HttpPostedFileBase file)
        {

            try
            {

                


                //    var model = Server.MapPath("~/Fotos") + file.FileName;
                //    if (file.ContentLength > 0)
                //    {
                //        file.SaveAs(model);
                //    }
                //}


            }
            catch
            {

            }
            return Json(JsonRequestBehavior.AllowGet);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
