using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using CAMSGHB.CAMS.API.Enum;
using CAMSGHB.CAMS.API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CAMSGHB.CAMS.API.Controllers
{
   
    [EnableCors("MyCORSPolicy")]
    [ApiController]
    public class SamplingProjectViewController : ControllerBase
    {
        private readonly DBCams3context _context;

        public SamplingProjectViewController(DBCams3context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("api/[action]")]
        public async Task<IActionResult> SamplingProjectView([FromQuery]GetSamplingProjectViewModel data)
        {
            decimal totalCount;
            int SearchByPercent = 0;
;           try
            {

                IQueryable<SamplingProjectView> iQueryData = null ;
                List<SamplingProjectView> getData = new List<SamplingProjectView>();

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                    getData = (from getView in _context.SamplingProjectView
                               where ((data.AppraisalID == 0) || (getView.AppraisalID == data.AppraisalID))
                               && (string.IsNullOrEmpty(data.AANo) || (getView.AANo.Trim() == data.AANo.Trim()))
                               && (string.IsNullOrEmpty(data.ProjectCode) || (getView.ProjectCode.Trim() == data.ProjectCode.Trim()))
                               && (data.ProjectType == 0 || (getView.ProjectType == data.ProjectType))
                               && (string.IsNullOrEmpty(data.Description) || (getView.Description.Trim() == data.Description.Trim()))
                               && (string.IsNullOrEmpty(data.BranchCode) || (getView.BranchCode.Trim() == data.BranchCode.Trim()))
                               && (string.IsNullOrEmpty(data.Expr1) || (getView.Expr1.Trim() == data.Expr1.Trim()))
                               && (data.L2VAL == 0 || (getView.L2VAL == data.L2VAL))
                               && (string.IsNullOrEmpty(data.Project_GroupDetail) || (getView.Project_GroupDetail.Trim() == data.Project_GroupDetail.Trim()))
                               && (data.L2VALN == 0 || (getView.L2VALN == data.L2VALN))
                               
                               select getView).ToList();

               
                if (!string.IsNullOrEmpty(data.ProjectGroupDsb))
                {
                    if (data.ProjectGroupDsb == "FT")
                    {
                        getData = getData.Where(x => x.ProjectGroupDsb == "FT" || x.ProjectGroupDsb == "RFT" || x.ProjectGroupDsb == "SFT").ToList();
                    }
                    if (data.ProjectGroupDsb == "BZP")
                    {
                        getData = getData.Where(x => x.ProjectGroupDsb == "BZP").ToList();
                    }
                    if (data.ProjectGroupDsb == "LTF")
                    {
                        getData = getData.Where(x => x.ProjectGroupDsb == "LTF").ToList();
                    }
                }

                if (data.percent > 0)
                {
                    totalCount = (decimal)((getData.Count() * data.percent) / 100.00);
                    SearchByPercent = (int)Math.Ceiling(totalCount);
                    iQueryData = getData.Take(SearchByPercent).AsQueryable();
                }
                else
                {
                    iQueryData = getData.AsQueryable();
                }

                return Ok(iQueryData.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/[action]")]
        public async Task<IActionResult> SamplingProjectViewBZP([FromQuery]GetSamplingProjectViewModel data)
        {
            decimal totalCount;
            int SearchByPercent = 0;
            ; try
            {

                IQueryable<SamplingProjectViewBZP> iQueryData = null;
                List<SamplingProjectViewBZP> getData = new List<SamplingProjectViewBZP>();

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                getData = (from getView in _context.SamplingProjectViewBZP
                           where ((data.AppraisalID == 0) || (getView.AppraisalID == data.AppraisalID))
                           && (string.IsNullOrEmpty(data.AANo) || (getView.AANo.Trim() == data.AANo.Trim()))
                           && (string.IsNullOrEmpty(data.ProjectCode) || (getView.ProjectCode.Trim() == data.ProjectCode.Trim()))
                           && (data.ProjectType == 0 || (getView.ProjectType == data.ProjectType))
                           && (string.IsNullOrEmpty(data.Description) || (getView.Description.Trim() == data.Description.Trim()))
                           && (string.IsNullOrEmpty(data.BranchCode) || (getView.BranchCode.Trim() == data.BranchCode.Trim()))
                           && (string.IsNullOrEmpty(data.Expr1) || (getView.Expr1.Trim() == data.Expr1.Trim()))
                           && (data.L2VAL == 0 || (getView.L2VAL == data.L2VAL))
                           && (string.IsNullOrEmpty(data.Project_GroupDetail) || (getView.Project_GroupDetail.Trim() == data.Project_GroupDetail.Trim()))
                           && (data.L2VALN == 0 || (getView.L2VALN == data.L2VALN))

                           select getView).ToList();


                if (!string.IsNullOrEmpty(data.ProjectGroupDsb))
                {
                    if (data.ProjectGroupDsb == "FT")
                    {
                        getData = getData.Where(x => x.ProjectGroupDsb == "FT" || x.ProjectGroupDsb == "RFT" || x.ProjectGroupDsb == "SFT").ToList();
                    }
                    if (data.ProjectGroupDsb == "BZP")
                    {
                        getData = getData.Where(x => x.ProjectGroupDsb == "BZP").ToList();
                    }
                    if (data.ProjectGroupDsb == "LTF")
                    {
                        getData = getData.Where(x => x.ProjectGroupDsb == "LTF").ToList();
                    }
                }

                if (data.percent > 0)
                {
                    totalCount = (decimal)((getData.Count() * data.percent) / 100.00);
                    SearchByPercent = (int)Math.Ceiling(totalCount);
                    iQueryData = getData.Take(SearchByPercent).AsQueryable();
                }
                else
                {
                    iQueryData = getData.AsQueryable();
                }

                return Ok(iQueryData.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}