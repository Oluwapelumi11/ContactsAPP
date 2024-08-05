using ContactsAPP.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAPP
{
    internal interface IContactManager
    {
        void SaveContact(Person person);
        void DeleteContact(int id);
        void UpdateContact(Person person);

        IEnumerable<Person> GetContacts(int userId);
        Person? GetContactbyId(int ContactId);
    }
}
