using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DataLayer
{
    public class ContactRepository : IContactRepository
    {
        public void Delete(Contact obj)
        {
            using (ContactEntities db = new ContactEntities())
            {
                db.Contacts.Attach(obj);
                db.Contacts.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<Contact> GetAll()
        {
            using (ContactEntities db = new ContactEntities())
            {
                return db.Contacts.ToList();
            }
        }

        public Contact GetById(int id)
        {
            using (ContactEntities db = new ContactEntities())
            {
                return db.Contacts.Find(id);
            }
        }

        public Contact Insert(Contact obj)
        {
            using (ContactEntities db = new ContactEntities())
            {
                db.Contacts.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(Contact obj)
        {
            using (ContactEntities db = new ContactEntities())
            {
                db.Contacts.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
