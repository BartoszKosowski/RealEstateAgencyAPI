using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateAgencyAPI.Models;

namespace RealEstateAgencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeInfoesController : ControllerBase
    {
        private readonly estate_agency_dbContext _context;

        public TradeInfoesController(estate_agency_dbContext context)
        {
            _context = context;
        }

        // GET: api/TradeInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TradeInfo>>> GetTradeInfos()
        {
            return await _context.TradeInfos.ToListAsync();
        }

        // GET: api/TradeInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TradeInfo>> GetTradeInfo(byte id)
        {
            var tradeInfo = await _context.TradeInfos.FindAsync(id);

            if (tradeInfo == null)
            {
                return NotFound();
            }

            return tradeInfo;
        }

        //GET: api/TradeInfoes/domain#tradeArea
        [HttpGet("domain/{domain}")]
        public List<TradeInfo> GetTradeInfoByDomain(string domain)
        {
            var tradeInfos = _context.TradeInfos.Where(x => x.Domain == domain).Select(x => x).Distinct();

            if(tradeInfos == null)
            {
                return ((IQueryable<TradeInfo>)NotFound()).ToList();
            }

            return tradeInfos.ToList();
        }

        // PUT: api/TradeInfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTradeInfo(byte id, TradeInfo tradeInfo)
        {
            if (id != tradeInfo.IdInfo)
            {
                return BadRequest();
            }

            _context.Entry(tradeInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TradeInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TradeInfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TradeInfo>> PostTradeInfo(TradeInfo tradeInfo)
        {
            _context.TradeInfos.Add(tradeInfo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TradeInfoExists(tradeInfo.IdInfo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTradeInfo", new { id = tradeInfo.IdInfo }, tradeInfo);
        }

        // DELETE: api/TradeInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTradeInfo(byte id)
        {
            var tradeInfo = await _context.TradeInfos.FindAsync(id);
            if (tradeInfo == null)
            {
                return NotFound();
            }

            _context.TradeInfos.Remove(tradeInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TradeInfoExists(byte id)
        {
            return _context.TradeInfos.Any(e => e.IdInfo == id);
        }
    }
}
