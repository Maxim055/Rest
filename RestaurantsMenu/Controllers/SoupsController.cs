﻿using System.Collections.Generic;
using System.Linq;
using BusinessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantsMenu.Controllers
{
    [Route("api/soups")]
    [Produces("application/json")]
    public class SoupsController : Controller
    {
        private ProductsRepository productsRepository;
        public SoupsController()
        {
            this.productsRepository = new ProductsRepository();
        }

        // GET api/<controller>
        [HttpGet]
        public IEnumerable<Soup> Get()
        {
            return this.productsRepository.GetAll<Soup>();
        }

        // GET api/<controller>/5
        [HttpGet("{restaurantName}")]
        public IActionResult Get(string restaurantName)
        {
            var result = this.productsRepository.Get<Soup>(restaurantName);
            if (result == null)
            {
                return new StatusCodeResult(404);
            }
            return new JsonResult(result);
        }

        // GET api/<controller>?restaurantName=max&id=4
        [HttpGet("{restaurantName}/{id}")]
        [Authorize(Policy = "Restaurant")]
        public IActionResult Get(string restaurantName, int id)
        {
            var result = this.productsRepository.Get<Soup>(restaurantName).Where(a => a.Id == id).First();
            if (result == null)
            {
                return new StatusCodeResult(404);
            }
            return new JsonResult(result);
        }

        // POST api/<controller>
        [HttpPost]
        [Authorize(Policy = "Restaurant")]
        public IActionResult Post([FromBody]Soup value)
        {
            var result = this.productsRepository.CreateProduct(value);
            if (result == false)
            {
                return new StatusCodeResult(202);
            }
            return new JsonResult(result);
        }

        // PUT api/<controller>/5
        [HttpPut]
        [Authorize(Policy = "Restaurant")]
        public IActionResult Put([FromBody]Soup value)
        {
            var result = this.productsRepository.UpdateProduct(value);
            if (result == false)
            {
                return new StatusCodeResult(202);
            }
            return new JsonResult(result);
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        [Authorize(Policy = "Restaurant")]
        public IActionResult Delete([FromBody]Soup product)
        {
            var result = this.productsRepository.DeleteProduct(product);
            if (result == false)
            {
                return new StatusCodeResult(202);
            }
            return new JsonResult(result);
        }
    }
}