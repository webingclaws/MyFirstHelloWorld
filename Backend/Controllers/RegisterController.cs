using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("service/register")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private SqlConnection _connection;
        public RegisterController()
        {
            _connection = new SqlConnection("server=DESKTOP-D2JHR9D\\SQLEXPRESS;database=StaffManagement;user id=sa; password=tola;MultipleActiveResultSets=True");
        }
        [Route("submit")]
        [HttpPost]
        public async Task<string> Register([FromBody] Dictionary<string, string> payload)
        {
            //TODO: save to database
            
            using (var cmd = new SqlCommand ("Insert_Staff", _connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(new SqlParameter[] {
                    new SqlParameter
                    {
                        ParameterName = "@First_Name", SqlDbType = SqlDbType.NVarChar, Size = 50, Direction = ParameterDirection.Input, Value = payload["firstname"]
                    },
                    new SqlParameter
                    {
                        ParameterName = "@Last_Name", SqlDbType = SqlDbType.NVarChar, Size = 50, Direction = ParameterDirection.Input, Value = payload["lastname"]
                    },
                    new SqlParameter
                    {
                        ParameterName = "@Bod", SqlDbType = SqlDbType.NVarChar, Size = 20, Direction = ParameterDirection.Input, Value = payload["bod"]
                    },
                    new SqlParameter
                    {
                        ParameterName = "@Education", SqlDbType = SqlDbType.NVarChar, Size = 20, Direction = ParameterDirection.Input, Value =payload["education"]
                    },
                    new SqlParameter
                    {
                        ParameterName = "@Origin", SqlDbType = SqlDbType.NVarChar, Size = 20, Direction = ParameterDirection.Input, Value = payload["soo"]
                    },
                    new SqlParameter
                    {
                        ParameterName = "@Religion", SqlDbType = SqlDbType.NVarChar, Size = 20, Direction = ParameterDirection.Input, Value = payload["religion"]
                    }
                });
                _connection.Open();
                var row = await cmd.ExecuteNonQueryAsync();
                return await Task.Run(() => row.ToString());
            }
            
        }
        //[Route("submit")]
        [HttpGet]
        public async Task<string> Get()
        {
            //TODO: save to database
            return await Task.Run(() => "Hello World");
        }
        [Route("Get2")]
        [HttpGet]
        public async Task<string> Get2()
        {
            //TODO: save to database
            return await Task.Run(() => "Hello World 2");
        }
    }
}
