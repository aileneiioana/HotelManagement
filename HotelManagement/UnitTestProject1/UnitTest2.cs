using HotelManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using HotelManagementApplication;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculationUnitTest
    {

        [TestMethod]
        public void PriceTestMethod()
        {
            var mockStaff = new Mock<Staff_tbl>();
            var staff = new Mock<IStaff>();
            staff.SetupGet(p => p.Staffname).Returns("ioana");
            staff.SetupGet(p => p.Staffpassword).Returns("1211");
            Assert.AreEqual("1211", staff.Object.Staffpassword);


        }
    }
}
