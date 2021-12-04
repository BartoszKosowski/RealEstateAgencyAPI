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
    public class EstateOffersController : ControllerBase
    {
        private readonly estate_agency_dbContext _context;

        public EstateOffersController(estate_agency_dbContext context)
        {
            _context = context;
        }

        //GET: api/EstateOffers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstateOffer>>> GetEstateOffers()
        {
            return await _context.EstateOffers.ToListAsync();
        }

        [HttpGet("{id_offers}")]
        public ActionResult<EstateOffer> GetEstateOffer(int id_offers)
        {
            var estateOffer = from offer in _context.EstateOffers
                              where offer.IdOffers == id_offers
                              select offer;

            if (estateOffer == null)
            {
                return NotFound();
            }

            return Ok(estateOffer);
        }
    }
}
