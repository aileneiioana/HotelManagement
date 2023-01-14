﻿using System;
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
            using (HoteldbEntities111 db = new HoteldbEntities111())
            {
                db.Room_tbl.Add(model);
                db.SaveChanges();
            }
        }

        public List<Room_tbl> GetRooms()
        {
            using (HoteldbEntities111 db = new HoteldbEntities111())
            {
                return db.Room_tbl.ToList<Room_tbl>();
            }
        }

        public List<int> GetFreeIDs()
        {
            using (HoteldbEntities111 db = new HoteldbEntities111())
            {
                return db.Room_tbl.Where(x => x.RoomFree == "free").Select(x => x.RoomId).ToList();

            }
        }

        public List<Room_tbl> GetRoomsById(int id)
        {
            using (HoteldbEntities111 db = new HoteldbEntities111())
            {
                return db.Room_tbl.Where(x => x.RoomId == id).ToList();
            }
        }
        public void EditRoom(Room_tbl model)
        {
            using (HoteldbEntities111 db = new HoteldbEntities111())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteRoom(Room_tbl model)
        {
            using (HoteldbEntities111 db = new HoteldbEntities111())
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
            using (HoteldbEntities111 db = new HoteldbEntities111())
            {
                return db.Room_tbl.Where(x => x.RoomId == id).FirstOrDefault();
            }
        }

        public void updateRoomState(int id, string state)
        {
            using (HoteldbEntities111 db = new HoteldbEntities111())
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

    };
}
