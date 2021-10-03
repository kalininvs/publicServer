namespace ServerARM.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ServerARM.Interface;
    using ServerARM.Models;
    using System.Collections.Generic;
    using System.Linq;

    [ApiController]
    [Route("api/[controller]")]
    public class ItemSemestrController : Controller
    {
        private IItemSemestrRepository _itemSemestrRepository;
        public ItemSemestrController(IItemSemestrRepository itemSemestrRepository)
        {
            _itemSemestrRepository = itemSemestrRepository;
        }
        [HttpGet]
        [Route("select")]
        public IEnumerable<ItemSemestr> select()
            => _itemSemestrRepository.Select();
        [HttpGet]
        [Route("get")]
        public ItemSemestr get()
            => _itemSemestrRepository.Select().FirstOrDefault();
        [HttpGet]
        [Route("insert")]
        public void insert(ItemSemestr entity)
            => _itemSemestrRepository.Insert(entity);
        [HttpGet]
        [Route("update")]
        public void update(ItemSemestr entity)
            => _itemSemestrRepository.Update(entity);
        [HttpGet]
        [Route("delete")]
        public void delete(int id)
            => _itemSemestrRepository.Delete(id);

        protected override void Dispose(bool disposing)
        {
            _itemSemestrRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
