using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCUnitTestingDemo.Controllers;

[TestClass]
public class EmployeeControllerTest
{
    [TestMethod]
    public void Employees()
    {
        // Arrange
        EmployeeController controller = new EmployeeController();

        // Act
        ViewResult result = controller.Index() as ViewResult;

        // Assert
        Assert.IsNotNull(result);
    }
}
