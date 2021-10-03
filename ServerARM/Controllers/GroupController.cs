namespace ServerARM.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ServerARM.Interface;
    using ServerARM.Models;
    using System.Collections.Generic;
    using System.Linq;

    [ApiController]
    [Route("api/[controller]")]
    public class GroupController : Controller
    {
        private IGroupRepository _groupRepository;
        public GroupController(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
        [HttpGet]
        [Route("select")]
        public IEnumerable<Group> select()
            => _groupRepository.Select();
        [HttpGet]
        [Route("get")]
        public Group get()
            => _groupRepository.Select().FirstOrDefault();
        [HttpGet]
        [Route("insert")]
        public void insert(Group entity)
            => _groupRepository.Insert(entity);
        [HttpGet]
        [Route("update")]
        public void update(Group entity)
            => _groupRepository.Update(entity);
        [HttpGet]
        [Route("delete")]
        public void delete(int id)
            => _groupRepository.Delete(id);

        protected override void Dispose(bool disposing)
        {
            _groupRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
