using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGMPharmaWebApp.Data.Models
{
    public class Manufacturer
    {
        #region Constructor

        public Manufacturer()
        {
            
        }

        #endregion

        #region Properties

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string AlternatePhone { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }

        #endregion
    }
}
