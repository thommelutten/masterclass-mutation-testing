using ContactBook.Interfaces;
using ContactBook.Model;

namespace ContactBook.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InMemoryPersonRepository_GetAllEmpty_Success()
        {
            IContactRepository repository = new InMemoryContactRepository();
            Assert.That(repository.GetAll().Count, Is.EqualTo(0));
        }

        [Test]
        public void InMemoryPersonRepository_Add_Success()
        {
            IContactRepository repository = new InMemoryContactRepository();

            Contact contact = new()
            {
                FirstName = "Frodo Baggins",
                LastName = "",
                Address = "1 Bagshot Row, Bag End, Hobbiton"
            };

            repository.Add(contact);
            
            IEnumerable<Contact> contacts = repository.GetAll();
            Assert.That(contacts, Has.Exactly(1).EqualTo(contact));
        }

        [Test]
        public void InMemoryPersonRepository_GetById_Success()
        {
            IContactRepository repository = new InMemoryContactRepository();

            Contact contact = new()
            {
                FirstName = "Frodo Baggins",
                LastName = "",
                Address = "1 Bagshot Row, Bag End, Hobbiton"
            };

            int id = repository.Add(contact);

            Assert.That(id, Is.EqualTo(1));
            Assert.That(repository.GetById(id), Is.EqualTo(contact));
        }

        [Test]
        public void InMemoryPersonRepository_GetById_ReturnNull()
        {
            IContactRepository repository = new InMemoryContactRepository();
            Assert.That(repository.GetById(1), Is.Null);
        }
    }
}