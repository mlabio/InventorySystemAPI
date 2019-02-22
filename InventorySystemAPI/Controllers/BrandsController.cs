using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventorySystemAPI.Entity;
using InventorySystemAPI.Models;

namespace InventorySystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly StockContext _context;

        public BrandsController(StockContext context)
        {
            _context = context;
        }

        // GET: api/Brands
        [HttpGet]
        public IEnumerable<Brands> GetBrands()
        {
            return _context.Brands.OrderByDescending(a => a.brand_id);
        }

        // GET: api/Brands/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrands([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var brands = await _context.Brands.FindAsync(id);

            if (brands == null)
            {
                return NotFound();
            }

            return Ok(brands);
        }

        // PUT: api/Brands/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBrands([FromRoute] int id, [FromBody] Brands brands)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != brands.brand_id)
            {
                return BadRequest();
            }

            _context.Entry(brands).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BrandsExists(id))
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

        // POST: api/Brands
        [HttpPost]
        public async Task<IActionResult> PostBrands([FromBody] Brands brands)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Brands.Add(brands);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBrands", new { id = brands.brand_id }, brands);
        }

        // DELETE: api/Brands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrands([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var brands = await _context.Brands.FindAsync(id);
            if (brands == null)
            {
                return NotFound();
            }

            _context.Brands.Remove(brands);
            await _context.SaveChangesAsync();

            return Ok(brands);
        }

        private bool BrandsExists(int id)
        {
            return _context.Brands.Any(e => e.brand_id == id);
        }
    }
}