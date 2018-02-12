using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dto;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            // finf the customer that want to rent
            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);

            // find all the movies the customer want to rent
            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            // create rental object for each (customer+moview) and add to rentals
            foreach (var movie in movies)
            {
                // preventing hacker brute force
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Movie = movie,
                    DateRented = DateTime.Now,
                    Customer = customer
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges(); // update db

            return Ok();
        }
    }
}
