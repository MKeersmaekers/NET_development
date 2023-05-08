using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.DAL.Data;
using Shop.DAL.Models;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOrdersController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductOrdersController(ShopContext context)
        {
            _context = context;
        }

        // GET: api/ProductOrders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductOrder>>> GetProductOrders()
        {
          if (_context.ProductOrders == null)
          {
              return NotFound();
          }
            return await _context.ProductOrders.ToListAsync();
        }

        // GET: api/ProductOrders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductOrder>> GetProductOrder(int id)
        {
          if (_context.ProductOrders == null)
          {
              return NotFound();
          }
            var productOrder = await _context.ProductOrders.FindAsync(id);

            if (productOrder == null)
            {
                return NotFound();
            }

            return productOrder;
        }

        // PUT: api/ProductOrders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductOrder(int id, ProductOrder productOrder)
        {
            if (id != productOrder.Id)
            {
                return BadRequest();
            }

            _context.Entry(productOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductOrderExists(id))
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

        // POST: api/ProductOrders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductOrder>> PostProductOrder(ProductOrder productOrder)
        {
          if (_context.ProductOrders == null)
          {
              return Problem("Entity set 'ShopContext.ProductOrders'  is null.");
          }
            _context.ProductOrders.Add(productOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductOrder", new { id = productOrder.Id }, productOrder);
        }

        // DELETE: api/ProductOrders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductOrder(int id)
        {
            if (_context.ProductOrders == null)
            {
                return NotFound();
            }
            var productOrder = await _context.ProductOrders.FindAsync(id);
            if (productOrder == null)
            {
                return NotFound();
            }

            _context.ProductOrders.Remove(productOrder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductOrderExists(int id)
        {
            return (_context.ProductOrders?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
