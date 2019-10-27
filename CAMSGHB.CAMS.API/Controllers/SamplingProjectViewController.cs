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
    [Route("api/[controller]")]
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
        public async Task<IActionResult> GetSamplingProjectView([FromQuery]GetSamplingProjectViewModel data)
        {
            decimal totalCount;
            int SearchByPercent = 0;
;           try
            {

                IQueryable<SamplingProjectView> iQueryData;

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if(data.percent > 0)
                {
                    totalCount = (_context.SamplingProjectView.Count() * data.percent ) / 100 ;
                    SearchByPercent = (int)Math.Ceiling(totalCount);
                }

                iQueryData = _context.SamplingProjectView;

                if (data.AppraisalID != 0)
                {
                    iQueryData = _context.SamplingProjectView.Where(x => x.AppraisalID == data.AppraisalID).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.AANo))
                {
                    iQueryData = _context.SamplingProjectView.Where(x => x.AANo.Trim() == data.AANo.Trim()).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.ProjectCode))
                {
                    iQueryData = _context.SamplingProjectView.Where(x => x.ProjectCode.Trim() == data.ProjectCode.Trim()).AsQueryable();
                }
                if (data.ProjectType != 0)
                {
                    iQueryData = _context.SamplingProjectView.Where(x => x.ProjectType == data.ProjectType).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.Description))
                {
                    iQueryData = _context.SamplingProjectView.Where(x => x.Description.Trim() == data.Description.Trim()).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.BranchCode))
                {
                    iQueryData = _context.SamplingProjectView.Where(x => x.BranchCode.Trim() == data.BranchCode.Trim()).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.Expr1))
                {
                    iQueryData = _context.SamplingProjectView.Where(x => x.Expr1 == data.Expr1).AsQueryable();
                }
                if (data.L2VAL != 0)
                {
                    iQueryData = _context.SamplingProjectView.Where(x => x.L2VAL == data.L2VAL).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.Project_GroupDetail))
                {
                    iQueryData = _context.SamplingProjectView.Where(x => x.Project_GroupDetail.Trim() == data.Project_GroupDetail.Trim()).AsQueryable();
                }
                if (!string.IsNullOrEmpty(data.ProjectGroupDsb))
                {
                    if (data.ProjectGroupDsb == "FT")
                    {
                        iQueryData = _context.SamplingProjectView.Where(x => x.ProjectGroupDsb.Trim() == "FT" || x.ProjectGroupDsb.Trim() == "RFT" || x.ProjectGroupDsb.Trim() == "SFT").AsQueryable();
                    }
                    if (data.ProjectGroupDsb == "BZP")
                    {
                        iQueryData = _context.SamplingProjectView.Where(x => x.ProjectGroupDsb.Trim() == "BZP").AsQueryable();
                    }
                    if (data.ProjectGroupDsb == "LTF")
                    {
                        iQueryData = _context.SamplingProjectView.Where(x => x.ProjectGroupDsb.Trim() == "LTF").AsQueryable();
                    }
                }

                if (data.L2VALN != 0)
                {
                    iQueryData = _context.SamplingProjectView.Where(x => x.L2VALN == data.L2VALN).AsQueryable();
                }


                if (SearchByPercent > 0)
                {
                    iQueryData = iQueryData.Take(SearchByPercent);
                }

                return Ok(iQueryData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}