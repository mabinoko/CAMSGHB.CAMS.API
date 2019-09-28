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
    public class SamplingworkLTFController : ControllerBase
    {
        private readonly DBCams3context _context;

        public SamplingworkLTFController(DBCams3context context)
        {
            _context = context;
        }

        // GET: api/SamplingworkLTF/5
        [HttpGet]
        public async Task<IActionResult> GetSamplingworkLTF([FromQuery] SamplingworkLTFGetModel data)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                IQueryable<SamplingworkLTF> iQueryData;

                #region :: Query ::
                iQueryData = _context.SamplingworkLTF;

                if (data.RAppraisalID != 0)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.RAppraisalID == data.RAppraisalID).AsQueryable();
                }

                if (data.AppraisalID != 0)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.AppraisalID == data.AppraisalID).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.ProjectName))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.ProjectName == data.ProjectName).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.ProjectCode))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.ProjectCode == data.ProjectCode).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.CIFName))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.CIFName == data.CIFName).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AANo))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.AANo == data.AANo).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.APNO))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.APNO == data.APNO).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.ConstDeedNo))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.ConstDeedNo == data.ConstDeedNo).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.LandNo))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.LandNo == data.LandNo).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.SubCategory))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.SubCategory == data.SubCategory).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.SplitEntry))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.SplitEntry == data.SplitEntry).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Street))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.Street == data.Street).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.SubDistrict))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.SubDistrict == data.SubDistrict).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.District))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.District == data.District).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Province))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.Province == data.Province).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AssessCompany))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.AssessCompany == data.AssessCompany).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AssessCompany))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.AssessCompany == data.AssessCompany).AsQueryable();
                }

                if (data.MonthCheck != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.MonthCheck == data.MonthCheck).AsQueryable();
                }

                if (data.LastDateSurvey != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.LastDateSurvey == data.LastDateSurvey).AsQueryable();
                }

                if (data.BankDateCheck != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.BankDateCheck == data.BankDateCheck).AsQueryable();
                }

                if (data.checkdevland != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.checkdevland == data.checkdevland).AsQueryable();
                }

                if (data.chkpublicutility != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.chkpublicutility == data.chkpublicutility).AsQueryable();
                }

                if (data.chkconstruction != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.chkconstruction == data.chkconstruction).AsQueryable();
                }

                if (data.chkfacility != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.chkfacility == data.chkfacility).AsQueryable();
                }

                if (data.chklandlocation != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.chklandlocation == data.chklandlocation).AsQueryable();
                }

                if (data.surveybanklist != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.surveybanklist == data.surveybanklist).AsQueryable();
                }

                if (data.appraisalbanklist != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.appraisalbanklist == data.appraisalbanklist).AsQueryable();
                }

                if (data.Ownerbanklist != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.Ownerbanklist == data.Ownerbanklist).AsQueryable();
                }

                if (data.Otherdetail != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.Otherdetail == data.Otherdetail).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Remark))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.Remark == data.Remark).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Remark))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.Remark == data.Remark).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Buildingplan))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.Buildingplan == data.Buildingplan).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Other))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.Other == data.Other).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Other))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.Other == data.Other).AsQueryable();
                }

                if (data.Appraisalchk != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.Appraisalchk == data.Appraisalchk).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.CommentDetail))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.CommentDetail == data.CommentDetail).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AppraisalBankid))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.AppraisalBankid == data.AppraisalBankid).AsQueryable();
                }

                if (data.AppraisalDate != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.AppraisalDate == data.AppraisalDate).AsQueryable();
                }

                if (data.chkmistake != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.chkmistake == data.chkmistake).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.mistakedetail))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.mistakedetail == data.mistakedetail).AsQueryable();
                }

                if (data.warningletter != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.warningletter == data.warningletter).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.warningdetail))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.warningdetail == data.warningdetail).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Headteam))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.Headteam == data.Headteam).AsQueryable();
                }

                if (data.datecheck != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.datecheck == data.datecheck).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AssistantAppDirector))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.AssistantAppDirector == data.AssistantAppDirector).AsQueryable();
                }

                if (data.AssistDate != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.AssistDate == data.AssistDate).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AppDirector))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.AppDirector == data.AppDirector).AsQueryable();
                }

                if (data.AppDireDate != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.AppDireDate == data.AppDireDate).AsQueryable();
                }
                #endregion

                return Ok(iQueryData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/SamplingworkLTF/5
        [HttpPut]
        public async Task<IActionResult> PutSamplingworkLTF([FromQuery] SamplingworkLTF samplingworkLTF)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var RAppraisalID = samplingworkLTF.RAppraisalID;
            if (RAppraisalID != samplingworkLTF.RAppraisalID)
            {
                return BadRequest();
            }

            _context.Entry(samplingworkLTF).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SamplingworkLTFExists(RAppraisalID))
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

        // POST: api/SamplingworkLTF
        [HttpPost]
        public async Task<IActionResult> PostSamplingworkLTF([FromQuery] SamplingworkLTFGetModel samplingworkLTF)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SamplingworkLTF.Add(samplingworkLTF);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSamplingworkLTF", new { id = samplingworkLTF.RAppraisalID }, samplingworkLTF);
        }

        // DELETE: api/SamplingworkLTF/5
        [HttpDelete("{RAppraisalID}")]
        public async Task<IActionResult> DeleteSamplingworkLTF([FromRoute] long RAppraisalID)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var samplingworkLTF = await _context.SamplingworkLTF.FindAsync(RAppraisalID);
            if (samplingworkLTF == null)
            {
                return NotFound();
            }

            _context.SamplingworkLTF.Remove(samplingworkLTF);
            await _context.SaveChangesAsync();

            return Ok(samplingworkLTF);
        }

        private bool SamplingworkLTFExists(long id)
        {
            return _context.SamplingworkLTF.Any(e => e.RAppraisalID == id);
        }
    }
}