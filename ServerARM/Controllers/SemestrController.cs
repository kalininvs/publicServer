namespace ServerARM.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ServerARM.Interface;
    using ServerARM.Models;
    using System.Collections.Generic;
    using System.Linq;

    [ApiController]
    [Route("api/[controller]")]
    public class SemestrController:Controller
    {
        private ISemestrRepository _semestrRepository;
        public SemestrController(ISemestrRepository semestrRepository)
        {
            _semestrRepository = semestrRepository;
        }
        [HttpGet]
        [Route("select")]
        public IEnumerable<Semestr> select()
            => _semestrRepository.Select();
        [HttpGet]
        [Route("get")]
        public Semestr get()
            => _semestrRepository.Select().FirstOrDefault();
        [HttpGet]
        [Route("insert")]
        public void insert(Semestr entity)
            => _semestrRepository.Insert(entity);
        [HttpGet]
        [Route("update")]
        public void update(Semestr entity)
            => _semestrRepository.Update(entity);
        [HttpGet]
        [Route("delete")]
        public void delete(int id)
            => _semestrRepository.Delete(id);

        protected override void Dispose(bool disposing)
        {
            _semestrRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
