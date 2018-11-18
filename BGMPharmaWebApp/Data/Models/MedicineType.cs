using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGMPharmaWebApp.Data.Models
{
    public class MedicineType
    {
        #region Constructor

        public MedicineType()
        {

        }

        #endregion

        #region Properties

        public int Id { get; set; }
        public string Type { get; set; }

        #endregion

        #region LazyLoadingProperties

        public virtual List<Medicine> Medicines { get; set; }

        #endregion
    }
}
