using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealEstateAgencyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace RealEstateAgencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferPreviewsController : ControllerBase
    {
        private readonly estate_agency_dbContext _context;

        public OfferPreviewsController(estate_agency_dbContext context)
        {
            _context = context;
        }

        //GET: api/OfferPreviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstateOfferPreview>>> GetOfferPreviews()
        {
            return await _context.EstateOfferPreviews.ToListAsync();
        }
    }
}
