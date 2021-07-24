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

        [HttpGet]
        public List<Product> Get()
        {
            
            var result = _productService.GetAll();
            return result.Data;
        }
    }
}
