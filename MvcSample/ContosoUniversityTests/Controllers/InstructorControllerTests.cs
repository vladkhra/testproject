using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContosoUniversity.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ContosoUniversity.Models;

namespace ContosoUniversity.Controllers.Tests
{
    [TestClass()]
    public class InstructorControllerTests
    {
        private InstructorController controller;
        [TestInitialize]
        public void InitializeTest()
        {
            controller = new InstructorController();
        }

        [TestMethod()]
        public void DetailsTest()
        {
            var viewResult = controller.Details(10) as ViewResult;
            var model = viewResult.Model as Instructor;
            Assert.IsNotNull(model);
        }
    }
}