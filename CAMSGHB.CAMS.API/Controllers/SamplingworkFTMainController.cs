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
    public class SamplingworkFTMainController : ControllerBase
    {
        private readonly DBCams3context _context;

        public SamplingworkFTMainController(DBCams3context context)
        {
            _context = context;
        }

        // GET: api/SamplingworkFTMain/5
        [HttpGet]
        public async Task<IActionResult> GetSamplingworkFTMain([FromQuery] SamplingworkFTMainGetModel data)
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

                if (!string.IsNullOrEmpty(data.RJobType))
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
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var updateData = _context.SamplingworkFTMain.Where(x => x.RAppraisalID == samplingworkFTMain.RAppraisalID).FirstOrDefault();
                if (updateData == null)
                {
                    return NotFound(EnumMessage.StatusMessage.Error.NotFoundUpdate);
                }
                else
                {
                    updateData.AppraisalID = samplingworkFTMain.AppraisalID;
                    updateData.ProjectName = samplingworkFTMain.ProjectName;
                    updateData.ProjectCode = samplingworkFTMain.ProjectCode;
                    updateData.MonthCheck = samplingworkFTMain.MonthCheck;
                    updateData.YearCheck = samplingworkFTMain.YearCheck;
                    updateData.BankDateCheck = samplingworkFTMain.BankDateCheck;
                    updateData.SubCategory = samplingworkFTMain.SubCategory;
                    updateData.Landplot = samplingworkFTMain.Landplot;
                    updateData.RoomPlan = samplingworkFTMain.RoomPlan;
                    updateData.ProjPlan = samplingworkFTMain.ProjPlan;
                    updateData.House_Roomno = samplingworkFTMain.House_Roomno;
                    updateData.Pictures = samplingworkFTMain.Pictures;
                    updateData.OtherDocument = samplingworkFTMain.OtherDocument;
                    updateData.AppraisalBankid = samplingworkFTMain.AppraisalBankid;
                    updateData.AppraisalDate = samplingworkFTMain.AppraisalDate;
                    updateData.ChkReportBankid = samplingworkFTMain.ChkReportBankid;
                    updateData.ChkReportdate = samplingworkFTMain.ChkReportdate;
                    updateData.AssistantAppDirector = samplingworkFTMain.AssistantAppDirector;
                    updateData.AssistDate = samplingworkFTMain.AssistDate;
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
        

        // POST: api/SamplingworkFTMain
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> PostSamplingworkFTMain([FromForm] SamplingworkFTMainPOstModel samplingworkFTMain)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }


                var insertData = new SamplingworkFTMain()
                {
                    
                    AppraisalID = samplingworkFTMain.AppraisalID,
                    ProjectName = samplingworkFTMain.ProjectName,
                    ProjectCode = samplingworkFTMain.ProjectCode,
                    MonthCheck = samplingworkFTMain.MonthCheck,
                    YearCheck = samplingworkFTMain.YearCheck,
                    BankDateCheck = samplingworkFTMain.BankDateCheck,
                    SubCategory = samplingworkFTMain.SubCategory,
                    Landplot = samplingworkFTMain.Landplot,
                    RoomPlan = samplingworkFTMain.RoomPlan,
                    ProjPlan = samplingworkFTMain.ProjPlan,
                    House_Roomno = samplingworkFTMain.House_Roomno,
                    Pictures = samplingworkFTMain.Pictures,
                    OtherDocument = samplingworkFTMain.OtherDocument,
                    AppraisalBankid = samplingworkFTMain.AppraisalBankid,
                    AppraisalDate = samplingworkFTMain.AppraisalDate,
                    ChkReportBankid = samplingworkFTMain.ChkReportBankid,
                    ChkReportdate = samplingworkFTMain.ChkReportdate,
                    AssistantAppDirector = samplingworkFTMain.AssistantAppDirector,
                    AssistDate = samplingworkFTMain.AssistDate,
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
                            insertData.RAppraisalID = reader.GetInt64(0);
                        }
                    }
                    sqlConnection.Close();
                }
                #endregion


                _context.SamplingworkFTMain.Add(insertData);
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