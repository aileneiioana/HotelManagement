using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class RoomServices
    {

        public void AddRoom(Room_tbl model)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                db.Room_tbl.Add(model);
                db.SaveChanges();
            }
        }

        public List<Room_tbl> GetRooms()
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                return db.Room_tbl.ToList<Room_tbl>();
            }
        }

        public List<int> GetRoomsIds()
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                return db.Room_tbl.Select(x => x.RoomId).ToList();
            }
        }

        public List<int> GetFreeIDs()
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                return db.Room_tbl.Where(x => x.RoomFree == "free").Select(x => x.RoomId).ToList();

            }
        }

        public List<Room_tbl> GetFreeRooms()
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                return db.Room_tbl.Where(x => x.RoomFree == "free").ToList();

            }
        }

        public List<Room_tbl> GetRoomsById(int id)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                return db.Room_tbl.Where(x => x.RoomId == id).ToList();
            }
        }
        public void EditRoom(Room_tbl model)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteRoom(Room_tbl model)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                var entity = db.Entry(model);
                if (entity.State == EntityState.Detached)
                    db.Room_tbl.Attach(model);
                db.Room_tbl.Remove(model);
                db.SaveChanges();
            }
        }
        public Room_tbl GetRoomById(int id)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                return db.Room_tbl.Where(x => x.RoomId == id).FirstOrDefault();
            }
        }


        public void updateRoomState(int id, string state)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                var rm = db.Room_tbl.Where(f => f.RoomId == id).FirstOrDefault();
                rm.RoomFree = state;
                if (rm != null)
                {
                    db.Entry(rm).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

    }
}
