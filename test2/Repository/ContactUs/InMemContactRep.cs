using test2.Models;

namespace test2.Repository
{
    public class InMemContactRep : IContactUsTbl
    {
        private List<ContactUsTbl> _contacts;
        public InMemContactRep()
        {
            _contacts = new() { new ContactUsTbl { Id = 1, FullName ="Mohammad Rahiminia", Message ="Hi and Welcome" , Email ="Rahiminiamohammad@gmail.com" , PhoneNumber = 9217584284} };
        }

        public void CreateContactUs(ContactUsTbl contactus)
        {
            _contacts.Add(contactus);
        }

        public void DeleteContactUs(int id)
        {
            var contact  = _contacts.FindIndex(x => x.Id == id);
            if (contact>-1)
            {
                _contacts.RemoveAt(contact);
            }
        }

        public ContactUsTbl GetContactUsTbl(int id)
        {
            var contact = _contacts.Where(x=>x.Id==id).FirstOrDefault();
            return contact;
        }

        public IEnumerable<ContactUsTbl> GetContactUsTbls()
        {
            return _contacts;
        }

        public void UpdateContactUs(int id, ContactUsTbl contactus)
        {
            var contact = _contacts.FindIndex(x => x.Id == id);
            if (contact>-1)
            {
                _contacts[contact] = contactus;
            }
        }
    }
}
