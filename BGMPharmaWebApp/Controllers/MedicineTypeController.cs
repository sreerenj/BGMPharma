using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BGMPharmaWebApp.Data;
using BGMPharmaWebApp.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BGMPharmaWebApp.Controllers
{
    [Route("api/[controller]")]
    public class MedicineTypeController : Controller
    {
        private ApplicationDbContext DbContext;

        public MedicineTypeController(ApplicationDbContext context)
        {
            DbContext = context;
        }

        [HttpGet("ByName/{typeName}")]
        public IActionResult ByName(string typeName)
        {
            var medicineType = DbContext.MedicineTypes.FirstOrDefault(mt => mt.Type.StartsWith(typeName));
            if (medicineType == null)
            {
                return NotFound();
            }

            return new JsonResult(medicineType, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented
            });
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            var medicineTypes = DbContext.MedicineTypes.ToArray();
            return new JsonResult(medicineTypes, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented
            });
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var medicineType = DbContext.MedicineTypes.FirstOrDefault(mt => mt.Id == id);
            if (medicineType == null)
            {
                return StatusCode(500);
            }

            return new JsonResult(medicineType, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented
            });;
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]MedicineType value)
        {
            var medicineType = DbContext.MedicineTypes.FirstOrDefault(mt => mt.Id == value.Id);
            if (medicineType == null)
            {
                return NotFound(new
                {
                    Error = string.Format("Medicine Type with the Id {0} not found",value.Id)
                });
            }

            medicineType.Type = value.Type;
            DbContext.SaveChanges();

            return new JsonResult(medicineType, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented
            });
        }

        // PUT api/<controller>/5
        [HttpPut]
        public IActionResult Put([FromBody]MedicineType medicineType)
        {
            DbContext.MedicineTypes.Add(medicineType);
            DbContext.SaveChanges();
            return new JsonResult(medicineType, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented
            });
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var medicineType = DbContext.MedicineTypes.FirstOrDefault(mt => mt.Id == id);
            if (medicineType == null)
            {
                return StatusCode(500);
            }

            DbContext.MedicineTypes.Remove(medicineType);
            DbContext.SaveChanges();
            return new JsonResult(medicineType, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented
            });
        }
    }
}
