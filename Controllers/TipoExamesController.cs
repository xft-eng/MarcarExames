using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DesafioASP.Models;

namespace DesafioASP.Controllers
{
    public class TipoExamesController : Controller
    {
        private Context db = new Context();

        // GET: TipoExames
        public ActionResult Index()
        {
            return View(db.TipoExames.ToList());
        }

        // GET: TipoExames/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoExame tipoExame = db.TipoExames.Find(id);
            if (tipoExame == null)
            {
                return HttpNotFound();
            }
            return View(tipoExame);
        }

        // GET: TipoExames/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoExames/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TipodoExame,Descricao")] TipoExame tipoExame)
        {
            if (ModelState.IsValid)
            {
                db.TipoExames.Add(tipoExame);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoExame);
        }

        // GET: TipoExames/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoExame tipoExame = db.TipoExames.Find(id);
            if (tipoExame == null)
            {
                return HttpNotFound();
            }
            return View(tipoExame);
        }

        // POST: TipoExames/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TipodoExame,Descricao")] TipoExame tipoExame)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoExame).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoExame);
        }

        // GET: TipoExames/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoExame tipoExame = db.TipoExames.Find(id);
            if (tipoExame == null)
            {
                return HttpNotFound();
            }
            return View(tipoExame);
        }

        // POST: TipoExames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoExame tipoExame = db.TipoExames.Find(id);
            db.TipoExames.Remove(tipoExame);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
