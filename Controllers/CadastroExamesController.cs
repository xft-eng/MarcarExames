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
    public class CadastroExamesController : Controller
    {
        private Context db = new Context();

        // GET: CadastroExames
        public ActionResult Index()
        {
            return View(db.CadastroExames.ToList());
        }

        // GET: CadastroExames/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadastroExame cadastroExame = db.CadastroExames.Find(id);
            if (cadastroExame == null)
            {
                return HttpNotFound();
            }
            return View(cadastroExame);
        }

        // GET: CadastroExames/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadastroExames/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomeExame,Observacao,IdTipoExame")] CadastroExame cadastroExame)
        {
            if (ModelState.IsValid)
            {
                db.CadastroExames.Add(cadastroExame);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cadastroExame);
        }

        // GET: CadastroExames/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadastroExame cadastroExame = db.CadastroExames.Find(id);
            if (cadastroExame == null)
            {
                return HttpNotFound();
            }
            return View(cadastroExame);
        }

        // POST: CadastroExames/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomeExame,Observacao,IdTipoExame")] CadastroExame cadastroExame)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadastroExame).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadastroExame);
        }

        // GET: CadastroExames/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadastroExame cadastroExame = db.CadastroExames.Find(id);
            if (cadastroExame == null)
            {
                return HttpNotFound();
            }
            return View(cadastroExame);
        }

        // POST: CadastroExames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CadastroExame cadastroExame = db.CadastroExames.Find(id);
            db.CadastroExames.Remove(cadastroExame);
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
