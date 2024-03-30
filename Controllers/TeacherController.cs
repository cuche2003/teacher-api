using Microsoft.AspNetCore.Mvc;
using TeacherAPI.Models;

namespace TeacherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private static readonly Teacher[] _teachers = new[]
        {
            new Teacher{Id = 1, Name = "Nguyen Van A", DOB = DateTime.Parse("12/03/1980"), Email = "nguyenvana@gmail.com", Degree = "Bachelor"},
            new Teacher{Id = 2, Name = "Tran Thi B", DOB = DateTime.Parse("12/03/1969"), Email = "tranthib@gmail.com", Degree = "Doctorate"}
        };

        private readonly ILogger<TeacherController> _logger;

        public TeacherController(ILogger<TeacherController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTeachers")]
        public IEnumerable<Teacher> Get()
        {
            return _teachers;
        }
    }
}
