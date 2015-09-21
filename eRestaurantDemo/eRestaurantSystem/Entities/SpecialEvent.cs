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
    public class SpecialEvent
    {
        [Key]
        [Required(ErrorMessage= "An Event Code is required (only one character)")]
        [StringLength(1, ErrorMessage= "Event code can only use a single character code")]
        public string EventCode { get; set; }
        [Required(ErrorMessage = "A Description is required (5-30 character)")]
        [StringLength(30, MinimumLength=5, ErrorMessage= "Description must be between 5 to 30 characters")]
       
        public string Description { get; set; }
        public bool Active { get; set; }

        //Navigation virtual property 
        public virtual ICollection<Reservation> Reservation { get; set; }

        //all clas can have their own constructor
        //constructors can contain initialization values

        public SpecialEvent()
        {
            Active = true;
        }


    }
}
