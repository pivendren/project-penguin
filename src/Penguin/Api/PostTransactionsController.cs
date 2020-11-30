using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Penguin.Database;
using Penguin.Database.Models;
using Penguin.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Penguin.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostTransactionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PostTransactionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PostTransactions
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<PostTransactionDto>>> GetPostTransactions()
        //{
        //    return await _context.PostTransactions.ToListAsync();
        //}

        // GET: api/PostTransactions/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<PostTransactionDto>> GetPostTransaction(int id)
        //{
        //    var postTransaction = await _context.PostTransactions.FindAsync(id);

        //    if (postTransaction == null)
        //    {
        //        return NotFound();
        //    }

        //    return postTransaction;
        //}

        //TODO
        //// PUT: api/PostTransactions/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutPostTransaction(int id, PostTransaction postTransaction)
        //{
        //    if (id != postTransaction.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(postTransaction).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PostTransactionExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //TODO add auth validation
        // POST: api/PostTransactions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PostTransactionDto>> PostPostTransaction(PostTransactionDto pt)
        {
            _context.PostTransactions.Add(new PostTransaction
            {
                accountNumber = pt.accountNumber,
                cardId = pt.card.id,
                categoryCode = pt.merchant.category.code,
                categoryKey = pt.merchant.category.key,
                categoryName = pt.merchant.category.name,
                centsAmount = pt.centsAmount,
                countryAlpha3 = pt.merchant.country.alpha3,
                countryCode = pt.merchant.country.code,
                countryName = "South Africa",
                currencyCode = pt.currencyCode,
                dateTime = pt.dateTime,
                merchantCity = pt.merchant.city,
                merchantName = pt.merchant.name,
                reference = pt.reference,
                type = pt.type
            });
            await _context.SaveChangesAsync();

            return Ok();
            //TODO
            //return CreatedAtAction("GetPostTransaction", new { id = pt.Id }, pt);
        }

        //TODO
        // DELETE: api/PostTransactions/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<PostTransaction>> DeletePostTransaction(int id)
        //{
        //    var postTransaction = await _context.PostTransactions.FindAsync(id);
        //    if (postTransaction == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.PostTransactions.Remove(postTransaction);
        //    await _context.SaveChangesAsync();

        //    return postTransaction;
        //}

        //private bool PostTransactionExists(int id)
        //{
        //    return _context.PostTransactions.Any(e => e.Id == id);
        //}
    }
}