﻿using AutoMapper;
using DTO;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Servicess;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyShop.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductServices services;
        IMapper mapper;
        public ProductsController(IProductServices services,IMapper mapper)
        {
            this.services = services;
            this.mapper = mapper;
        }
        // GET: api/<ProductsController>
        [HttpGet]


        public async Task<ActionResult<List<ProductDTO>>> Get()
        {
            List<Product> products = await services.Get();
            List<ProductDTO> productsDTO = mapper.Map<List<Product>, List<ProductDTO>>(products);
            if (productsDTO != null)
                return Ok(productsDTO);
            return BadRequest();
        }

       
       
    }
}