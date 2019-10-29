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
            decimal totalCount;
            int SearchByPercent = 0;
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                IQueryable<SamplingworkLTF> iQueryData;
                List<SamplingworkLTF> getData = new List<SamplingworkLTF>();

                var getdata = (from getView in _context.SamplingworkLTF
                               where ((data.RAppraisalID == 0) || (getView.RAppraisalID == data.RAppraisalID)) 
                               && ((data.AppraisalID == 0) || (getView.AppraisalID == data.AppraisalID))
                               && (string.IsNullOrEmpty(data.ProjectName) || (getView.ProjectName.Trim() == data.ProjectName.Trim()))
                               && (string.IsNullOrEmpty(data.ProjectCode) || (getView.ProjectCode.Trim() == data.ProjectCode.Trim())) 
                               && (string.IsNullOrEmpty(data.CIFName) || (getView.CIFName.Trim() == data.CIFName.Trim()))
                               && (string.IsNullOrEmpty(data.APNO) || (getView.APNO.Trim() == data.APNO.Trim()))
                               && (string.IsNullOrEmpty(data.ConstDeedNo) || (getView.ConstDeedNo.Trim() == data.ConstDeedNo.Trim()))
                               && (string.IsNullOrEmpty(data.LandNo) || (getView.LandNo.Trim() == data.LandNo.Trim()))
                               && (string.IsNullOrEmpty(data.SubCategory) || (getView.SubCategory.Trim() == data.SubCategory.Trim()))
                               && (string.IsNullOrEmpty(data.SplitEntry) || (getView.SplitEntry.Trim() == data.SplitEntry.Trim()))
                               && (string.IsNullOrEmpty(data.Street) || (getView.Street.Trim() == data.Street.Trim()))
                               && (string.IsNullOrEmpty(data.SubDistrict) || (getView.SubDistrict.Trim() == data.SubDistrict.Trim()))
                               && (string.IsNullOrEmpty(data.District) || (getView.District.Trim() == data.District.Trim()))
                               && (string.IsNullOrEmpty(data.Province) || (getView.Province.Trim() == data.Province.Trim()))
                               && (string.IsNullOrEmpty(data.AssessCompany) || (getView.AssessCompany.Trim() == data.AssessCompany.Trim()))
                               && ((data.MonthCheck == 0) || (getView.MonthCheck == data.MonthCheck))
                               && ((data.StratDateSurvey != null && data.EndDateSurvey != null) || (getView.LastDateSurvey >= data.StratDateSurvey && getView.LastDateSurvey <= data.EndDateSurvey))
                               && ((data.StratBankDateCheck != null && data.EndBankDateCheck != null) || (getView.BankDateCheck >= data.StratBankDateCheck && getView.BankDateCheck <= data.EndBankDateCheck))
                               && ((data.checkdevland != null) || (getView.checkdevland == data.checkdevland))
                               && ((data.chkpublicutility != null) || (getView.chkpublicutility == data.chkpublicutility))
                               && ((data.chkconstruction != null) || (getView.chkconstruction == data.chkconstruction))
                               && ((data.chkfacility != null) || (getView.chkfacility == data.chkfacility))
                               && ((data.chklandlocation != null) || (getView.chklandlocation == data.chklandlocation))
                               && ((data.surveybanklist != null) || (getView.surveybanklist == data.surveybanklist))
                               && ((data.appraisalbanklist != null) || (getView.appraisalbanklist == data.appraisalbanklist))
                               && ((data.Ownerbanklist != null) || (getView.Ownerbanklist == data.Ownerbanklist))
                               && ((data.Otherdetail != null) || (getView.Otherdetail == data.Otherdetail))
                               && (string.IsNullOrEmpty(data.Remark) || (getView.Remark.Trim() == data.Remark.Trim()))
                               && (string.IsNullOrEmpty(data.Buildingplan) || (getView.Buildingplan.Trim() == data.Buildingplan.Trim()))
                               && (string.IsNullOrEmpty(data.Other) || (getView.Other.Trim() == data.Other.Trim()))
                               && ((data.Appraisalchk != null) || (getView.Appraisalchk == data.Appraisalchk))
                               && (string.IsNullOrEmpty(data.CommentDetail) || (getView.CommentDetail.Trim() == data.CommentDetail.Trim()))
                               && (string.IsNullOrEmpty(data.AppraisalBankid) || (getView.AppraisalBankid.Trim() == data.AppraisalBankid.Trim()))
                               && ((data.AppraisalDate != null) || (getView.AppraisalDate == data.AppraisalDate))
                               && ((data.chkmistake != null) || (getView.chkmistake == data.chkmistake))
                               && (string.IsNullOrEmpty(data.mistakedetail) || (getView.mistakedetail.Trim() == data.mistakedetail.Trim()))
                               && ((data.warningletter != null) || (getView.warningletter == data.warningletter))
                               && (string.IsNullOrEmpty(data.warningdetail) || (getView.warningdetail.Trim() == data.warningdetail.Trim()))
                               && (string.IsNullOrEmpty(data.Headteam) || (getView.Headteam.Trim() == data.Headteam.Trim()))
                               && ((data.datecheck != null) || (getView.datecheck == data.datecheck))
                               && (string.IsNullOrEmpty(data.AssistantAppDirector) || (getView.AssistantAppDirector.Trim() == data.AssistantAppDirector.Trim()))
                               && ((data.AssistDate != null) || (getView.AssistDate == data.AssistDate))
                               && (string.IsNullOrEmpty(data.AppDirector) || (getView.AppDirector.Trim() == data.AppDirector.Trim()))
                               && ((data.AppDireDate != null) || (getView.AppDireDate == data.AppDireDate))
                               select getView
                               ).ToList();

                if (data.percent > 0)
                {
                    totalCount = (decimal)((getData.Count() * data.percent) / 100.00);
                    SearchByPercent = (int)Math.Ceiling(totalCount);
                    iQueryData = getData.Take(SearchByPercent).AsQueryable();
                }
                else
                {
                    iQueryData = getdata.AsQueryable();
                }

                return Ok(iQueryData.ToList());

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