using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDay1.Models;

namespace WebAPIDay1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        Context db;
        public CourseController(Context db) { this.db = db; }
       
        [HttpGet]
        public List<Course> Get()
        {
            return db.Courses.ToList();
        }
        [HttpGet("{id:int}")]
        public ActionResult getbyid(int id)
        {
            Course c = db.Courses.Where(n => n.ID == id).FirstOrDefault();
            if (c == null) return NotFound();
            else return Ok(c);
        }

        [HttpGet("{name:alpha}")]
        public ActionResult getbyname(string name)
        {
            Course c = db.Courses.Where(n => n.Crs_name == name).FirstOrDefault();
            if (c == null) return NotFound();
            else return Ok(c);
        }
        [HttpPost]
        public ActionResult add(Course c)
        {
            if (c == null) return BadRequest();
            db.Courses.Add(c);
            db.SaveChanges();
            return CreatedAtAction("getbyid", new { id = c.ID }, c);
        }

        [HttpPut("{id}")]
        public ActionResult update(int id, Course c)
        {

            if (c == null) return BadRequest();
            if (id != c.ID) return BadRequest();

            if (ModelState.IsValid)
            {
                db.Entry(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();

                return NoContent();
            }
            else return BadRequest(ModelState);

        }
        [HttpDelete("{id}")]
        public ActionResult delete(int id)
        {
            Course c = db.Courses.FirstOrDefault(n => n.ID == id);
            if (c == null) return NotFound();
            db.Courses.Remove(c);
            db.SaveChanges();
            return Ok(c);
        }
    }
}
