using HotelManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using HotelManagementApplication;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculationUnitTest
    {

        [TestMethod]
        public void DateSameMonthTestMethod()
        {
            Booking m = new Booking();
            DateTime data1 = new DateTime(2000, 11, 12);
            DateTime data2 = new DateTime(2000, 11, 22);
            int result = m.getTotalDays(data1, data2);
            Assert.AreEqual(10, result);
        }


        [TestMethod]
        public void DateDifferentMonthTestMethod()
        {
            Booking m = new Booking();
            DateTime data1 = new DateTime(2000, 11, 12);
            DateTime data2 = new DateTime(2000, 12, 22);
            int result = m.getTotalDays(data1, data2);
            Assert.AreEqual(40, result);
        }

        [TestMethod]
        public void CheckPeriodTestMethod1()
        {
            Booking m = new Booking();
            DateTime data1 = new DateTime(2023, 11, 12);
            DateTime data2 = new DateTime(2023, 12, 22);
            bool result = m.checkPediod(data1, data2);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CheckPeriodTestMethod2()
        {
            Booking m = new Booking();
            DateTime data1 = new DateTime(2000, 11, 12);
            DateTime data2 = new DateTime(2000, 12, 22);
            bool result = m.checkPediod(data1, data2);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CheckPeriodTestMethod3()
        {
            Booking m = new Booking();
            DateTime data1 = new DateTime(2023, 11, 12);
            DateTime data2 = new DateTime(2023, 10, 22);
            bool result = m.checkPediod(data1, data2);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CheckEmailTestMethod()
        {
            Booking m = new Booking();
            bool result = m.IsValidEmail("ailenei.ioana@yahoo.com");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CheckEmailTestMethod2()
        {
            Booking m = new Booking();
            bool result = m.IsValidEmail("ailenei.ioana");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CheckPhoneTestMethod()
        {
            Booking m = new Booking();
            bool result = m.isValidPhone("07456");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CheckPhoneTestMethod2()
        {
            Booking m = new Booking();
            bool result = m.isValidPhone("07456a");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CheckPhoneTestMethod3()
        {
            Booking m = new Booking();
            bool result = m.isValidPhone("0745963556");
            Assert.AreEqual(true, result);
        }


    }
}
