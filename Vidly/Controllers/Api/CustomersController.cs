﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dto;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // Get /Api/Customers
        public IHttpActionResult GetCustomers()
        {
            var customerDtos = _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);
            return Ok(customerDtos);
        }

        // Get /Api/Customer/1
        public IHttpActionResult GetCustomer(int Id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == Id);

            if (customer == null)
                return NotFound();

            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }

        // Post /Api/Customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
        }

        // Put /Api/Customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int Id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDB = _context.Customers.SingleOrDefault(c => c.Id == Id);

            if (customerInDB == null)
                return NotFound();

            Mapper.Map(customerDto, customerInDB);

            _context.SaveChanges();

            return Ok();

        }

        // Delete /Api/Customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int Id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDB = _context.Customers.SingleOrDefault(c => c.Id == Id);

            if (customerInDB == null)
                return NotFound();

            _context.Customers.Remove(customerInDB);

            _context.SaveChanges();

            return Ok();

            
        }
    }
}
