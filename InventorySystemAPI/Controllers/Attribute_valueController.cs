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
using Microsoft.AspNetCore.Authorization;
using InventorySystemAPI.Helpers;

namespace InventorySystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Attribute_valueController : ControllerBase
    {
        private readonly StockContext _context;
        private readonly IAttributeValues _attributeValuesRepository;

        public Attribute_valueController(StockContext context, IAttributeValues attributeValuesRepository)
        {
            _context = context;
            _attributeValuesRepository = attributeValuesRepository;
        }

        // GET: api/Attribute_value
        [HttpGet]
        public IEnumerable<Attribute_value> GetAttribute_values()
        {
            return _context.Attribute_values;
        }

        // GET: api/Attribute_value/attribute_id
        [HttpGet("{attribute_id}")]
        public async Task<IActionResult> GetAttribute_ValuesById(int attribute_id)
        {
            var attribute_values = await _attributeValuesRepository.GetAllAttributeValuesById(attribute_id);

            return Ok(attribute_values);
        }

        // GET: api/Attribute_value/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAttribute_value([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var attribute_value = await _context.Attribute_values.FindAsync(id);

            if (attribute_value == null)
            {
                return NotFound();
            }

            return Ok(attribute_value);
        }

        // PUT: api/Attribute_value/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAttribute_value([FromRoute] int id, [FromBody] Attribute_value attribute_value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != attribute_value.attribute_value_id)
            {
                return BadRequest();
            }

            _context.Entry(attribute_value).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Attribute_valueExists(id))
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

        // POST: api/Attribute_value
        [HttpPost]
        public async Task<IActionResult> PostAttribute_value([FromBody] Attribute_value attribute_value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Attribute_values.Add(attribute_value);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAttribute_value", new { id = attribute_value.attribute_value_id }, attribute_value);
        }
        
        // DELETE: api/Attribute_value/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAttribute_value([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var attribute_value = await _context.Attribute_values.FindAsync(id);

            if (attribute_value == null)
            {
                return NotFound();
            }

            _context.Attribute_values.Remove(attribute_value);
            await _context.SaveChangesAsync();

            return Ok(attribute_value);
        }

        private bool Attribute_valueExists(int id)
        {
            return _context.Attribute_values.Any(e => e.attribute_value_id == id);
        }

        private bool AttributesIdExists(int id)
        {
            return _context.Attributes.Any(e => e.attribute_id == id);
        }
    }
}