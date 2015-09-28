using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using eRestaurantSystem.Entities;
using eRestaurantSystem.DAL;
using System.ComponentModel; //used for ODS access
#endregion

namespace eRestaurantSystem.BLL
{
    [DataObject]
    public class AdminController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<SpecialEvent> SpecialEvent_List()
        {
            using( var context = new eRestaurantContext())
            {
                //retrieve the data from the SpecialEvents table
                //To do so we will use the DbSet in eRestaurantContext
                //call SpecialEvemts (done by mapping)
 
                //Method syntax
                //return context.SpecialEvents.OrderBy(x => x.Description).ToList();

                //Query syntax
                var results = from item in context.SpecialEvents
                              orderby item.Description
                              select item;

                return results.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Reservation> GetReservationByEventCode(string eventcode)
        {
            using (var context = new eRestaurantContext())
            {
                //Query syntax
                var results = from item in context.Reservations
                              where item.EventCode.Equals(eventcode)
                              orderby item.CustomerName, item.ReservationDate
                              select item;

                return results.ToList();
            }
        }
    }


}
