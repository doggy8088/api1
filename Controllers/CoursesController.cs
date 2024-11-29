using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api1.Models;
using Microsoft.AspNetCore.Mvc;
using api1.Models;

namespace api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ILogger<CoursesController> _logger;
        private readonly ContosoUniversityContext _context;

        public CoursesController(ILogger<CoursesController> logger,
            ContosoUniversityContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {
            return _context.Courses.ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourseById(int id)
        {
            // TODO: Your code here
            await Task.Yield();

            return null;
        }

        [HttpPost("")]
        public async Task<ActionResult<Course>> PostCourse(Course model)
        {
            // TODO: Your code here
            await Task.Yield();

            return null;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourse(int id, Course model)
        {
            // TODO: Your code here
            await Task.Yield();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Course>> DeleteCourseById(int id)
        {
            // TODO: Your code here
            await Task.Yield();

            return null;
        }
    }
}