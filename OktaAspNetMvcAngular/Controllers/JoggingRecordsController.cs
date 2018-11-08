using OktaAspNetMvcAngular.Data;
using OktaAspNetMvcAngular.Models;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace OktaAspNetMvcAngular.Controllers
{
    public class JoggingRecordsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/JoggingRecords
        public IQueryable<JoggingRecord> GetJoggingRecords() => db.JoggingRecords;

        // GET: api/JoggingRecords/5
        [ResponseType(typeof(JoggingRecord))]
        public async Task<IHttpActionResult> GetJoggingRecord(int id)
        {
            JoggingRecord joggingRecord = await db.JoggingRecords.FindAsync(id);
            if (joggingRecord == null)
            {
                return NotFound();
            }

            return Ok(joggingRecord);
        }

        // PUT: api/JoggingRecords/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutJoggingRecord(int id, JoggingRecord joggingRecord)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != joggingRecord.Id)
            {
                return BadRequest();
            }

            db.Entry(joggingRecord).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JoggingRecordExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/JoggingRecords
        [ResponseType(typeof(JoggingRecord))]
        public async Task<IHttpActionResult> PostJoggingRecord(JoggingRecord joggingRecord)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.JoggingRecords.Add(joggingRecord);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = joggingRecord.Id }, joggingRecord);
        }

        // DELETE: api/JoggingRecords/5
        [ResponseType(typeof(JoggingRecord))]
        public async Task<IHttpActionResult> DeleteJoggingRecord(int id)
        {
            JoggingRecord joggingRecord = await db.JoggingRecords.FindAsync(id);
            if (joggingRecord == null)
            {
                return NotFound();
            }

            db.JoggingRecords.Remove(joggingRecord);
            await db.SaveChangesAsync();

            return Ok(joggingRecord);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool JoggingRecordExists(int id) => db.JoggingRecords.Count(e => e.Id == id) > 0;
    }
}