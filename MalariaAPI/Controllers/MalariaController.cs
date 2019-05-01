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
using Malaria.Context;
using MalariaAPI.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MalariaAPI.Controllers
{
    [Authorize]
    public class MalariaController : ApiController
    {
        private MalariaContext db = new MalariaContext();

        // GET: api/Malaria
        [Route("api/Treatments")]
        public IQueryable<Malaria_Treatments> GetMalaria_Treatments()
        {
            return db.Malaria_Treatments;
        }

        // GET: api/Malaria/5
        [Route("api/Treatments/{id}")]
        [ResponseType(typeof(Malaria_Treatments))]
        public IHttpActionResult GetMalaria_Treatments(int id)
        {
            Malaria_Treatments malaria_Treatments = db.Malaria_Treatments.Find(id);
            if (malaria_Treatments == null)
            {
                return NotFound();
            }

            return Ok(malaria_Treatments);
        }

        // PUT: api/Malaria/5
        [Route("api/Treatments/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMalaria_Treatments(int id, Malaria_Treatments malaria_Treatments)
        {
            if (!IsAuthorized("Write"))
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != malaria_Treatments.ID)
            {
                return BadRequest();
            }

            db.Entry(malaria_Treatments).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Malaria_TreatmentsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            LogAction("Malaria_Treatments");

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Malaria
        [Route("api/Treatments")]
        [ResponseType(typeof(Malaria_Treatments))]
        public IHttpActionResult PostMalaria_Treatments(IEnumerable<Malaria_Treatments> malaria_Treatments)
        {
            if (!IsAuthorized("Write"))
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Malaria_Treatments.AddRange(malaria_Treatments);
            db.SaveChanges();

            LogAction("Malaria_Treatments");

            return Ok();
        }

        // DELETE: api/Malaria/5
        [Route("api/Treatments/{id}")]
        [ResponseType(typeof(Malaria_Treatments))]
        public IHttpActionResult DeleteMalaria_Treatments(int id)
        {
            if (!IsAuthorized("Write"))
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            Malaria_Treatments malaria_Treatments = db.Malaria_Treatments.Find(id);
            if (malaria_Treatments == null)
            {
                return NotFound();
            }

            db.Malaria_Treatments.Remove(malaria_Treatments);
            db.SaveChanges();

            LogAction("Malaria_Treatments");

            return Ok(malaria_Treatments);
        }



        /// <summary>
        /// preventions crud
        /// </summary>
        /// <returns></returns>

        // GET: api/Malaria
        [Route("api/Prevention")]
        public IQueryable<Malaria_Prevention> GetMalaria_Prevention()
        {
            return db.Malaria_Prevention;
        }

        // GET: api/Malaria/5
        [Route("api/Prevention/{id}")]
        [ResponseType(typeof(Malaria_Prevention))]
        public IHttpActionResult GetMalaria_Prevention(int id)
        {
            Malaria_Prevention malaria_Prevention = db.Malaria_Prevention.Find(id);
            if (malaria_Prevention == null)
            {
                return NotFound();
            }

            return Ok(malaria_Prevention);
        }

        // PUT: api/Malaria/5
        [Route("api/Prevention/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMalaria_Prevention(int id, Malaria_Prevention malaria_Prevention)
        {
            if (!IsAuthorized("Write"))
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != malaria_Prevention.ID)
            {
                return BadRequest();
            }

            db.Entry(malaria_Prevention).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Malaria_PreventionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            LogAction("Malaria_Prevention");

            return StatusCode(HttpStatusCode.NoContent);
        }

        private bool Malaria_PreventionExists(int id)
        {
            return db.Malaria_Prevention.Count(e => e.ID == id) > 0;
        }

        // POST: api/Malaria
        [Route("api/Prevention")]
        [ResponseType(typeof(Malaria_Prevention))]
        public IHttpActionResult PostMalaria_Prevention(IEnumerable<Malaria_Prevention> malaria_Prevention)
        {
            if (!IsAuthorized("Write"))
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Malaria_Prevention.AddRange(malaria_Prevention);
            db.SaveChanges();

            LogAction("Malaria_Prevention");

            return Ok();
        }

        // DELETE: api/Malaria/5
        [Route("api/Prevention/{id}")]
        [ResponseType(typeof(Malaria_Prevention))]
        public IHttpActionResult DeleteMalaria_Prevention(int id)
        {
            if (!IsAuthorized("Write"))
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            Malaria_Prevention malaria_Prevention = db.Malaria_Prevention.Find(id);
            if (malaria_Prevention == null)
            {
                return NotFound();
            }

            db.Malaria_Prevention.Remove(malaria_Prevention);
            db.SaveChanges();

            LogAction("Malaria_Prevention");

            return Ok(malaria_Prevention);
        }





        /// <summary>
        /// Factss crud
        /// </summary>
        /// <returns></returns>

        // GET: api/Malaria
        [Route("api/Facts")]
        public IQueryable<Malaria_Facts> GetMalaria_Facts()
        {
            return db.Malaria_Facts;
        }

        // GET: api/Malaria/5
        [Route("api/Facts/{id}")]
        [ResponseType(typeof(Malaria_Facts))]
        public IHttpActionResult GetMalaria_Facts(int id)
        {
            Malaria_Facts malaria_Facts = db.Malaria_Facts.Find(id);
            if (malaria_Facts == null)
            {
                return NotFound();
            }

            return Ok(malaria_Facts);
        }

        // PUT: api/Malaria/5
        [Route("api/Facts/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMalaria_Facts(int id, Malaria_Facts malaria_Facts)
        {
            if (!IsAuthorized("Write"))
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != malaria_Facts.ID)
            {
                return BadRequest();
            }

            db.Entry(malaria_Facts).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Malaria_FactsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            LogAction("Malaria_Facts");

            return StatusCode(HttpStatusCode.NoContent);
        }

        private bool Malaria_FactsExists(int id)
        {
            return db.Malaria_Facts.Count(e => e.ID == id) > 0;
        }

        // POST: api/Malaria
        [Route("api/Facts")]
        [ResponseType(typeof(Malaria_Facts))]
        public IHttpActionResult PostMalaria_Facts(IEnumerable<Malaria_Facts> malaria_Facts)
        {
            if (!IsAuthorized("Write"))
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Malaria_Facts.AddRange(malaria_Facts);
            db.SaveChanges();

            LogAction("Malaria_Facts");

            return Ok();
        }

        // DELETE: api/Malaria/5
        [Route("api/Facts/{id}")]
        [ResponseType(typeof(Malaria_Facts))]
        public IHttpActionResult DeleteMalaria_Facts(int id)
        {
            if (!IsAuthorized("Write"))
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            Malaria_Facts malaria_Facts = db.Malaria_Facts.Find(id);
            if (malaria_Facts == null)
            {
                return NotFound();
            }

            db.Malaria_Facts.Remove(malaria_Facts);
            db.SaveChanges();

            LogAction("Malaria_Facts");

            return Ok(malaria_Facts);
        }




        /// <summary>
        /// Controlss crud
        /// </summary>
        /// <returns></returns>

        // GET: api/Malaria
        [Route("api/Controls")]
        public IQueryable<Malaria_Controls> GetMalaria_Controls()
        {
            return db.Malaria_Controls;
        }

        // GET: api/Malaria/5
        [Route("api/Controls/{id}")]
        [ResponseType(typeof(Malaria_Controls))]
        public IHttpActionResult GetMalaria_Controls(int id)
        {
            Malaria_Controls malaria_Controls = db.Malaria_Controls.Find(id);
            if (malaria_Controls == null)
            {
                return NotFound();
            }

            return Ok(malaria_Controls);
        }

        // PUT: api/Malaria/5
        [Route("api/Controls/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMalaria_Controls(int id, Malaria_Controls malaria_Controls)
        {
            if (!IsAuthorized("Write"))
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != malaria_Controls.ID)
            {
                return BadRequest();
            }

            db.Entry(malaria_Controls).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Malaria_ControlsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            LogAction("Malaria_Controls");

            return StatusCode(HttpStatusCode.NoContent);
        }

        private bool Malaria_ControlsExists(int id)
        {
            return db.Malaria_Controls.Count(e => e.ID == id) > 0;
        }

        // POST: api/Malaria
        [Route("api/Controls")]
        [ResponseType(typeof(Malaria_Controls))]
        public IHttpActionResult PostMalaria_Controls(IEnumerable<Malaria_Controls> malaria_Controls)
        {
            if (!IsAuthorized("Write"))
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Malaria_Controls.AddRange(malaria_Controls);
            db.SaveChanges();

            LogAction("Malaria_Controls");

            return Ok();
        }

        // DELETE: api/Malaria/5
        [Route("api/Controls/{id}")]
        [ResponseType(typeof(Malaria_Controls))]
        public IHttpActionResult DeleteMalaria_Controls(int id)
        {
            if (!IsAuthorized("Write"))
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            Malaria_Controls malaria_Controls = db.Malaria_Controls.Find(id);
            if (malaria_Controls == null)
            {
                return NotFound();
            }

            db.Malaria_Controls.Remove(malaria_Controls);
            db.SaveChanges();

            LogAction("Malaria_Controls");

            return Ok(malaria_Controls);
        }






        /// <summary>
        /// Areass crud
        /// </summary>
        /// <returns></returns>

        // GET: api/Malaria
        [Route("api/Areas")]
        public IQueryable<Malaria_Areas> GetMalaria_Areas()
        {
            return db.Malaria_Areas;
        }

        // GET: api/Malaria/5
        [Route("api/Areas/{id}")]
        [ResponseType(typeof(Malaria_Areas))]
        public IHttpActionResult GetMalaria_Areas(int id)
        {
            Malaria_Areas malaria_Areas = db.Malaria_Areas.Find(id);
            if (malaria_Areas == null)
            {
                return NotFound();
            }

            return Ok(malaria_Areas);
        }

        // PUT: api/Malaria/5
        [Route("api/Areas/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMalaria_Areas(int id, Malaria_Areas malaria_Areas)
        {
            if (!IsAuthorized("Write"))
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != malaria_Areas.ID)
            {
                return BadRequest();
            }

            db.Entry(malaria_Areas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Malaria_AreasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            LogAction("Malaria_Areas");

            return StatusCode(HttpStatusCode.NoContent);
        }

        private bool Malaria_AreasExists(int id)
        {
            return db.Malaria_Areas.Count(e => e.ID == id) > 0;
        }

        // POST: api/Malaria
        [Route("api/Areas")]
        [ResponseType(typeof(Malaria_Areas))]
        public IHttpActionResult PostMalaria_Areas(IEnumerable<Malaria_Areas> malaria_Areas)
        {
            if (!IsAuthorized("Write"))
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Malaria_Areas.AddRange(malaria_Areas);
            db.SaveChanges();

            LogAction("Malaria_Areas");

            return Ok();
        }

        // DELETE: api/Malaria/5
        [Route("api/Areas/{id}")]
        [ResponseType(typeof(Malaria_Areas))]
        public IHttpActionResult DeleteMalaria_Areas(int id)
        {
            if (!IsAuthorized("Write"))
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }

            Malaria_Areas malaria_Areas = db.Malaria_Areas.Find(id);
            if (malaria_Areas == null)
            {
                return NotFound();
            }

            db.Malaria_Areas.Remove(malaria_Areas);
            db.SaveChanges();

            LogAction("Malaria_Areas");

            return Ok(malaria_Areas);
        }


        /// <summary>
        /// adding to logs
        /// </summary>

        private void LogAction(string entityName)
        {
            db.Malaria_Log.Add(new Malaria_Log()
            {
                EntityName = entityName,
                UserId = RequestContext.Principal.Identity.GetUserId()
            });
            db.SaveChanges();
        }

        private bool IsAuthorized(string role)
        {
            var user = User.Identity;
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                return userManager.GetRoles(user.GetUserId()).Where(r => r == role).FirstOrDefault() != null;
            } 
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Malaria_TreatmentsExists(int id)
        {
            return db.Malaria_Treatments.Count(e => e.ID == id) > 0;
        }

       
    }
}