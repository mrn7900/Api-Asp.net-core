using test2.Models;

namespace test2.Repository
{
    public interface IContactUsTbl
    {
        public IEnumerable<ContactUsTbl>GetContactUsTbls();
        public ContactUsTbl GetContactUsTbl(int id);
        public void CreateContactUs(ContactUsTbl contactus);
        public void UpdateContactUs(int id,ContactUsTbl contactus);
        public void DeleteContactUs(int id);
      
    }
}
