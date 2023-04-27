using Moq;
using NUnit.Framework;
using Rana.De.DateCalculator.Controllers;
using Rana.De.DateCalculator.Models;
using Rana.De.DateCalculator.Repository;

namespace Rana.De.DateCalculatorTest
{
    public class HomeControllerTest
    {
        private Mock<IDateCaculatorRepo> DateCaculatorRepomock;
        private IDateCaculatorRepo dateCaculatorRepo;
        private HomeController controller;
        [SetUp]
        public void Setup()
        {
            DateCaculatorRepomock=new Mock<IDateCaculatorRepo>();
            dateCaculatorRepo = DateCaculatorRepomock.Object;
            controller = new HomeController(DateCaculatorRepomock.Object);

        }

        [Test]
        public void IndexTest()
        {
            //Arrange
            DateCalculatorViewModel model = new DateCalculatorViewModel()
            {
                StartDate = "4/26/2023",
                EndDate = "4/27/2023"
            };
        DateCaculatorRepomock
            .Setup(x => x.doDaysCalculate(model)).Returns(1);
            //Act
            var result = controller.Index(model.StartDate,model.EndDate);
            //Assert
            Assert.IsNotNull(result);
        }
    }
    }
