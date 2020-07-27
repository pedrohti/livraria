using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using livraria.DAL;
using livraria.Models;

namespace livraria.Controllers
{
    public class LivroController : ApiController
    {
        private LivroContext db = new LivroContext();

        // GET: api/Livro
        public List<Livro> Get()
        {
            return db.Livros.ToList();
        }

        // GET: api/Livro/5
        public IHttpActionResult GetLivro(int id)
        {
            Livro livro = db.Livros.Find(id);
            if (livro == null)
            {
                return NotFound();
            }

            return Ok(livro);
        }

        // PUT: api/Livro/5
        public void Put([FromBody] Livro livro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(livro).State = EntityState.Modified;
                db.SaveChanges();
            }
            Dispose();
        }

        //public string PostIsbn(long isbn)
        //{
        //    var livro = db.Livros.Where(l => l.ISBN == isbn);

        //    if (livro.Count() == 0)
        //    {
        //        return "ok";
        //    } else
        //    {
        //        return "ISBN já cadastrado";
        //    }
        //}

        // POST: api/Livro
        [ResponseType(typeof(Livro))]
        //public IHttpActionResult PostLivro(Livro livro)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Livros.Add(livro);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = livro.Id }, livro);
        //}

        public string Post([FromBody] Livro livro)
        {
            var isbn = db.Livros.Where(l => l.ISBN == livro.ISBN);

            if (isbn.Count() == 0)
            {
                if (ModelState.IsValid)
                {
                    db.Livros.Add(livro);
                    db.SaveChanges();
                }
            } else
            {
                return "nok";
            }
            Dispose();
            return "ok";
        }

        // DELETE: api/Livro/5
        public void Delete(int id)
        {
            Livro livro = db.Livros.Find(id);
            db.Livros.Remove(livro);
            db.SaveChanges();
            Dispose();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LivroExists(int id)
        {
            return db.Livros.Count(e => e.Id == id) > 0;
        }
    }
}