﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Puppy_Project.Models.Order;
using Puppy_Project.Services.Order;

namespace Puppy_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrder _order;
        public OrderController(IOrder order) 
        {
            _order = order;
        }



        [HttpGet("{id:int}")]
        public IActionResult ListUserOrder(int id)
        {
            var order_list = _order.ListUserOrder(id);
            return Ok(order_list);
        }

        [HttpPost]
        public IActionResult CreateOrder(inputOrderDTO order)
        {
            bool isAdded = _order.AddUserOrder(order);
            return isAdded ? Ok(isAdded) : BadRequest();
        }
    }
}
