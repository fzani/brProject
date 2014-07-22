using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using brProjectMVC;
using brProjectMVC.Controllers;

namespace brProjectMVC.Tests.Controllers
{
    [TestClass]
    public class StoreControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            StoreController controller = new StoreController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Product(int id)
        {
            // Arrange
            StoreController controller = new StoreController();

            // Act
            ViewResult result = controller.Product() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Categories()
        {
            // Arrange
            StoreController controller = new StoreController();

            // Act
            ViewResult result = controller.Categories() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
