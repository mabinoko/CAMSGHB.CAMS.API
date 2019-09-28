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
    public class SamplingworkBZPController : ControllerBase
    {
        private readonly DBCams3context _context;

        public SamplingworkBZPController(DBCams3context context)
        {
            _context = context;
        }

        // GET: api/SamplingworkBZP
       

        // GET: api/SamplingworkBZP/5
        [HttpGet]
        public async Task<IActionResult> GetSamplingworkBZP([FromQuery] SamplingworkBZPGetModel data)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                IQueryable<SamplingworkBZP> iQueryData;

                #region :: Query ::
                iQueryData = _context.SamplingworkBZP;

                if (data.RAppraisalID != 0)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.RAppraisalID == data.RAppraisalID).AsQueryable();
                }

                if (data.AppraisalID != 0)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.AppraisalID == data.AppraisalID).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.ProjectName))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.ProjectName == data.ProjectName).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.ProjectCode))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.ProjectCode == data.ProjectCode).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.CIFName))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.CIFName == data.CIFName).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AANo))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.AANo == data.AANo).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.APNO))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.APNO == data.APNO).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.ConstDeedNo))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.ConstDeedNo == data.ConstDeedNo).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.LandNo))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.LandNo == data.LandNo).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.SubCategory))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.SubCategory == data.SubCategory).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.SplitEntry))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.SplitEntry == data.SplitEntry).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Street))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.Street == data.Street).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.SubDistrict))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.SubDistrict == data.SubDistrict).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.District))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.District == data.District).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Province))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.Province == data.Province).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AssessCompany))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.AssessCompany == data.AssessCompany).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AssessCompany))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.AssessCompany == data.AssessCompany).AsQueryable();
                }

                if (data.MonthCheck != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.MonthCheck == data.MonthCheck).AsQueryable();
                }

                if (data.LastDateSurvey != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.LastDateSurvey == data.LastDateSurvey).AsQueryable();
                }

                if (data.BankDateCheck != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.BankDateCheck == data.BankDateCheck).AsQueryable();
                }

                if (data.checkdevland != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.checkdevland == data.checkdevland).AsQueryable();
                }

                if (data.chkpublicutility != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.chkpublicutility == data.chkpublicutility).AsQueryable();
                }

                if (data.chkconstruction != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.chkconstruction == data.chkconstruction).AsQueryable();
                }

                if (data.chkfacility != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.chkfacility == data.chkfacility).AsQueryable();
                }

                if (data.chklandlocation != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.chklandlocation == data.chklandlocation).AsQueryable();
                }

                if (data.surveybanklist != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.surveybanklist == data.surveybanklist).AsQueryable();
                }

                if (data.appraisalbanklist != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.appraisalbanklist == data.appraisalbanklist).AsQueryable();
                }

                if (data.Ownerbanklist != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.Ownerbanklist == data.Ownerbanklist).AsQueryable();
                }

                if (data.Otherdetail != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.Otherdetail == data.Otherdetail).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Remark))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.Remark == data.Remark).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Remark))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.Remark == data.Remark).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Buildingplan))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.Buildingplan == data.Buildingplan).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Other))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.Other == data.Other).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Other))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.Other == data.Other).AsQueryable();
                }

                if (data.Appraisalchk != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.Appraisalchk == data.Appraisalchk).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.CommentDetail))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.CommentDetail == data.CommentDetail).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AppraisalBankid))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.AppraisalBankid == data.AppraisalBankid).AsQueryable();
                }

                if (data.AppraisalDate != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.AppraisalDate == data.AppraisalDate).AsQueryable();
                }

                if (data.chkmistake != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.chkmistake == data.chkmistake).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.mistakedetail))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.mistakedetail == data.mistakedetail).AsQueryable();
                }

                if (data.warningletter != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.warningletter == data.warningletter).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.warningdetail))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.warningdetail == data.warningdetail).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Headteam))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.Headteam == data.Headteam).AsQueryable();
                }

                if (data.datecheck != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.datecheck == data.datecheck).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AssistantAppDirector))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.AssistantAppDirector == data.AssistantAppDirector).AsQueryable();
                }

                if (data.AssistDate != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.AssistDate == data.AssistDate).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AppDirector))
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.AppDirector == data.AppDirector).AsQueryable();
                }

                if (data.AppDireDate != null)
                {
                    iQueryData = _context.SamplingworkBZP.Where(x => x.AppDireDate == data.AppDireDate).AsQueryable();
                }
                #endregion

                return Ok(iQueryData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/SamplingworkBZP/5
        [HttpPut]
        public async Task<IActionResult> PutSamplingworkBZP([FromQuery] SamplingworkBZP samplingworkBZP)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (RAppraisalID != samplingworkBZP.RAppraisalID)
            {
                return BadRequest();
            }

            _context.Entry(samplingworkBZP).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SamplingworkBZPExists(RAppraisalID))
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

        // POST: api/SamplingworkBZP
        [HttpPost]
        public async Task<IActionResult> PostSamplingworkBZP([FromQuery] SamplingworkBZPGetModel samplingworkBZP)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var convertSamplingworkBZP = (SamplingworkBZP)samplingworkBZP;

                _context.SamplingworkBZP.Add(samplingworkBZP);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetSamplingworkBZP", new { id = samplingworkBZP.RAppraisalID }, samplingworkBZP);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
           
        }

        // DELETE: api/SamplingworkBZP/5
        [HttpDelete("{RAppraisalID}")]
        public async Task<IActionResult> DeleteSamplingworkBZP([FromRoute] long RAppraisalID)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var samplingworkBZP = await _context.SamplingworkBZP.FindAsync(RAppraisalID);
            if (samplingworkBZP == null)
            {
                return NotFound();
            }

            _context.SamplingworkBZP.Remove(samplingworkBZP);
            await _context.SaveChangesAsync();

            return Ok(samplingworkBZP);
        }

        private bool SamplingworkBZPExists(long id)
        {
            return _context.SamplingworkBZP.Any(e => e.RAppraisalID == id);
        }
    }
}