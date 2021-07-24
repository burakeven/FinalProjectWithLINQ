using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //ATTRIBUTE -- bir class ile ilgili bilgi verme, imzalama yöntemidir.
    public class ProductsController : ControllerBase
    {
        //naming convention
        //IoC Container -- Inversion of Control
        IProductService _productService; //fieldların default'u private'dır.

        public ProductsController(IProductService productService) // Loosely Coupled -- buna gevşek bağlılık denir.
        {
            _productService = productService; //const içinde productService'e dışarıdan ulaşamayız
            //bu yüzden _productService'e atarız ki alt bloklarda ona ulaşabilelim.
            //Bu olay c# ve javada vardır. Javascriptte falan const içine ulaşabilirsin.
        }

        [HttpGet("getall")]
        public IActionResult GetAll() //IActionResult'dan önce List döndürüyorduk
        {
            //Swagger
            //get requestlerde 200 ile çalışırız.
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")] //silme ve güncelleme içinde HttpPost kullanılabilir. Gerçek hayat projelerinde %99 HttpPost kullanılır.
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
