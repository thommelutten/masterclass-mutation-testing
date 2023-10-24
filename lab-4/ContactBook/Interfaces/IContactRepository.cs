using ContactBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Interfaces
{
    public interface IContactRepository
    {
        Contact GetById(int id);
        int Add(Contact contact);
        IEnumerable<Contact> GetAll();
    }
}
