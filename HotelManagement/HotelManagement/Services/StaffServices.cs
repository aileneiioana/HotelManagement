using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class StaffServices
    {

        public Staff_tbl validate(string user, string pass)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                return db.Staff_tbl.Where(x => x.Staffname == user && x.Staffpassword == pass).FirstOrDefault();
            }
        }
        public void AddStaff(Staff_tbl model)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                db.Staff_tbl.Add(model);
                db.SaveChanges();
            }
        }

        public List<Staff_tbl> Getstaff()
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                return db.Staff_tbl.ToList<Staff_tbl>();
            }
        }

        public Staff_tbl GetStaffById(int id)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                return db.Staff_tbl.Where(x => x.StaffId == id).FirstOrDefault();
            }
        }

        public List<Staff_tbl> GetStaffByName(String name)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                return db.Staff_tbl.Where(x => x.Staffname == name).ToList();

            }
        }

        public void EditStaff(Staff_tbl model)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteStaff(Staff_tbl model)
        {
            using (HoteldbEntities db = new HoteldbEntities())
            {
                var entity = db.Entry(model);
                if (entity.State == EntityState.Detached)
                    db.Staff_tbl.Attach(model);
                db.Staff_tbl.Remove(model);
                db.SaveChanges();
            }
        }
    };
}
