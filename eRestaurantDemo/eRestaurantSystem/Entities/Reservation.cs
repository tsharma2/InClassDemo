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
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }
        public string CustomerName { get; set; }
        public DateTime ReservationDate { get; set; }
        public int NumberInParty { get; set; }
        public string ContactPhone { get; set; }
        public char ReservationStatus { get; set; }
        public char EventCode { get; set; }

        //Navigation  Properties
        public virtual SpecialEvent Event { get; set; }

        //The reservation table is a many to many relationship to Tables table
        // The sql Reservation table resolves this problem 
        //However Reservation table holds only a compound primary key
        // we will not create a reservation table entity in our project but 
        //handle it via navigation mapping
        // Therefor we will place an Icollection properties in this entity
        //refering to the Tables table.

        public virtual ICollection<Table> Tables { get; set; }
    }
}
