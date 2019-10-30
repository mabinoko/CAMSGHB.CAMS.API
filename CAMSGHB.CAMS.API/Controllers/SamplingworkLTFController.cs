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
using System.Data.SqlClient;

namespace CAMSGHB.CAMS.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyCORSPolicy")]
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
            decimal totalCount = 0;
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

                if (data.MonthCheck != null)
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.MonthCheck == data.MonthCheck).AsQueryable();
                }

                if (data.StratDateSurvey != null && data.EndDateSurvey != null)//
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.LastDateSurvey >= data.StratDateSurvey && x.LastDateSurvey <= data.EndDateSurvey).AsQueryable();
                }

                if (data.StratBankDateCheck != null && data.EndBankDateCheck != null)//
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.LastDateSurvey >= data.StratBankDateCheck && x.LastDateSurvey <= data.EndBankDateCheck).AsQueryable();
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

                if (!string.IsNullOrEmpty(data.Buildingplan))
                {
                    iQueryData = _context.SamplingworkLTF.Where(x => x.Buildingplan == data.Buildingplan).AsQueryable();
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
                if (data.percent > 0)
                {
                    totalCount = (decimal)((iQueryData.ToList().Count() * data.percent) / 100.00);
                    var queryRow = (int)Math.Ceiling(totalCount);
                    return Ok(iQueryData.ToList().Take(queryRow));
                }

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

            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }


                var updateData = _context.SamplingworkLTF.Where(x => x.RAppraisalID == samplingworkLTF.RAppraisalID).FirstOrDefault();
                if (updateData == null)
                {
                    return NotFound(EnumMessage.StatusMessage.Error.NotFoundUpdate);
                }
                else
                {
                    updateData.RJobType = samplingworkLTF.RJobType;
                    updateData.ProjectName = samplingworkLTF.ProjectName;
                    updateData.ProjectCode = samplingworkLTF.ProjectCode;
                    updateData.CIFName = samplingworkLTF.CIFName;
                    updateData.AANo = samplingworkLTF.AANo;
                    updateData.APNO = samplingworkLTF.APNO;
                    updateData.ConstDeedNo = samplingworkLTF.ConstDeedNo;
                    updateData.LandNo = samplingworkLTF.LandNo;
                    updateData.SubCategory = samplingworkLTF.SubCategory;
                    updateData.SplitEntry = samplingworkLTF.SplitEntry;
                    updateData.Street = samplingworkLTF.Street;
                    updateData.SubDistrict = samplingworkLTF.SubDistrict;
                    updateData.District = samplingworkLTF.District;
                    updateData.Province = samplingworkLTF.Province;
                    updateData.AssessCompany = samplingworkLTF.AssessCompany;
                    updateData.MonthCheck = samplingworkLTF.MonthCheck;
                    updateData.LastDateSurvey = samplingworkLTF.LastDateSurvey;
                    updateData.BankDateCheck = samplingworkLTF.BankDateCheck;
                    updateData.checkdevland = samplingworkLTF.checkdevland;
                    updateData.chkpublicutility = samplingworkLTF.chkpublicutility;
                    updateData.chkconstruction = samplingworkLTF.chkconstruction;
                    updateData.chkfacility = samplingworkLTF.chkfacility;
                    updateData.chklandlocation = samplingworkLTF.chklandlocation;
                    updateData.surveybanklist = samplingworkLTF.surveybanklist;
                    updateData.appraisalbanklist = samplingworkLTF.appraisalbanklist;
                    updateData.Ownerbanklist = samplingworkLTF.Ownerbanklist;
                    updateData.Otherdetail = samplingworkLTF.Otherdetail;
                    updateData.Remark = samplingworkLTF.Remark;
                    updateData.Buildingplan = samplingworkLTF.Buildingplan;
                    updateData.Other = samplingworkLTF.Other;
                    updateData.Appraisalchk = samplingworkLTF.Appraisalchk;
                    updateData.CommentDetail = samplingworkLTF.CommentDetail;
                    updateData.AppraisalBankid = samplingworkLTF.AppraisalBankid;
                    updateData.AppraisalDate = samplingworkLTF.AppraisalDate;
                    updateData.chkmistake = samplingworkLTF.chkmistake;
                    updateData.mistakedetail = samplingworkLTF.mistakedetail;
                    updateData.warningletter = samplingworkLTF.warningletter;
                    updateData.warningdetail = samplingworkLTF.warningdetail;
                    updateData.Headteam = samplingworkLTF.Headteam;
                    updateData.datecheck = samplingworkLTF.datecheck;
                    updateData.AssistantAppDirector = samplingworkLTF.AssistantAppDirector;
                    updateData.AssistDate = samplingworkLTF.AssistDate;
                    updateData.AppDirector = samplingworkLTF.AppDirector;
                    updateData.AppDireDate = samplingworkLTF.AppDireDate;
                    updateData.reportdetail = samplingworkLTF.reportdetail;
                    _context.Update(updateData);
                    await _context.SaveChangesAsync();
                    return Ok(EnumMessage.StatusMessage.Success.DataSaveChange);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // POST: api/SamplingworkLTF
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> PostSamplingworkLTF([FromForm] SamplingworkLTFPOstModel samplingworkLTF)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                #region :: Mapper ::
                var getModelToDbModel = new SamplingworkLTF()
                {
                    AppraisalID = samplingworkLTF.AppraisalID,
                    RJobType = samplingworkLTF.RJobType,
                    ProjectName = samplingworkLTF.ProjectName,
                    ProjectCode = samplingworkLTF.ProjectCode,
                    CIFName = samplingworkLTF.CIFName,
                    AANo = samplingworkLTF.AANo,
                    APNO = samplingworkLTF.APNO,
                    ConstDeedNo = samplingworkLTF.ConstDeedNo,
                    LandNo = samplingworkLTF.LandNo,
                    SubCategory = samplingworkLTF.SubCategory,
                    SplitEntry = samplingworkLTF.SplitEntry,
                    Street = samplingworkLTF.Street,
                    SubDistrict = samplingworkLTF.SubDistrict,
                    District = samplingworkLTF.District,
                    Province = samplingworkLTF.Province,
                    AssessCompany = samplingworkLTF.AssessCompany,
                    MonthCheck = samplingworkLTF.MonthCheck,
                    LastDateSurvey = samplingworkLTF.LastDateSurvey,
                    BankDateCheck = samplingworkLTF.BankDateCheck,
                    checkdevland = samplingworkLTF.checkdevland,
                    chkpublicutility = samplingworkLTF.chkpublicutility,
                    chkconstruction = samplingworkLTF.chkconstruction,
                    chkfacility = samplingworkLTF.chkfacility,
                    chklandlocation = samplingworkLTF.chklandlocation,
                    surveybanklist = samplingworkLTF.surveybanklist,
                    appraisalbanklist = samplingworkLTF.appraisalbanklist,
                    Ownerbanklist = samplingworkLTF.Ownerbanklist,
                    Otherdetail = samplingworkLTF.Otherdetail,
                    Remark = samplingworkLTF.Remark,
                    Buildingplan = samplingworkLTF.Buildingplan,
                    Other = samplingworkLTF.Other,
                    Appraisalchk = samplingworkLTF.Appraisalchk,
                    CommentDetail = samplingworkLTF.CommentDetail,
                    AppraisalBankid = samplingworkLTF.AppraisalBankid,
                    AppraisalDate = samplingworkLTF.AppraisalDate,
                    chkmistake = samplingworkLTF.chkmistake,
                    mistakedetail = samplingworkLTF.mistakedetail,
                    warningletter = samplingworkLTF.warningletter,
                    warningdetail = samplingworkLTF.warningdetail,
                    Headteam = samplingworkLTF.Headteam,
                    datecheck = samplingworkLTF.datecheck,
                    AssistantAppDirector = samplingworkLTF.AssistantAppDirector,
                    AssistDate = samplingworkLTF.AssistDate,
                    AppDirector = samplingworkLTF.AppDirector,
                    AppDireDate = samplingworkLTF.AppDireDate,
                    reportdetail = samplingworkLTF.reportdetail,
                };
                #endregion

                #region :: genPK ::
                using (SqlConnection sqlConnection = new SqlConnection(EnumMessage.connectionString.connect))
                {
                    sqlConnection.Open();
                    SqlCommand sql = new SqlCommand(" SELECT NEXT VALUE FOR  dbo.RAppraisalInfo_SEQ", sqlConnection);

                    using (SqlDataReader reader = sql.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getModelToDbModel.RAppraisalID = reader.GetInt64(0);
                        }
                    }
                    sqlConnection.Close();
                }
                #endregion

                _context.SamplingworkLTF.Add(getModelToDbModel);
                await _context.SaveChangesAsync();
                return Ok(EnumMessage.StatusMessage.Success.DataSaveChange);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message); ;
            }
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