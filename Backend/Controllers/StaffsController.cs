using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Backend.Tola;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("service/Staffs")]
    [ApiController]
    public class StaffsController : ControllerBase

    {
        private List<Dictionary<string, string>> _staffs;
        private Toys _toys;
        private SqlConnection _connection;
        public StaffsController()
        {
            _connection = new SqlConnection("server=DESKTOP-D2JHR9D\\SQLEXPRESS;database=StaffManagement;user id=sa; password=tola;MultipleActiveResultSets=True");
            //SELECT[Staff_Id],[First_Name],[Last_Name],[Bod],[Education],[Religion]

            //_toys = new Toys("Green",5);
            _toys = new Toys();
           

        }
        [Route("get")]
        [HttpGet]
        public async Task<List<Dictionary<string, string>>> Staffs()
        {
            var staffs = new List<Dictionary<string, string>>();
            using (var cmd = new SqlCommand("Get_Staffs", _connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                _connection.Open();
                var rows = await cmd.ExecuteReaderAsync();
                while (rows.Read())
                {
                    var d = new Dictionary<string, string>();
                    for (var i = 0; i < rows.FieldCount; i++)
                    {
                        d.Add(rows.GetName(i), rows.GetValue(i).ToString());
                    }
                    staffs.Add(d);
                }
                return staffs;
            }

        }
    }
}
