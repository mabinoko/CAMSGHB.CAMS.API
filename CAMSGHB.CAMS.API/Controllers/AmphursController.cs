using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CAMSGHB.CAMS.API.Models;

namespace CAMSGHB.CAMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmphursController : ControllerBase
    {
        private readonly DBCams3context _context;

        public AmphursController(DBCams3context context)
        {
            _context = context;
        }

        // GET: api/Amphurs/5
        [HttpGet]
        public async Task<IActionResult> GetAmphur([FromQuery]Amphur data)
        {
            try
            {
                IQueryable<Amphur> iQueryData;
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                iQueryData = _context.Amphur;
                if (data.AmphurId != 0)
                {
                    iQueryData = _context.Amphur.Where(x => x.AmphurId == data.AmphurId);
                }

                if (!string.IsNullOrEmpty(data.AmphurName))
                {
                    iQueryData = _context.Amphur.Where(x => x.AmphurName == data.AmphurName).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AmphurCode))
                {
                    iQueryData = _context.Amphur.Where(x => x.AmphurCode == data.AmphurCode).AsQueryable();
                }
                
                if (!string.IsNullOrEmpty(data.ProvinceCode))
                {
                    iQueryData = _context.Amphur.Where(x => x.ProvinceCode == data.ProvinceCode).AsQueryable();
                }

                if (data.Status != null)
                {
                    iQueryData = _context.Amphur.Where(x => x.Status == data.Status).AsQueryable();
                }



                return Ok(iQueryData);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        //PUT: api/Amphurs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmphur([FromRoute] long id, [FromBody] Amphur amphur)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != amphur.AmphurId)
            {
                return BadRequest();
            }

            _context.Entry(amphur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmphurExists(id))
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

        // POST: api/Amphurs

        [HttpPost]
        public async Task<IActionResult> PostAmphur([FromBody] Amphur amphur)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Amphur.Add(amphur);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAmphur", new { id = amphur.AmphurId }, amphur);
        }

        // DELETE: api/Amphurs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAmphur([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var amphur = await _context.Amphur.FindAsync(id);
            if (amphur == null)
            {
                return NotFound();
            }

            _context.Amphur.Remove(amphur);
            await _context.SaveChangesAsync();

            return Ok(amphur);
        }

        private bool AmphurExists(long id)
        {
            return _context.Amphur.Any(e => e.AmphurId == id);
        }
    }
}