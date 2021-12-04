using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateAgencyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentOffersController : ControllerBase
    {
        private readonly estate_agency_dbContext _context;

        public ApartmentOffersController(estate_agency_dbContext context)
        {
            _context = context;
        }

        //GET: api/ApartmentOffers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApartmentOffer>>> GetApartmentOffers()
        {
            return await _context.ApartmentOffers.ToListAsync();
        }

        [HttpGet("{id_offers}")]
        public async Task<ActionResult<ApartmentOffer>> GetApartmentOffer(int id_offers)
        {
            var apartmentOffer = await _context.ApartmentOffers.FindAsync(id_offers);

            if(apartmentOffer == null)
            {
                return NotFound();
            }

            return apartmentOffer;
        }
    }
}
