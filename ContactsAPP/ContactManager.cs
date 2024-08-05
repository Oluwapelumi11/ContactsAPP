using ContactsAPP.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAPP
{
    internal class ContactManager : IContactManager
    {
        private ContactsContext _context = new ContactsContext();
        public void DeleteContact(int id)
        {
            var exists = _context.People.FirstOrDefault(p => p.Id == id);
            if(exists != null)
            {
                _context.People.Remove(exists);
                _context.SaveChanges();
                Console.WriteLine($"{exists.FistName} {exists.LastName} successfully deleted");
                return;
            }
                Console.WriteLine($"failed to delete, not found on the server");
        }

        public Person? GetContactbyId(int ContactId)
        {
            var contact = _context.People.FirstOrDefault(p => p.Id==ContactId);
            if(contact != null)
            {
                return contact;
            }
            return null;
        }

        public IEnumerable<Person> GetContacts(int userId)
        {
            var persons = _context.People.Where(p => p.OwnerId == userId).ToList();
            return persons;
        }

        public void SaveContact(Person person)
        {
            _context.People.Add(person);
            _context.SaveChanges();
        }

        public void UpdateContact(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
