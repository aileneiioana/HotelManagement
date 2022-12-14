using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Services
{
    public class ReservationServices
    {
        public void AddRes(Reservation_tbl model)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                db.Reservation_tbl.Add(model);
                db.SaveChanges();
            }
        }

        public Reservation_tbl GetResById(int id)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                return db.Reservation_tbl.Where(x => x.ResId == id).FirstOrDefault();
            }
        }

        public void EditRes(Reservation_tbl model)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteRes(Reservation_tbl model)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                var entity = db.Entry(model);
                if (entity.State == EntityState.Detached)
                    db.Reservation_tbl.Attach(model);
                db.Reservation_tbl.Remove(model);
                db.SaveChanges();
            }
        }

        public List<Reservation_tbl> GetRes()
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                return db.Reservation_tbl.ToList<Reservation_tbl>();
            }
        }

        public List<Reservation_tbl> GetReservationsById(int id)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                return db.Reservation_tbl.Where(x => x.ResId == id).ToList();
            }
        }


    };
}
