using AdventureWorks_With_Testing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks_With_Testing
{
    // 1. Make Interface
    public interface IAdWorksRepository
    {
        void Add_Shipping_Method(ShipMethod method);
        List<ShipMethod> GetShipMethods();
    }

    // 2. Define class for interacting with database. 
    public class AdWorksRepository : IAdWorksRepository
    {
        AdventureWorks2012Entities db = new AdventureWorks2012Entities();

        public List<ShipMethod> GetShipMethods()
        {
            return db.ShipMethods.ToList();
        }
        
        public void Add_Shipping_Method(ShipMethod method)
        {
            db.ShipMethods.Add(method);
            db.SaveChanges();
        }
    }
}
