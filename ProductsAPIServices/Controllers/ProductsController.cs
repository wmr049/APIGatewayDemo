using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProductsAPIServices.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController  : Controller
    {
        [HttpGet]  
        public IEnumerable<string> Get()  
        {  
            return new string[] { "Catcher Wong", "James Li" };  
        }  
    
        [HttpGet("{id}")]  
        public string Get(int id)  
        {  
            return $"Catcher Wong - {id}";  
        }       
    }
}