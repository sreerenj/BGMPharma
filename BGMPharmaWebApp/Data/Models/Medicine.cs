using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace BGMPharmaWebApp.Data.Models
{
    public class Medicine
    {
        #region Constructor
        public Medicine()
        {

        }

        #endregion

        #region Properties

        public int Id { get; set; }
        public string MedicineName { get; set; }
        public string Description { get; set; }
        public int ManufacturerId { get; set; }
        public string Unit { get; set; }
        public int NetQuantity { get; set; }
        public int TypeId { get; set; }
        public string Ingredients { get; set; }

        #endregion


        #region Lazy Load Properties

        [ForeignKey("TypeId")]
        public virtual MedicineType MedicineType { get; set; }
        [ForeignKey("ManufacturerId")]
        public virtual Manufacturer Manufacturer { get; set; }
        #endregion
    }
}
