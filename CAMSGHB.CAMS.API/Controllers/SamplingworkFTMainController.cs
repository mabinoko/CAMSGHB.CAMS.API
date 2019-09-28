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
    public class SamplingworkFTMainController : ControllerBase
    {
        private readonly DBCams3context _context;

        public SamplingworkFTMainController(DBCams3context context)
        {
            _context = context;
        }

        // GET: api/SamplingworkFTMain/5
        [HttpGet]
        public async Task<IActionResult> GetSamplingworkFTMain([FromBody] SamplingworkFTMainGetModel data)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                IQueryable<SamplingworkFTMain> iQueryData;
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                #region :: Query ::
                iQueryData = _context.SamplingworkFTMain;

                if (data.RAppraisalID != 0)
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.RAppraisalID == data.RAppraisalID).AsQueryable();
                }

                if (data.AppraisalID != 0)
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.AppraisalID == data.AppraisalID).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.ProjectName))
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.ProjectName == data.ProjectName).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.ProjectCode))
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.ProjectCode == data.ProjectCode).AsQueryable();
                }

                if (data.MonthCheck != 0)
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.MonthCheck == data.MonthCheck).AsQueryable();
                }

                if (data.YearCheck != 0)
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.MonthCheck == data.MonthCheck).AsQueryable();
                }

                if (data.BankDateCheck != null)
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.BankDateCheck == data.BankDateCheck).AsQueryable();
                }

                if (data.RJobType != 0)
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.RJobType == data.RJobType).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.SubCategory))
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.SubCategory == data.SubCategory).AsQueryable();
                }

                if (data.Landplot != null)
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.Landplot == data.Landplot).AsQueryable();
                }

                if (data.RoomPlan != null)
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.RoomPlan == data.RoomPlan).AsQueryable();
                }

                if (data.ProjPlan != null)
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.ProjPlan == data.ProjPlan).AsQueryable();
                }

                if (data.House_Roomno != null)
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.House_Roomno == data.House_Roomno).AsQueryable();
                }

                if (data.Pictures != null)
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.Pictures == data.Pictures).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.OtherDocument))
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.OtherDocument == data.OtherDocument).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AppraisalBankid))
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.AppraisalBankid == data.AppraisalBankid).AsQueryable();
                }

                if (data.AppraisalDate != null)
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.AppraisalDate == data.AppraisalDate).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.ChkReportBankid))
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.ChkReportBankid == data.ChkReportBankid).AsQueryable();
                }

                if (data.AppraisalBankid != null)
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.ChkReportdate == data.ChkReportdate).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AssistantAppDirector))
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.AssistantAppDirector == data.AssistantAppDirector).AsQueryable();
                }

                if (data.AssistDate != null)
                {
                    iQueryData = _context.SamplingworkFTMain.Where(x => x.AssistDate == data.AssistDate).AsQueryable();
                }
                #endregion

                return Ok(iQueryData);

                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/SamplingworkFTMain/5
        [HttpPut]
        public async Task<IActionResult> PutSamplingworkFTMain([FromQuery] SamplingworkFTMain samplingworkFTMain)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var RAppraisalID = samplingworkFTMain.RAppraisalID;
            if (RAppraisalID != samplingworkFTMain.RAppraisalID)
            {
                return BadRequest();
            }

            _context.Entry(samplingworkFTMain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SamplingworkFTMainExists(RAppraisalID))
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

        // POST: api/SamplingworkFTMain
        [HttpPost]
        public async Task<IActionResult> PostSamplingworkFTMain([FromBody] SamplingworkFTMain samplingworkFTMain)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _context.SamplingworkFTMain.Add(samplingworkFTMain);
                await _context.SaveChangesAsync();

                return Ok(EnumMessage.StatusMessage.Success.DataSaved);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        // DELETE: api/SamplingworkFTMain/5
        [HttpDelete("{RAppraisalID}")]
        public async Task<IActionResult> DeleteSamplingworkFTMain([FromRoute] long RAppraisalID)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var samplingworkFTMain = await _context.SamplingworkFTMain.FindAsync(RAppraisalID);
            if (samplingworkFTMain == null)
            {
                return NotFound();
            }

            _context.SamplingworkFTMain.Remove(samplingworkFTMain);
            await _context.SaveChangesAsync();

            return Ok(samplingworkFTMain);
        }

        private bool SamplingworkFTMainExists(long id)
        {
            return _context.SamplingworkFTMain.Any(e => e.RAppraisalID == id);
        }
    }
}