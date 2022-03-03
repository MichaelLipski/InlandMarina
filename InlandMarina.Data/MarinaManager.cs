using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandMarina.Data
{
    public class MarinaManager
    {

        // to create a Lease
        public static void LeaseSlip(int SlipID, int CustomerID)
        {
            MarinaEntities db = new MarinaEntities();
            Lease newLease = new Lease();
            newLease.SlipID = SlipID;
            newLease.CustomerID = CustomerID;
            db.Leases.Add(newLease);
            db.SaveChanges();
        }

        public static class CustomerManager
        {
            /// <summary>
            /// adds another customer
            /// </summary>
            /// <param name="instr">customer to add</param>
            public static void Add(Customer cu)
            {
                MarinaEntities db = new MarinaEntities(); // context object
                db.Customers.Add(cu);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// retrieves all data of slips
        /// </summary>
        /// <returns></returns>
        public static List<Slip> GetAll()
        {
            MarinaEntities db = new MarinaEntities(); // instantiate context object
            List<Slip> slips = db.Slips.ToList();
            return slips;
        }
        // to use in the drop down list
        public static IList GetAllAsListItems()
        {
            MarinaEntities db = new MarinaEntities();
            var slips = db.Slips.Select(c => new { ID = c.ID, DockID = c.DockID }).ToList();
            return slips;
        }

        // to use in the docks drop down list
        public static IList GetAllAsListDockItems()
        {
            MarinaEntities db = new MarinaEntities();
            var docks = db.Docks.Select(d => new { ID = d.ID, Name = d.Name, WaterService = d.WaterService, ElectricalService = d.ElectricalService }).ToList();
            return docks;
        }

        // to use in the slips (A) drop down list
        public static IList GetAllAsListDockItemsA()
        {
            MarinaEntities db = new MarinaEntities();
            var slipsA = db.Slips.Select(s => new { ID = s.ID, Width = s.Width, Length = s.Length, DockId = s.DockID }).ToList();
            return slipsA;
        }

        // to use in the slips (B) drop down list
        public static IList GetAllAsListDockItemsB()
        {
            MarinaEntities db = new MarinaEntities();
            var slipsB = db.Slips.Select(s => new { ID = s.ID, Width = s.Width, Length = s.Length, DockId = s.DockID }).ToList();
            return slipsB;
        }

        // to use in the slips (C) drop down list
        public static IList GetAllAsListDockItemsC()
        {
            MarinaEntities db = new MarinaEntities();
            var slipsC = db.Slips.Select(s => new { ID = s.ID, Width = s.Width, Length = s.Length, DockId = s.DockID }).ToList();
            return slipsC;
        }

        // to show the available slips
        public static List<Slip> GetAvailableSlips()
        {
            var db = new MarinaEntities();
            List<Slip> slips = (from slip in db.Slips
                                where (!(from lease in db.Leases
                                         select lease.SlipID).Contains(slip.ID))
                                select slip).ToList();
            return slips;
        }

        // to show the available slips for Dock A
        public static List<Slip> GetAvailableASlips()
        {
            var db = new MarinaEntities();
            List<Slip> slips = (from slip in db.Slips
                                where (!(from lease in db.Leases
                                         select lease.SlipID).Contains(slip.ID)) && slip.DockID == 1
                                select slip).ToList();
            return slips;
        }

        // to show the available slips for Dock B
        public static List<Slip> GetAvailableBSlips()
        {
            var db = new MarinaEntities();
            List<Slip> slips = (from slip in db.Slips
                                where (!(from lease in db.Leases
                                         select lease.SlipID).Contains(slip.ID)) && slip.DockID == 2
                                select slip).ToList();
            return slips;
        }

        // to show the available slips for Dock C
        public static List<Slip> GetAvailableCSlips()
        {
            var db = new MarinaEntities();
            List<Slip> slips = (from slip in db.Slips
                                where (!(from lease in db.Leases
                                         select lease.SlipID).Contains(slip.ID)) && slip.DockID == 3
                                select slip).ToList();
            return slips;
        }

        // find a slip with given id
        public static Slip Find(int id)
        {
            MarinaEntities db = new MarinaEntities();
            Slip sps = db.Slips.SingleOrDefault(c => c.ID == id);
            return sps;
        }

        // find a dock with given id
        public static Dock FindDock(int id)
        {
            MarinaEntities db = new MarinaEntities();
            Dock doc = db.Docks.SingleOrDefault(d => d.ID == id);
            return doc;
        }

        // to show the leases for the logged-in customer
        public static ICollection<Lease> GetLeasesByCustomer(int ID)
        {
            var db = new MarinaEntities();
            List<Lease> leases = (from lease in db.Leases where lease.CustomerID == ID select lease).ToList();
            return leases;
        }
    }
}
