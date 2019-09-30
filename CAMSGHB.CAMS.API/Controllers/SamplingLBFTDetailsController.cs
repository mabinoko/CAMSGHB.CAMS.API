﻿using System;
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
    public class SamplingLBFTDetailsController : ControllerBase
    {
        private readonly DBCams3context _context;

        public SamplingLBFTDetailsController(DBCams3context context)
        {
            _context = context;
        }

        // GET: api/SamplingLBFTDetails/5
        [HttpGet]
        public async Task<IActionResult> GetSamplingLBFTDetail([FromQuery]SamplingLBFTDetail data)
        {
            try 
            {
                IQueryable<SamplingLBFTDetail> iQueryData;
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                iQueryData = _context.SamplingLBFTDetail;

                if (data.RSubAppraisalID != 0)
                {
                    iQueryData = _context.SamplingLBFTDetail.Where(x => x.RSubAppraisalID == data.RSubAppraisalID).AsQueryable();
                }
                if (data.RAppraisalID != 0)
                {
                    iQueryData = _context.SamplingLBFTDetail.Where(x => x.RAppraisalID == data.RAppraisalID).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.CIFName))
                {
                    iQueryData = _context.SamplingLBFTDetail.Where(x => x.CIFName == data.CIFName).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.AANo)) 
                {
                    iQueryData = _context.SamplingLBFTDetail.Where(x => x.AANo == data.AANo).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.ConstDeedNo))
                {
                    iQueryData = _context.SamplingLBFTDetail.Where(x => x.ConstDeedNo == data.ConstDeedNo).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.Houseno))
                {
                    iQueryData = _context.SamplingLBFTDetail.Where(x => x.Houseno == data.Houseno).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.BuildingModel))
                {
                    iQueryData = _context.SamplingLBFTDetail.Where(x => x.BuildingModel == data.BuildingModel).AsQueryable();
                }
                if (data.NoOfFloor != null)
                {
                    iQueryData = _context.SamplingLBFTDetail.Where(x => x.NoOfFloor == data.NoOfFloor).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.PositionLatitude))
                {
                    iQueryData = _context.SamplingLBFTDetail.Where(x => x.PositionLatitude == data.PositionLatitude).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.PositionLongtitude))
                {
                    iQueryData = _context.SamplingLBFTDetail.Where(x => x.PositionLongtitude == data.PositionLongtitude).AsQueryable();
                }
                if (data.chkconstruction != null)
                {
                    iQueryData = _context.SamplingLBFTDetail.Where(x => x.chkconstruction == data.chkconstruction).AsQueryable();
                }
               
                return Ok(iQueryData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{RSubAppraisalID}")]
        public async Task<IActionResult> PutSamplingLBFTDetail([FromRoute] long RSubAppraisalID, [FromQuery] long RAppraisalID,[FromQuery] string CIFName,[FromQuery] string AANo,[FromQuery]string ConstDeedNo,
            [FromQuery]string Houseno, [FromQuery]string BuildingModel, [FromQuery]decimal? NoOfFloor, [FromQuery]string PositionLatitude, [FromQuery]string PositionLongtitude, [FromQuery]bool chkconstruction)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                using (var context = new DBCams3context()) 
                {
                    var getDataUpdate = (from updateData in context.SamplingLBFTDetail
                                         where updateData.RSubAppraisalID == RSubAppraisalID
                                         select updateData).FirstOrDefault();
                    if (getDataUpdate != null)
                    {
                        getDataUpdate.RAppraisalID = RAppraisalID;
                        getDataUpdate.CIFName = CIFName;
                        getDataUpdate.AANo = AANo;
                        getDataUpdate.ConstDeedNo = ConstDeedNo;
                        getDataUpdate.Houseno = Houseno;
                        getDataUpdate.BuildingModel = BuildingModel;
                        getDataUpdate.NoOfFloor = NoOfFloor.GetValueOrDefault();
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
                if (!SamplingLBFTDetailExists(RSubAppraisalID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        // POST: api/SamplingLBFTDetails
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> PostSamplingLBFTDetail([FromForm] SamplingLBFTDetail samplingLBFTDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _context.SamplingLBFTDetail.Add(samplingLBFTDetail);
                await _context.SaveChangesAsync();

                return Ok(EnumMessage.StatusMessage.Success.DataSaved);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{RSubAppraisalID}")]
        public async Task<IActionResult> DeleteSamplingLBFTDetail([FromRoute] long RSubAppraisalID)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var samplingLBFTDetail = await _context.SamplingLBFTDetail.FindAsync(RSubAppraisalID);
            if (samplingLBFTDetail == null)
            {
                return NotFound();
            }

            _context.SamplingLBFTDetail.Remove(samplingLBFTDetail);
            await _context.SaveChangesAsync();

            return Ok(EnumMessage.StatusMessage.Success.DataIsDeleted);
        }

        private bool SamplingLBFTDetailExists(long id)
        {
            return _context.SamplingLBFTDetail.Any(e => e.RSubAppraisalID == id);
        }
    }
}