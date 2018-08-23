using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Dapper;

namespace DapperJsonExtension.Controllers
{
    [Route("api/dapper")]
    [ApiController]
    public class DapperController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (var cn = new SqlConnection("your connection string"))
            {
                var sql = @"select col1, col2, col3 from table for json path";
                var data = cn.QueryJson(sql);

                return Ok(data);
            }
        }

    }
}
