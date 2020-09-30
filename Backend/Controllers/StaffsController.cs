using System;
using System.Collections.Generic;
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
        public StaffsController()
        {
            //_toys = new Toys("Green",5);
            _toys = new Toys();
            _staffs = new List<Dictionary<string, string>>
            {
                new Dictionary<string, string>
                {
                    { "firstname", "Tola" }, { "lastname", "Adeboye" }, { "bod", "23-07-1999"}, { "education", "University" }, { "soo", "Ogun" }, { "religion", "Christianity" },
                },
                new Dictionary<string, string>
                {
                    { "firstname", "Tola" }, { "lastname", "Adeboye" }, { "bod", "23-07-1999"}, { "education", "University" }, { "soo", "Ogun" }, { "religion", "Christianity" },
                },
            };


        }
        [Route("get")]
        [HttpGet]
        public async Task<List <Dictionary<string, string>>> Staffs()
        {
            return await Task.Run(() => _staffs);
        }
        //[Route("submit")]
        [HttpGet]
        public async Task<string> GetToys()
        {
            //TODO: save to database
            return await Task.Run(() => _toys.Bag());
        }


    }
}
