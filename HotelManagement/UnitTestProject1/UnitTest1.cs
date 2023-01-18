using HotelManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using HotelManagementApplication;

namespace UnitTestProject1
{
    [TestClass]
    public class DBUnitTest
    {

        [TestMethod]
        public void DBStaffPasswordTestMethod()
        {
            var mockStaff = new Mock<Staff_tbl>();
            var staff = new Mock<IStaff>();
            staff.SetupGet(p => p.Staffname).Returns("ioana");
            staff.SetupGet(p => p.Staffpassword).Returns("1211");
            Assert.AreEqual("1211", staff.Object.Staffpassword);


        }

        [TestMethod]
        public void DBReservationFreeRoomTestMethod()
        {
            var mockRes = new Mock<Reservation_tbl>();
            var mockRoom = new Mock<Room_tbl>();
            var res = new Mock<IReservation>();
            var room = new Mock<IRoom>();
            res.SetupGet(p => p.ResId).Returns(1);
            res.SetupGet(p => p.Room).Returns(101);
            room.SetupGet(p => p.RoomId).Returns(101);
            room.SetupGet(p => p.RoomFree).Returns("busy");
            Assert.AreEqual(room.Object.RoomId, res.Object.Room);
        }

        [TestMethod]
        public void DBFreeRoomTestMethod()
        {
            var mockRoom = new Mock<Room_tbl>();
            var room = new Mock<IRoom>();
            room.SetupGet(p => p.RoomId).Returns(101);
            room.SetupGet(p => p.RoomFree).Returns("busy");
            Assert.AreEqual(room.Object.RoomFree, "busy");
        }

        [TestMethod]
        public void DBBusyRoomTestMethod()
        {
            var mockRoom = new Mock<Room_tbl>();
            var room = new Mock<IRoom>();
            room.SetupGet(p => p.RoomId).Returns(102);
            room.SetupGet(p => p.RoomFree).Returns("free");
            Assert.AreEqual(room.Object.RoomFree, "free");
        }

        [TestMethod]

        public void DBClientNameTestMethod()
        {
            var mockClient = new Mock<Client_tbl>();
            var client = new Mock<IClient>();
            client.Setup(p => p.ClientId).Returns(1);
            client.SetupGet(p => p.ClientName).Returns("Robert");
            Assert.AreEqual("Robert", client.Object.ClientName);
        }

        [TestMethod]

        public void DBClientCountryTestMethod()
        {
            var mockClient = new Mock<Client_tbl>();
            var client = new Mock<IClient>();
            client.SetupGet(p => p.ClientId).Returns(1);
            client.SetupGet(p => p.ClientCountry).Returns("ROMANIA");
            Assert.AreEqual("ROMANIA", client.Object.ClientCountry);
        }

        [TestMethod]

        public void DBClientPhoneTestMethod()
        {
            var mockClient = new Mock<Client_tbl>();
            var client = new Mock<IClient>();
            client.Setup(p => p.ClientId).Returns(1);
            client.SetupGet(p => p.ClientPhone).Returns("0756783012");
            Assert.AreEqual("0756783012", client.Object.ClientPhone);
        }

        [TestMethod]
        public void DBFRoomIDTestMethod()
        {
            var mockRoom = new Mock<Room_tbl>();
            var room = new Mock<IRoom>();
            var room1 = GetDemoRoom();
            room.SetupGet(p => p.RoomId).Returns(103);
            room.SetupGet(p => p.RoomFree).Returns("free");
            Assert.AreEqual(room.Object.RoomFree, "free");
        }

        Room_tbl GetDemoRoom()
        {
            return new Room_tbl() { RoomId = 104, RoomPhone = "0233984123", RoomFree = "free" };
        }


        Client_tbl GetDemoClient()
        {
            return new Client_tbl() {  ClientName = "Ioana", ClientCountry = "AUSTRIA", ClientPhone = "0712656732" };
        }
    }
}
