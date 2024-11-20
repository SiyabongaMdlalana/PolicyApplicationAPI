using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PolicyApplicationAPI.Database;
using PolicyApplicationAPI.Models;

namespace PolicyApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyHoldersController : ControllerBase
    {
        private readonly PolicyManagementDbContext _context;

        public PolicyHoldersController(PolicyManagementDbContext context)
        {
            _context = context;
        }

        // GET: api/PolicyHolders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PolicyHolder>>> GetPolicyHolders()
        {
            return await _context.PolicyHolders.ToListAsync();
        }

        // GET: api/PolicyHolders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PolicyHolder>> GetPolicyHolder(int id)
        {
            var policyHolder = await _context.PolicyHolders.FindAsync(id);

            if (policyHolder == null)
            {
                return NotFound();
            }

            return policyHolder;
        }

        // PUT: api/PolicyHolders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPolicyHolder(int id, PolicyHolder policyHolder)
        {
            if (id != policyHolder.PolicyHolderId)
            {
                return BadRequest();
            }

            _context.Entry(policyHolder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PolicyHolderExists(id))
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

        // POST: api/PolicyHolders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PolicyHolder>> PostPolicyHolder(PolicyHolder policyHolder)
        {
            _context.PolicyHolders.Add(policyHolder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPolicyHolder", new { id = policyHolder.PolicyHolderId }, policyHolder);
        }

        // DELETE: api/PolicyHolders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePolicyHolder(int id)
        {
            var policyHolder = await _context.PolicyHolders.FindAsync(id);
            if (policyHolder == null)
            {
                return NotFound();
            }

            _context.PolicyHolders.Remove(policyHolder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PolicyHolderExists(int id)
        {
            return _context.PolicyHolders.Any(e => e.PolicyHolderId == id);
        }
    }
}
