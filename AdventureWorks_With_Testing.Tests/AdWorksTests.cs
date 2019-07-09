using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks_With_Testing;
using Moq;
using AdventureWorks_With_Testing.Models;

namespace AdventureWorks_With_Testing.Tests
{
    [TestFixture]
    public class AdWorksTests
    {
        // 6. SetUp with fields as mock objects instead of database. Remember that the service can be tested.
        private AdWorksService _adWorksService;
        // 6a. Need a mock repository in place of your database for testing. 
        private Mock<IAdWorksRepository> _adWorksRepository;

        [SetUp]
        public void Setup()
        {
            _adWorksRepository = new Mock<IAdWorksRepository>();
            _adWorksService = new AdWorksService(_adWorksRepository.Object);
        }

        // 7. Test with mock objects
        [Test]
        public void Add_Shipping_Method_With_Ship_Object_Adds_To_Database()
        {
            // Expected
            List<ShipMethod> shipMethods = new List<ShipMethod>();

            // Arrange
            _adWorksRepository.Setup(repo => repo.Add_Shipping_Method(It.IsAny<ShipMethod>()));

            ShipMethod shipMethod = new ShipMethod
            {
                Name = "Bicycle",
                ShipBase = 0.0M,
                ShipRate = 0.1M,
                rowguid = Guid.NewGuid(),
                ModifiedDate = DateTime.Now
            };

            // Act

        }
    }
}
