using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Lab1_3.Models;

namespace Lab1_3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Lab1Controller : ControllerBase
    {
        private static List<PlayerData> _memCache = new List<PlayerData>();

        [HttpGet]
        public ActionResult<IEnumerable<PlayerData>> Get()
        {
            return _memCache;
        }

        [HttpGet("{id}")]
        public ActionResult<PlayerData> Get(int id)
        {
            if (_memCache.Count <= id) throw new IndexOutOfRangeException("Такого игрока нет");

            return _memCache[id];
        }

        [HttpPost]
        public void Post([FromBody] PlayerData value)
        {
            _memCache.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PlayerData value)
        {
            if (_memCache.Count <= id) throw new IndexOutOfRangeException("Такого игрока нет");

            _memCache[id] = value;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (_memCache.Count <= id) throw new IndexOutOfRangeException("Такого игрока нет");

            _memCache.RemoveAt(id);
        }
    }
}
