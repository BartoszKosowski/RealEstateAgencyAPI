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
        public async Task<ActionResult<EstateOffer>> GetEstateOffer(int id_offers)
        {
            var estateOffer = await _context.EstateOffers.Where(e => e.IdOffers == id_offers).FirstOrDefaultAsync<EstateOffer>();

            if (estateOffer == null)
            {
                return NotFound();
            }

            return Ok(estateOffer);
        }
    }
}
