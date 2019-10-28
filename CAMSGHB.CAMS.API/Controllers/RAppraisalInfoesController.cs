using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CAMSGHB.CAMS.API.Models;
using Microsoft.AspNetCore.Cors;
using CAMSGHB.CAMS.API.Enum;
using System.Data.SqlClient;

namespace CAMSGHB.CAMS.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyCORSPolicy")]
    [ApiController]
    public class RAppraisalInfoesController : ControllerBase
    {
        private readonly DBCams3context _context;

        public RAppraisalInfoesController(DBCams3context context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetRAppraisalInfo([FromQuery]RAppraisalInfoGetModel data)
        {
            decimal totalCount = 0;
            try
            {
                IQueryable<RAppraisalInfo> iQueryData;
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                
                #region :: Query ::
                iQueryData = _context.RAppraisalInfo;
                if (data.RAppraisalID != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.RAppraisalID == data.RAppraisalID).AsQueryable();
                }
                if (data.AppraisalID != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.AppraisalID == data.AppraisalID).AsQueryable();
                }
                if (data.DateCompCheck != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.DateCompCheck == data.DateCompCheck).AsQueryable();
                }
                if (data.BankDateCheck != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.BankDateCheck == data.BankDateCheck).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.CIFName))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.CIFName == data.CIFName).AsQueryable();
                }
                if (data.MonthCheck != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.MonthCheck == data.MonthCheck).AsQueryable();
                }
                if (data.YearCheck != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.YearCheck == data.YearCheck).AsQueryable();
                }
                if (data.YearCheck != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.YearCheck == data.YearCheck).AsQueryable();
                }
                if (data.APPNO != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.APPNO == data.APPNO).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.ProjectName))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.ProjectName == data.ProjectName).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Houseno))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.Houseno == data.Houseno).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Street))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.Street == data.Street).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.SubDistrict))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.SubDistrict == data.SubDistrict).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.District))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.District == data.District).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Province))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.Province == data.Province).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.LandLocationDetail))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.LandLocationDetail == data.LandLocationDetail).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Publicutility))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.Publicutility == data.Publicutility).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Otherdetail))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.Otherdetail == data.Otherdetail).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.DocumentType))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.DocumentType == data.DocumentType).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.DocumentNo))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.DocumentNo == data.DocumentNo).AsQueryable();
                }

                if (data.AreaNgan != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.AreaNgan == data.AreaNgan).AsQueryable();
                }

                if (data.AreaRai != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.AreaRai == data.AreaRai).AsQueryable();
                }

                if (data.AreaWa != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.AreaWa == data.AreaWa).AsQueryable();
                }

                if (data.LCAppraisalUPrice != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.LCAppraisalUPrice == data.LCAppraisalUPrice).AsQueryable();
                }

                if (data.LCAppraisalPrice != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.LCAppraisalPrice == data.LCAppraisalPrice).AsQueryable();
                }

                if (data.LBAppraisalUPrice != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.LBAppraisalUPrice == data.LBAppraisalUPrice).AsQueryable();
                }

                if (data.LBAppraisalPrice != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.LBAppraisalPrice == data.LBAppraisalPrice).AsQueryable();
                }

                if (data.LBPriceSuitable != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.LBPriceSuitable == data.LBPriceSuitable).AsQueryable();
                }

                if (data.LBPriceSuitable != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.LBPriceSuitable == data.LBPriceSuitable).AsQueryable();
                }

                if (data.LDAppraisalPrice != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.LDAppraisalPrice == data.LDAppraisalPrice).AsQueryable();
                }

                if (data.LHigh_lower != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.LHigh_lower == data.LHigh_lower).AsQueryable();
                }

                if (data.LDiffAppraisalPercent != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.LDiffAppraisalPercent == data.LDiffAppraisalPercent).AsQueryable();
                }

                if (data.LAcceptPrice != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.LAcceptPrice == data.LAcceptPrice).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.BuildingModel))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.BuildingModel == data.BuildingModel).AsQueryable();
                }

                if (data.NoOfFloor != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.NoOfFloor == data.NoOfFloor).AsQueryable();
                }

                if (data.DocuementAttach != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.DocuementAttach == data.DocuementAttach).AsQueryable();
                }

                if (data.BCAppraisalPrice != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.BCAppraisalPrice == data.BCAppraisalPrice).AsQueryable();
                }

                if (data.BBAppraisalPrice != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.BBAppraisalPrice == data.BBAppraisalPrice).AsQueryable();
                }

                if (data.BDAppraisalPrice != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.BDAppraisalPrice == data.BDAppraisalPrice).AsQueryable();
                }

                if (data.BHigh_lower != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.BHigh_lower == data.BHigh_lower).AsQueryable();
                }

                if (data.BDiffAppraisalPercent != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.BDiffAppraisalPercent == data.BDiffAppraisalPercent).AsQueryable();
                }

                if (data.BPriceSuitable != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.BPriceSuitable == data.BPriceSuitable).AsQueryable();
                }

                if (data.BAcceptPrice != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.BAcceptPrice == data.BAcceptPrice).AsQueryable();
                }

                if (data.TPriceSuitable != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.TPriceSuitable == data.TPriceSuitable).AsQueryable();
                }

                if (data.TCAppraisalPrice != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.TCAppraisalPrice == data.TCAppraisalPrice).AsQueryable();
                }

                if (data.TBAppraisalPrice != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.TBAppraisalPrice == data.TBAppraisalPrice).AsQueryable();
                }

                if (data.TDAppraisalPrice != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.TDAppraisalPrice == data.TDAppraisalPrice).AsQueryable();
                }

                if (data.THigh_lower != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.THigh_lower == data.THigh_lower).AsQueryable();
                }

                if (data.TDiffAppraisalPercent != 0)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.TDiffAppraisalPercent == data.TDiffAppraisalPercent).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AppraisalSummary))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.AppraisalSummary == data.AppraisalSummary).AsQueryable();
                }

                if (data.AppraisalList != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.AppraisalList == data.AppraisalList).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AppraisalBankid))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.AppraisalBankid == data.AppraisalBankid).AsQueryable();
                }

                if (data.AppraisalDate != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.AppraisalDate == data.AppraisalDate).AsQueryable();
                }

                if (data.chkmistake != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.chkmistake == data.chkmistake).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.mistakedetail))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.mistakedetail == data.mistakedetail).AsQueryable();
                }

                if (data.warningletter != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.warningletter == data.warningletter).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.warningdetail))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.warningdetail == data.warningdetail).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.Headteam))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.Headteam == data.Headteam).AsQueryable();
                }

                if (data.datecheck != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.datecheck == data.datecheck).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AssistantAppDirector))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.AssistantAppDirector == data.AssistantAppDirector).AsQueryable();
                }

                if (data.AssistDate != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.AssistDate == data.AssistDate).AsQueryable();
                }

                if (!string.IsNullOrEmpty(data.AppDirector))
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.AppDirector == data.AppDirector).AsQueryable();
                }

                if (data.AppDireDate != null)
                {
                    iQueryData = _context.RAppraisalInfo.Where(x => x.AppDireDate == data.AppDireDate).AsQueryable();
                }
                #endregion
                
                if(data.percent > 0)
                {
                    
                    totalCount = (decimal)((iQueryData.ToList().Count() * data.percent) / 100.00) ;
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

      
        [HttpPut]
        public async Task<IActionResult> PutRAppraisalInfo([FromQuery] RAppraisalInfo rAppraisalInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var updateData = (from data in _context.RAppraisalInfo
                               where data.RAppraisalID == rAppraisalInfo.RAppraisalID
                               select data).FirstOrDefault();
                if(updateData == null)
                {
                    return BadRequest(EnumMessage.StatusMessage.Error.NotFoundUpdate);
                }
                else
                {
                    updateData.RAppraisalID = rAppraisalInfo.RAppraisalID;
                    updateData.AppraisalID = rAppraisalInfo.AppraisalID ;
                    updateData.DateCompCheck = rAppraisalInfo.DateCompCheck ;
                    updateData.BankDateCheck = rAppraisalInfo.BankDateCheck ;
                    updateData.CIFName = rAppraisalInfo.CIFName ;
                    updateData.MonthCheck = rAppraisalInfo.MonthCheck ;
                    updateData.YearCheck = rAppraisalInfo.YearCheck ;
                    updateData.APPNO = rAppraisalInfo.APPNO ;
                    updateData.ProjectName = rAppraisalInfo.ProjectName ;
                    updateData.Houseno = rAppraisalInfo.Houseno ;
                    updateData.Street = rAppraisalInfo.Street ;
                    updateData.SubDistrict = rAppraisalInfo.SubDistrict ;
                    updateData.District = rAppraisalInfo.District ;
                    updateData.Province = rAppraisalInfo.Province ;
                    updateData.LandLocationDetail = rAppraisalInfo.LandLocationDetail ;
                    updateData.Publicutility = rAppraisalInfo.Publicutility ;
                    updateData.Otherdetail = rAppraisalInfo.Otherdetail ;
                    updateData.DocumentType = rAppraisalInfo.DocumentType ;
                    updateData.DocumentNo = rAppraisalInfo.DocumentNo ;
                    updateData.AreaNgan = rAppraisalInfo.AreaNgan ;
                    updateData.AreaRai = rAppraisalInfo.AreaRai ;
                    updateData.AreaWa = rAppraisalInfo.AreaWa ;
                    updateData.LCAppraisalUPrice = rAppraisalInfo.LCAppraisalUPrice ;
                    updateData.LCAppraisalPrice = rAppraisalInfo.LCAppraisalPrice ;
                    updateData.LBAppraisalUPrice = rAppraisalInfo.LBAppraisalUPrice ;
                    updateData.LBAppraisalPrice = rAppraisalInfo.LBAppraisalPrice ;
                    updateData.LBPriceSuitable = rAppraisalInfo.LBPriceSuitable ;
                    updateData.LDAppraisalPrice = rAppraisalInfo.LDAppraisalPrice ;
                    updateData.LHigh_lower = rAppraisalInfo.LHigh_lower ;
                    updateData.LDiffAppraisalPercent = rAppraisalInfo.LDiffAppraisalPercent ;
                    updateData.LAcceptPrice = rAppraisalInfo.LAcceptPrice ;
                    updateData.BuildingModel = rAppraisalInfo.BuildingModel ;
                    updateData.NoOfFloor = rAppraisalInfo.NoOfFloor ;
                    updateData.DocuementAttach = rAppraisalInfo.DocuementAttach ;
                    updateData.BCAppraisalPrice = rAppraisalInfo.BCAppraisalPrice ;
                    updateData.BBAppraisalPrice = rAppraisalInfo.BBAppraisalPrice ;
                    updateData.BDAppraisalPrice = rAppraisalInfo.BDAppraisalPrice ;
                    updateData.BHigh_lower = rAppraisalInfo.BHigh_lower ;
                    updateData.BDiffAppraisalPercent = rAppraisalInfo.BDiffAppraisalPercent ;
                    updateData.BPriceSuitable = rAppraisalInfo.BPriceSuitable ;
                    updateData.BAcceptPrice = rAppraisalInfo.BAcceptPrice ;
                    updateData.TPriceSuitable = rAppraisalInfo.TPriceSuitable ;
                    updateData.TCAppraisalPrice = rAppraisalInfo.TCAppraisalPrice ;
                    updateData.TBAppraisalPrice = rAppraisalInfo.TBAppraisalPrice ;
                    updateData.TDAppraisalPrice = rAppraisalInfo.TDAppraisalPrice ;
                    updateData.THigh_lower = rAppraisalInfo.THigh_lower ;
                    updateData.TDiffAppraisalPercent = rAppraisalInfo.TDiffAppraisalPercent ;
                    updateData.AppraisalSummary = rAppraisalInfo.AppraisalSummary ;
                    updateData.AppraisalList = rAppraisalInfo.AppraisalList ;
                    updateData.AppraisalBankid = rAppraisalInfo.AppraisalBankid ;
                    updateData.AppraisalDate = rAppraisalInfo.AppraisalDate ;
                    updateData.chkmistake = rAppraisalInfo.chkmistake ;
                    updateData.mistakedetail = rAppraisalInfo.mistakedetail ;
                    updateData.warningletter = rAppraisalInfo.warningletter ;
                    updateData.warningdetail = rAppraisalInfo.warningdetail ;
                    updateData.Headteam = rAppraisalInfo.Headteam ;
                    updateData.datecheck = rAppraisalInfo.datecheck ;
                    updateData.AssistantAppDirector = rAppraisalInfo.AssistantAppDirector ;
                    updateData.AssistDate = rAppraisalInfo.AssistDate ;
                    updateData.AppDirector = rAppraisalInfo.AppDirector ;
                    updateData.AppDireDate = rAppraisalInfo.AppDireDate ;
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

      
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> PostRAppraisalInfo([FromForm] RAppraisalInfoPostMode rAppraisalInfo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var insertdata = new RAppraisalInfo
                {
                    //RAppraisalID = 0,
                    AppraisalID = rAppraisalInfo.AppraisalID,
                    DateCompCheck = rAppraisalInfo.DateCompCheck,
                    BankDateCheck = rAppraisalInfo.BankDateCheck,
                    CIFName = rAppraisalInfo.CIFName,
                    MonthCheck = rAppraisalInfo.MonthCheck,
                    YearCheck = rAppraisalInfo.YearCheck,
                    APPNO = rAppraisalInfo.APPNO,
                    ProjectName = rAppraisalInfo.ProjectName,
                    Houseno = rAppraisalInfo.Houseno,
                    Street = rAppraisalInfo.Street,
                    SubDistrict = rAppraisalInfo.SubDistrict,
                    District = rAppraisalInfo.District,
                    Province = rAppraisalInfo.Province,
                    LandLocationDetail = rAppraisalInfo.LandLocationDetail,
                    Publicutility = rAppraisalInfo.Publicutility,
                    Otherdetail = rAppraisalInfo.Otherdetail,
                    DocumentType = rAppraisalInfo.DocumentType,
                    DocumentNo = rAppraisalInfo.DocumentNo,
                    AreaNgan = rAppraisalInfo.AreaNgan,
                    AreaRai = rAppraisalInfo.AreaRai,
                    AreaWa = rAppraisalInfo.AreaWa,
                    LCAppraisalUPrice = rAppraisalInfo.LCAppraisalUPrice,
                    LCAppraisalPrice = rAppraisalInfo.LCAppraisalPrice,
                    LBAppraisalUPrice = rAppraisalInfo.LBAppraisalUPrice,
                    LBAppraisalPrice = rAppraisalInfo.LBAppraisalPrice,
                    LBPriceSuitable = rAppraisalInfo.LBPriceSuitable,
                    LDAppraisalPrice = rAppraisalInfo.LDAppraisalPrice,
                    LHigh_lower = rAppraisalInfo.LHigh_lower,
                    LDiffAppraisalPercent = rAppraisalInfo.LDiffAppraisalPercent,
                    LAcceptPrice = rAppraisalInfo.LAcceptPrice,
                    BuildingModel = rAppraisalInfo.BuildingModel,
                    NoOfFloor = rAppraisalInfo.NoOfFloor,
                    DocuementAttach = rAppraisalInfo.DocuementAttach,
                    BCAppraisalPrice = rAppraisalInfo.BCAppraisalPrice,
                    BBAppraisalPrice = rAppraisalInfo.BBAppraisalPrice,
                    BDAppraisalPrice = rAppraisalInfo.BDAppraisalPrice,
                    BHigh_lower = rAppraisalInfo.BHigh_lower,
                    BDiffAppraisalPercent = rAppraisalInfo.BDiffAppraisalPercent,
                    BPriceSuitable = rAppraisalInfo.BPriceSuitable,
                    BAcceptPrice = rAppraisalInfo.BAcceptPrice,
                    TPriceSuitable = rAppraisalInfo.TPriceSuitable,
                    TCAppraisalPrice = rAppraisalInfo.TCAppraisalPrice,
                    TBAppraisalPrice = rAppraisalInfo.TBAppraisalPrice,
                    TDAppraisalPrice = rAppraisalInfo.TDAppraisalPrice,
                    THigh_lower = rAppraisalInfo.THigh_lower,
                    TDiffAppraisalPercent = rAppraisalInfo.TDiffAppraisalPercent,
                    AppraisalSummary = rAppraisalInfo.AppraisalSummary,
                    AppraisalList = rAppraisalInfo.AppraisalList,
                    AppraisalBankid = rAppraisalInfo.AppraisalBankid,
                    AppraisalDate = rAppraisalInfo.AppraisalDate,
                    chkmistake = rAppraisalInfo.chkmistake,
                    mistakedetail = rAppraisalInfo.mistakedetail,
                    warningletter = rAppraisalInfo.warningletter,
                    warningdetail = rAppraisalInfo.warningdetail,
                    Headteam = rAppraisalInfo.Headteam,
                    datecheck = rAppraisalInfo.datecheck,
                    AssistantAppDirector = rAppraisalInfo.AssistantAppDirector,
                    AssistDate = rAppraisalInfo.AssistDate,
                    AppDirector = rAppraisalInfo.AppDirector,
                    AppDireDate = rAppraisalInfo.AppDireDate,
                };

                #region :: genPK ::
                using (SqlConnection sqlConnection = new SqlConnection(EnumMessage.connectionString.connect))
                {
                    sqlConnection.Open();
                    SqlCommand sql = new SqlCommand(" SELECT NEXT VALUE FOR  dbo.RAppraisalInfo_SEQ", sqlConnection);

                    using (SqlDataReader reader = sql.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            insertdata.RAppraisalID = reader.GetInt64(0);
                        }
                    }
                    sqlConnection.Close();
                }
                #endregion

                _context.Attach(insertdata).State = EntityState.Added;
                _context.SaveChanges();



                //_context.SaveChanges();


                //_context.RAppraisalInfo.Add(insertdata);


                return CreatedAtAction("GetRAppraisalInfo", new { id = insertdata.RAppraisalID }, rAppraisalInfo);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
           
        }

        // DELETE: api/RAppraisalInfoes/5
        [HttpDelete("{RAppraisalID}")]
        public async Task<IActionResult> DeleteRAppraisalInfo([FromRoute] long RAppraisalID)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rAppraisalInfo = await _context.RAppraisalInfo.FindAsync(RAppraisalID);
            if (rAppraisalInfo == null)
            {
                return NotFound();
            }

            _context.RAppraisalInfo.Remove(rAppraisalInfo);
            await _context.SaveChangesAsync();

            return Ok(rAppraisalInfo);
        }

        private bool RAppraisalInfoExists(long id)
        {
            return _context.RAppraisalInfo.Any(e => e.RAppraisalID == id);
        }
    }
}