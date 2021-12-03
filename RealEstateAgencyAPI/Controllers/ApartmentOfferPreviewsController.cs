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
    public class ApartmentOfferPreviewsController : ControllerBase
    {
        private readonly estate_agency_dbContext _context;

        public ApartmentOfferPreviewsController(estate_agency_dbContext context)
        {
            _context = context;
        }

        //GET: api/ApartmentOfferPreviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApartmentOfferPreview>>> GetApartmentOfferPreviews()
        {
            return await _context.ApartmentOfferPreviews.ToListAsync();
        }
    }
}
