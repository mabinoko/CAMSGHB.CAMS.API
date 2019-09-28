using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CAMSGHB.CAMS.API.Models;
using CAMSGHB.CAMS.API.Enum;

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
                return  Ok(iQueryData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromQuery] string amphurName , [FromQuery]string amphurCode, [FromQuery]string provinceCode, [FromQuery]bool status)
        {
            try
            {
                var insertData = new Amphur
                {
                    AmphurName = amphurName,
                    AmphurCode = amphurCode,
                    ProvinceCode = provinceCode,
                    Status = status
                };
                using (var context = new DBCams3context())
                {
                    context.Amphur.Add(insertData);
                    context.SaveChanges();
                }
                return Ok(EnumMessage.StatusMessage.Success.DataSaved);
            }
            catch (Exception ex) 
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{AmphurId}")]
        public async Task<IActionResult> PutAmphur([FromRoute] long AmphurId, [FromQuery] string amphurName, [FromQuery]string amphurCode, [FromQuery]string provinceCode, [FromQuery]bool status)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                using (var context = new DBCams3context())
                {
                    var getDataUpdate = (from updateData in context.Amphur
                                         where updateData.AmphurId == AmphurId
                                         select updateData).FirstOrDefault();
                    if(getDataUpdate != null)
                    {
                        getDataUpdate.AmphurName = amphurName;
                        getDataUpdate.AmphurCode = amphurCode;
                        getDataUpdate.ProvinceCode = provinceCode;
                        getDataUpdate.Status = status;
                       
                    }
                     _context.Update(getDataUpdate);
                     await _context.SaveChangesAsync();
                }
                return Ok(EnumMessage.StatusMessage.Success.DataSaveChange);
               
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmphurExists(AmphurId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        [HttpDelete("{AmphurId}")]
        public async Task<IActionResult> DeleteAmphur([FromRoute] long AmphurId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var amphur = await _context.Amphur.FindAsync(AmphurId);
            if (amphur == null)
            {
                return NotFound();
            }

            _context.Amphur.Remove(amphur);
            await _context.SaveChangesAsync();

            return Ok(EnumMessage.StatusMessage.Success.DataIsDeleted);
        }

        private bool AmphurExists(long id)
        {
            return _context.Amphur.Any(e => e.AmphurId == id);
        }
    }
}