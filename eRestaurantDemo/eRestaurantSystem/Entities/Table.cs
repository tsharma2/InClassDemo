using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespace
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
#endregion

namespace eRestaurantSystem.Entities
{
    class Table
    {
        [Key]
        public int TableID { get; set; }
        public byte TableNumber { get; set; }
        public bool Smoking { get; set; }
        public bool Capacity { get; set; }
        public bool Available { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
