using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GroceryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroceryController : ControllerBase
    {
        private ILogger<GroceryController> _logger;
        public GroceryController(ILogger<GroceryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public GroceryItem Get()
        {
            return new GroceryItem
            {
                Name = "value1",
                Price = 2
            };
        }

        [HttpPost]
        public GroceryItem Post(GroceryItem item)
        {
            return item;
        }
    }
}