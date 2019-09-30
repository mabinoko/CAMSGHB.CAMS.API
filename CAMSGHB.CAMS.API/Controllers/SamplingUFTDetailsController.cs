using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CAMSGHB.CAMS.API.Models;
using CAMSGHB.CAMS.API.Enum;
using Microsoft.AspNetCore.Cors;

namespace CAMSGHB.CAMS.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyCORSPolicy")]
    [ApiController]
    public class SamplingUFTDetailsController : ControllerBase
    {
        private readonly DBCams3context _context;

        public SamplingUFTDetailsController(DBCams3context context)
        {
            _context = context;
        }

        // GET: api/SamplingUFTDetails/5
        [HttpGet]
        public async Task<IActionResult> GetSamplingUFTDetail([FromQuery] SamplingUFTDetail data)
        {
            try
            {
                IQueryable<SamplingUFTDetail> iQueryData;
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                iQueryData = _context.SamplingUFTDetail;

                if (data.RSubAppraisalID != 0 )
                {
                    iQueryData = _context.SamplingUFTDetail.Where(x => x.RSubAppraisalID == data.RSubAppraisalID).AsQueryable();
                }
                if (data.RAppraisalID != 0)
                {
                    iQueryData = _context.SamplingUFTDetail.Where(x => x.RAppraisalID == data.RAppraisalID).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.CIFName))
                {
                    iQueryData = _context.SamplingUFTDetail.Where(x => x.CIFName == data.CIFName).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.AANo))
                {
                    iQueryData = _context.SamplingUFTDetail.Where(x => x.AANo == data.AANo).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.RoomNo))
                {
                    iQueryData = _context.SamplingUFTDetail.Where(x => x.RoomNo == data.RoomNo).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.BuildingNo))
                {
                    iQueryData = _context.SamplingUFTDetail.Where(x => x.BuildingNo == data.BuildingNo).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.RegisterNumber))
                {
                    iQueryData = _context.SamplingUFTDetail.Where(x => x.RegisterNumber == data.RegisterNumber).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.FloorNoCondo))
                {
                    iQueryData = _context.SamplingUFTDetail.Where(x => x.FloorNoCondo == data.FloorNoCondo).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.PositionLatitude))
                {
                    iQueryData = _context.SamplingUFTDetail.Where(x => x.PositionLatitude == data.PositionLatitude).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.PositionLongtitude))
                {
                    iQueryData = _context.SamplingUFTDetail.Where(x => x.PositionLongtitude == data.PositionLongtitude).AsQueryable();
                }
                if (data.chkconstruction != null)
                {
                    iQueryData = _context.SamplingUFTDetail.Where(x => x.chkconstruction == data.chkconstruction).AsQueryable();
                }
                return Ok(iQueryData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/SamplingUFTDetails/5
        [HttpPut("{RSubAppraisalID}")]
        public async Task<IActionResult> PutSamplingUFTDetail([FromRoute] long RSubAppraisalID,[FromQuery] long RAppraisalID, [FromQuery] string CIFName, [FromQuery] string AANo, [FromQuery]string RoomNo,
            [FromQuery]string BuildingNo, [FromQuery]string RegisterNumber, [FromQuery]string FloorNoCondo, [FromQuery]string PositionLatitude, [FromQuery]string PositionLongtitude, [FromQuery]bool chkconstruction)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                using (var context = new DBCams3context()) 
                {
                    var getDataUpdate = (from updateData in context.SamplingUFTDetail
                                         where updateData.RSubAppraisalID == RSubAppraisalID
                                         select updateData).FirstOrDefault();
                    if (getDataUpdate != null)
                    {
                        getDataUpdate.RSubAppraisalID = RSubAppraisalID;
                        getDataUpdate.RAppraisalID = RAppraisalID;
                        getDataUpdate.CIFName = CIFName;
                        getDataUpdate.AANo = AANo;
                        getDataUpdate.RoomNo = RoomNo;
                        getDataUpdate.BuildingNo = BuildingNo;
                        getDataUpdate.RegisterNumber = RegisterNumber;
                        getDataUpdate.FloorNoCondo = FloorNoCondo;
                        getDataUpdate.PositionLatitude = PositionLatitude;
                        getDataUpdate.PositionLongtitude = PositionLongtitude;
                        getDataUpdate.chkconstruction = chkconstruction;
                    }
                    else
                    {
                        return Ok(EnumMessage.StatusMessage.Error.NotFoundUpdate);
                    }
                    _context.Update(getDataUpdate);
                    await _context.SaveChangesAsync();
                    return Ok(EnumMessage.StatusMessage.Success.DataSaveChange);
                }
                
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SamplingUFTDetailExists(RSubAppraisalID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostSamplingUFTDetail([FromBody] SamplingUFTDetail samplingUFTDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _context.SamplingUFTDetail.Add(samplingUFTDetail);
                await _context.SaveChangesAsync();

                return Ok(EnumMessage.StatusMessage.Success.DataSaved);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/SamplingUFTDetails/5
        [HttpDelete("{RSubAppraisalID}")]
        public async Task<IActionResult> DeleteSamplingUFTDetail([FromRoute] long RSubAppraisalID)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var samplingUFTDetail = await _context.SamplingUFTDetail.FindAsync(RSubAppraisalID);
            if (samplingUFTDetail == null)
            {
                return NotFound();
            }

            _context.SamplingUFTDetail.Remove(samplingUFTDetail);
            await _context.SaveChangesAsync();

            return Ok(EnumMessage.StatusMessage.Success.DataIsDeleted);
        }

        private bool SamplingUFTDetailExists(long id)
        {
            return _context.SamplingUFTDetail.Any(e => e.RSubAppraisalID == id);
        }
    }
}