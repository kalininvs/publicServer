namespace ServerARM.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ServerARM.Interface;
    using ServerARM.Models;
    using ServerARM.Repository;
    using System.Collections.Generic;
    using System.Linq;

    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : Controller
    {
        private IItemRepository _itemRepository;
        public ItemController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        [HttpGet]
        [Route("select")]
        public IEnumerable<Item> select()
            => _itemRepository.Select();
        [HttpGet]
        [Route("get")]
        public Item get()
            => _itemRepository.Select().FirstOrDefault();
        [HttpGet]
        [Route("insert")]
        public void insert(Item entity)
            => _itemRepository.Insert(entity);
        [HttpGet]
        [Route("update")]
        public void update(Item entity)
            => _itemRepository.Update(entity);
        [HttpGet]
        [Route("delete")]
        public void delete(int id)
            => _itemRepository.Delete(id);

        protected override void Dispose(bool disposing)
        {
            _itemRepository.Dispose();
            base.Dispose(disposing);
        }

    }
}
