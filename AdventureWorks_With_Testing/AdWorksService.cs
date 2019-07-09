using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks_With_Testing.Models;

namespace AdventureWorks_With_Testing
{
    // 3. Define service. Service can be tested, separate from repository.
    public class AdWorksService
    {
        // 4. Define constructor and fields to determine if in testing or not
        public IAdWorksRepository _repository;

        public AdWorksService(IAdWorksRepository adWorksRepository = null)
        {
            // If the constructor does not recieve Interface, _repository is an instance of a repository that interacts with database
            _repository = adWorksRepository ?? new AdWorksRepository();
        }

        // 5. Define methods for application. These can be testable based on class constructor. 
        public void Add_Shipping_Method(ShipMethod method)
        {
            _repository.Add_Shipping_Method(method);
        }

        public List<ShipMethod> GetShipMethods()
        {
            return _repository.GetShipMethods();
        }
    }
}
