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
    public class EstateOfferPreviewsController : ControllerBase
    {
        private readonly estate_agency_dbContext _context;

        public EstateOfferPreviewsController(estate_agency_dbContext context)
        {
            _context = context;
        }

        //GET: api/EstateOfferPreviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstateOfferPreview>>> GetEstateOfferPreviews()
        {
            return await _context.EstateOfferPreviews.ToListAsync();
        }
    }
}
