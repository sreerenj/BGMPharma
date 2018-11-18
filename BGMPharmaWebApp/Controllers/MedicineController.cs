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
    public class MedicineController : Controller
    {
        #region Private Variables

        private ApplicationDbContext DbContext;

        #endregion

        #region Constructor

        public MedicineController(ApplicationDbContext context)
        {
            DbContext = context;
        }

            #endregion
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            var medicines = DbContext.Medicines.ToArray();
            return  new JsonResult(medicines, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented
            });
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var medicine = DbContext.Medicines.FirstOrDefault(m => m.Id == id);
            if (medicine == null)
            {
                return NotFound(new
                {
                    Error = string.Format("Medicine with the id {0} not found", id)
                });
            }
            return new JsonResult(medicine, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented
            });
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Medicine value)
        {
            throw new NotImplementedException();
        }

        // PUT api/<controller>/5
        [HttpPut]
        public IActionResult Put([FromBody]Medicine medicine)
        {
            if (medicine == null)
            {
                return new StatusCodeResult(500);
            }

            //var medicine = new Medicine();

            //medicine.MedicineName = modelMedicine.MedicineName;
            //medicine.Description = modelMedicine.Description;
            //medicine.Manufacturer = modelMedicine.Manufacturer;
            //medicine.NetQuantity = modelMedicine.NetQuantity;
            //medicine.TypeId = modelMedicine.TypeId;

            DbContext.Medicines.Add(medicine);
            DbContext.SaveChanges();

            return new JsonResult(medicine, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented
            });
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var medicine = DbContext.Medicines.FirstOrDefault(m => m.Id == id);
            if (medicine == null)
            {
                return NotFound();
            }

            DbContext.Medicines.Remove(medicine);
            DbContext.SaveChanges();

            return new JsonResult(medicine, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented
            });
        }
    }
}
