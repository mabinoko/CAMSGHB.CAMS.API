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
using System.Globalization;

namespace CAMSGHB.CAMS.API.Controllers
{
    [Route("api/")]
    [EnableCors("MyCORSPolicy")]
    [ApiController]
    public class AppraisalsController : ControllerBase
    {
        private readonly DBCams3context _context;

        public AppraisalsController(DBCams3context context)
        {
            _context = context;
        }

        public class Pagination
        {
            public int MaxPage { get; set; }
            public int MaxRow { get; set; }
            public int RowPerPage { get; set; }
            public string KeyWord { get; set; }
            public int CurrentPage { get; set; }
            public int Start { get; set; }

            public Pagination()
            {
                CurrentPage = 1;
                RowPerPage = 10;
            }
        }
        //GET: api/Appraisals
        [HttpGet("AppraisalsMain")]
        public async Task<IActionResult> GetAppraisal([FromQuery]AppraisalGetModel data)
        {
            var getdata = new List<AppraisalDisplay>();
            decimal totalCount;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var getJoinTable = (from AppraisalJoin in _context.Appraisal
                                    join BranchJoin in _context.Branch on Convert.ToInt64(AppraisalJoin.BrCode) equals BranchJoin.BranchId
                                    join CompanyJoin in _context.Company on AppraisalJoin.ApprComp equals CompanyJoin.CompanyId
                                    join AppraisalJobJoin in _context.AppraisalJobType on AppraisalJoin.AppraisalJobType equals AppraisalJobJoin.AppraisalJobType1
                                    join CollateralJoin in _context.CollateralList on AppraisalJoin.AppraisalId equals CollateralJoin.AppraisalId
                                    join AppriValInfo in _context.AppraisalValueInfo on CollateralJoin.CollateralListId equals AppriValInfo.CollateralListId
                                    join Customer in _context.CustomerList on AppraisalJoin.AppraisalId equals Customer.AppraisalId
                                    join ProgressJoin in _context.Progress on AppraisalJoin.ProgressStatus equals ProgressJoin.ProgressCode
                                    where ((data.AppraisalId == 0) || (AppraisalJoin.AppraisalId == data.AppraisalId)) 
                                    && ((string.IsNullOrEmpty(data.AANo)) || (AppraisalJoin.Aano == data.AANo))
                                    && ((string.IsNullOrEmpty(data.FirstName)) || (Customer.Cifname.Contains(data.FirstName)))
                                    && ((string.IsNullOrEmpty(data.LastName)) || (Customer.Cifname.Contains(data.LastName)))
                                    && ((string.IsNullOrEmpty(data.ApprComp)) || (AppraisalJoin.ApprComp.Contains(data.ApprComp)))
                                    && ((string.IsNullOrEmpty(data.AccountNo)) || (AppraisalJoin.AccountNo == data.AccountNo))
                                    && ((string.IsNullOrEmpty(data.Appraisal_JobType)) || (AppraisalJoin.AppraisalJobType == data.Appraisal_JobType))
                                    && ((string.IsNullOrEmpty(data.COLL_TYPE_CODE)) || (AppraisalJoin.CollTypeCode == data.COLL_TYPE_CODE))
                                    select new AppraisalDisplay
                                    {
                                            AppraisalId = AppraisalJoin.AppraisalId,
                                            AANo = AppraisalJoin.Aano,
                                            ApprComp = AppraisalJoin.ApprComp,
                                            ApprCompBranch = AppraisalJoin.ApprComp,
                                            AccountNo = AppraisalJoin.AccountNo,
                                            Appraisal_JobTypeName = AppraisalJobJoin.AppraisalJobTypeName,
                                            Appraisal_JobType = AppraisalJobJoin.AppraisalJobType1,
                                            ReqDate = AppraisalJoin.ReqDate.Value.Date,
                                            CIFName = Customer.Cifname,
                                            COLL_TYPE_CODE = AppraisalJoin.CollTypeCode,
                                            CompanyName = CompanyJoin.CompanyName,
                                            BranchName = BranchJoin.BranchName,
                                            BrCode = BranchJoin.BranchId1,
                                            DateSurvey = AppriValInfo.DateSurvey.Value.Date,
                                            AssessmentIn = AppraisalJoin.AssessmentIn,
                                            SeniorIn = AppraisalJoin.SeniorIn,
                                            LeadIn = AppraisalJoin.LeadIn,
                                            GuaranTee1 = AppraisalJoin.GuaranTee1,
                                            GuaranTee2 = AppraisalJoin.GuaranTee2,
                                            GuaranTee3 = AppraisalJoin.GuaranTee3,
                                            ProgressDesc = ProgressJoin.ProgressDesc,
                                            ProgressStatus = ProgressJoin.ProgressCode,
                                            SurveyEx = AppraisalJoin.SurveyEx
                                    }).ToList();

                getdata = getJoinTable;
                if (data.DateSurveyStartDate != null && data.DateSurveyEndDate != null)
                {
                    getdata = getJoinTable.Where(x => x.DateSurvey >= data.DateSurveyStartDate && x.DateSurvey <= data.DateSurveyStartDate).ToList();
                }
                if (data.ReqDateStartDate != null && data.ReqDateEndDate != null)
                {
                    getdata = getJoinTable.Where(x => x.ReqDate >= data.ReqDateStartDate && x.ReqDate <= data.ReqDateEndDate).ToList();
                }
                if(data.percent > 0)
                {
                    totalCount = (decimal)((getJoinTable.Count() * data.percent) / 100.00);
                    var SearchByPercent = (int)Math.Ceiling(totalCount);
                    getdata = getJoinTable.Take(SearchByPercent).ToList();
                    return Ok(getdata);
                }
                else
                {
                    return Ok(getdata);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private bool AppraisalExists(long id)
        {
            return _context.Appraisal.Any(e => e.AppraisalId == id);
        }

        private DateTime Formatdate(string Date)
        {
            string[] arr = null;
            string newDate = null;
            DateTime formatDate = new DateTime();
            arr = Date.Split("/");
            newDate = arr[2] + "-" + arr[0] + "-" + arr[1];
            formatDate = Convert.ToDateTime(newDate).Date;
            return formatDate;
        }
    }
}