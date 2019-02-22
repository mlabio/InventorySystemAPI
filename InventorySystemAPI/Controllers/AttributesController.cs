using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventorySystemAPI.Entity;
using InventorySystemAPI.Models;
using InventorySystemAPI.Interfaces;

namespace InventorySystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributesController : ControllerBase
    {
        private readonly StockContext _context;
        private readonly IAttributesRepository _attributeRespository;

        public AttributesController(StockContext context, IAttributesRepository attributeRepository)
        {
            _context = context;
            _attributeRespository = attributeRepository;
        }

        // GET: api/Attributes
        [HttpGet]
        public IEnumerable<Attributes> GetAttributes()
        {
            return _context.Attributes.OrderByDescending(a => a.attribute_id);
        }

        // GET: api/Attributes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAttributes([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var attributes = await _context.Attributes.FindAsync(id);

            if (attributes == null)
            {
                return NotFound();
            }

            return Ok(attributes);
        }

        // PUT: api/Attributes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAttributes([FromRoute] int id, [FromBody] Attributes attributes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != attributes.attribute_id)
            {
                return BadRequest();
            }

            _context.Entry(attributes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AttributesExists(id))
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

        // POST: api/Attributes
        [HttpPost]
        public async Task<IActionResult> PostAttributes([FromBody] Attributes attributes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Attributes.Add(attributes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAttributes", new { id = attributes.attribute_id }, attributes);
        }

        [HttpDelete("{attribute_id}")]
        public async Task<IActionResult> DeleteAttributeById(int attribute_id)
        {
            return Ok(await _attributeRespository.DeleteAttribute(attribute_id));
        }

        private bool AttributesExists(int id)
        {
            return _context.Attributes.Any(e => e.attribute_id == id);
        }
    }
}