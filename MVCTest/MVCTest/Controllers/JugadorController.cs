using MVCTest.Models; // Agregué esta referencia
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace MVCTest.Controllers
{
    public class JugadorController : Controller
    {
        // GET: /Jugador/
        public ActionResult Index()
        {
            // Envío ese jugador a la vista del index
            return View(Jugador);
        }
        //Agregando un jugador
        public List<Jugador> Jugador = new List<Jugador>{new Jugador
            {
                ID = 1,
                Nombre = "Diana",
                Apellido = "Gutierrez",
                Posición = "Portero",
                Salario = 12000,
                Club = "URL"
            }

        };
            
    
        [HttpPost]  
       public ActionResult Index(HttpPostedFileBase postedFile)  
       {  
           
           string filePath = string.Empty;  
           if (postedFile != null)  
           {  
               string path = Server.MapPath("~/Uploads/");  
               if (!Directory.Exists(path))  
               {  
                   Directory.CreateDirectory(path);  
               }  
               filePath = path + Path.GetFileName(postedFile.FileName);  
               string extension = Path.GetExtension(postedFile.FileName);  
               postedFile.SaveAs(filePath);  
  
               string csvData = System.IO.File.ReadAllText(filePath);  
               foreach(string row in csvData.)  
               {  
                   if (!string.IsNullOrEmpty(row))  
                   {  
                       jugador.Add(new Jugador  
                       {  
                           ID=Convert.ToInt32(row.Split(",")[0]),  
                           Nombre= row.Split(",")[1],
                           Apellido = row.spl
                           Pais= row.Split(",")[2]  
                       });  
                   }  
               }  
           }  
           return View(Jugador);  
       }
               

        //
        // GET: /Jugador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Jugador/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Jugador/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Jugador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Jugador/Edit/5
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

        //
        // GET: /Jugador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Jugador/Delete/5
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
