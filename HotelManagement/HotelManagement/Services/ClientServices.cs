using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;

namespace HotelManagement { 
    public class ClientServices
    {
        public Client_tbl validate(string phoneNr, string pass)
        {
            using (HoteldbEntities111 db = new HoteldbEntities111())
            {
                return db.Client_tbl.Where(x => x.ClientPhone == phoneNr && x.Password == pass).FirstOrDefault();
            }
        }

        public void AddClient(Client_tbl client)
        {
            using (HoteldbEntities111 db = new HoteldbEntities111())
            {
                db.Client_tbl.Add(client);
                db.SaveChanges();
            }
        }

        public List<String> GetClientsNames()
        {
            using (HoteldbEntities111 db = new HoteldbEntities111())
            {
                return db.Client_tbl.Select(x => x.ClientName).ToList();
            }
        }

        public List<Client_tbl> GetClientsByName(string name)
        {
            using (HoteldbEntities111 db = new HoteldbEntities111())
            {
                return db.Client_tbl.Where(x => x.ClientName == name).ToList();
            }
        }

        public List<Client_tbl> GetClients()
        {
            using (HoteldbEntities111 db = new HoteldbEntities111())
            {
                return db.Client_tbl.ToList<Client_tbl>();
            }
        }

        public Client_tbl GetClientById(int id)
        {
            using (HoteldbEntities111 db = new HoteldbEntities111())
            {
                return db.Client_tbl.Where(x => x.ClientId == id).FirstOrDefault();
            }
        }

        public Client_tbl GetClientByPhone(String nr)
        {
            using (HoteldbEntities111 db = new HoteldbEntities111())
            {
                return db.Client_tbl.Where(x => x.ClientPhone == nr).FirstOrDefault();
            }
        }
        public void DeleteClient(Client_tbl model)
        {
            using (HoteldbEntities111 db = new HoteldbEntities111())
            {
                var entity = db.Entry(model);
                if (entity.State == EntityState.Detached)
                    db.Client_tbl.Attach(model);
                db.Client_tbl.Remove(model);
                db.SaveChanges();
            }
        }

        public void UpdateClient(Client_tbl model)
        {
            using (HoteldbEntities111 db = new HoteldbEntities111())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    };
}
