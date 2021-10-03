namespace ServerARM.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ServerARM.Interface;
    using ServerARM.Models;
    using System.Collections.Generic;
    using System.Linq;

    [ApiController]
    [Route("api/[controller]")]
    public class UserController:Controller
    {
        private IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        [Route("select")]
        public IEnumerable<User> select()
            => _userRepository.Select();
        [HttpGet]
        [Route("get")]
        public User get()
            => _userRepository.Select().FirstOrDefault();
        [HttpGet]
        [Route("insert")]
        public void insert(User entity)
            => _userRepository.Insert(entity);
        [HttpGet]
        [Route("update")]
        public void update(User entity)
            => _userRepository.Update(entity);
        [HttpGet]
        [Route("delete")]
        public void delete(int id)
            => _userRepository.Delete(id);

        protected override void Dispose(bool disposing)
        {
            _userRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
