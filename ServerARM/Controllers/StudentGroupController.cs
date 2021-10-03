namespace ServerARM.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ServerARM.Interface;
    using ServerARM.Models;
    using System.Collections.Generic;
    using System.Linq;

    [ApiController]
    [Route("api/[controller]")]
    public class StudentGroupController:Controller
    {
        private IStudentGroupRepository _studentGroupRepository;
        public StudentGroupController(IStudentGroupRepository studentGroupRepository)
        {
            _studentGroupRepository = studentGroupRepository;
        }
        [HttpGet]
        [Route("select")]
        public IEnumerable<StudentGroup> select()
            => _studentGroupRepository.Select();
        [HttpGet]
        [Route("get")]
        public StudentGroup get()
            => _studentGroupRepository.Select().FirstOrDefault();
        [HttpGet]
        [Route("insert")]
        public void insert(StudentGroup entity)
            => _studentGroupRepository.Insert(entity);
        [HttpGet]
        [Route("update")]
        public void update(StudentGroup entity)
            => _studentGroupRepository.Update(entity);
        [HttpGet]
        [Route("delete")]
        public void delete(int id)
            => _studentGroupRepository.Delete(id);

        protected override void Dispose(bool disposing)
        {
            _studentGroupRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
