namespace ServerARM.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ServerARM.Interface;
    using ServerARM.Models;
    using System.Collections.Generic;
    using System.Linq;

    [ApiController]
    [Route("api/[controller]")]
    public class RoleController:Controller
    {
        private IRoleRepository _roleRepository;
        public RoleController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        [HttpGet]
        [Route("select")]
        public IEnumerable<Role> select()
            => _roleRepository.Select();
        [HttpGet]
        [Route("get")]
        public Role get()
            => _roleRepository.Select().FirstOrDefault();
        [HttpGet]
        [Route("insert")]
        public void insert(Role entity)
            => _roleRepository.Insert(entity);
        [HttpGet]
        [Route("update")]
        public void update(Role entity)
            => _roleRepository.Update(entity);
        [HttpGet]
        [Route("delete")]
        public void delete(int id)
            => _roleRepository.Delete(id);

        protected override void Dispose(bool disposing)
        {
            _roleRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
