using Backend_BD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Backend_BD.Controllers
{
    public class MaestrosController : Controller
    {
        // GET: Maestros
        public ActionResult Index()
        {
            using (AlumnoDbContext dbMaestros = new AlumnoDbContext())
            {
                return View(dbMaestros.Maestros.ToList());
            }
        }



        public ActionResult Details(int? matricula)
        {
            using (AlumnoDbContext dbMaestros = new AlumnoDbContext())
            {
                Maestros maestro = dbMaestros.Maestros.Find(matricula);
                if (maestro == null)
                {
                    return HttpNotFound();
                }
                return View(maestro);
            }
        }

        public ActionResult Create()
        {
            return View();
        }
        //Se envian parametros post
        [HttpPost]
        public ActionResult Create(Maestros maes)
        {
            using (AlumnoDbContext dbMaestros = new AlumnoDbContext())
            {
                dbMaestros.Maestros.Add(maes);
                dbMaestros.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int? matricula)
        {
            using (AlumnoDbContext dbMaestros = new AlumnoDbContext())
            {
                return View(dbMaestros.Maestros.Where(x => x.Matricula == matricula).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Edit(Maestros maes)
        {
            using (AlumnoDbContext dbMaestros = new AlumnoDbContext())
            {
                dbMaestros.Entry(maes).State = EntityState.Modified;
                dbMaestros.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? matricula)
        {
            using (AlumnoDbContext dbMaestros = new AlumnoDbContext())
            {
                return View(dbMaestros.Maestros.Where(x => x.Matricula == matricula).FirstOrDefault());

            }
        }

        [HttpPost]

        public ActionResult Delete(Alumnos maes, int? matricula)
        {
            using (AlumnoDbContext dbMaestros = new AlumnoDbContext())
            {
                Maestros ma = dbMaestros.Maestros.Where(x => x.Matricula == matricula).FirstOrDefault();
                dbMaestros.Maestros.Remove(ma);
                dbMaestros.SaveChanges();
            }
            return RedirectToAction("Index");

        }
    }
}