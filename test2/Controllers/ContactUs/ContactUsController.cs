using Microsoft.AspNetCore.Mvc;
using test2.Models;
using test2.Repository;

namespace test2.Controllers
{
    [ApiController]
    [Route("contactus")]
    public class ContactUsController : ControllerBase
    {
        private IContactUsTbl _contactTbl;

        public ContactUsController(IContactUsTbl contactUs)
        {
            _contactTbl = contactUs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ContactUsTbl>> GetContacts()
        {
            return _contactTbl.GetContactUsTbls().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<ContactUsTbl> GetContact(int id)
        {
            var contactrec = _contactTbl.GetContactUsTbl(id);
            if (contactrec == null)
            {
                return NotFound ();
            }
            else
            {
                var contact = new ContactUsTbl
                {
                    Id = contactrec.Id,
                    FullName = contactrec.FullName,
                    Message = contactrec.Message,
                    PhoneNumber = contactrec.PhoneNumber,
                    Email = contactrec.Email
                };
               
                return contact;
            }
            
        }
        [HttpPost]
        public ActionResult CreateContactUs(ContactUsTbl contact)
        {
            var mycontact = new ContactUsTbl();
            mycontact.Id = contact.Id;
            mycontact.FullName = contact.FullName;
            mycontact.Message = contact.Message;
            mycontact.PhoneNumber = contact.PhoneNumber;
            _contactTbl.CreateContactUs(mycontact);
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdateContactUs(int id,ContactUsTbl contact)
        {
            var mycontact = new ContactUsTbl();
            mycontact.Id = contact.Id;
            mycontact.FullName = contact.FullName;
            mycontact.Message = contact.Message;
            mycontact.PhoneNumber = contact.PhoneNumber;
            _contactTbl.UpdateContactUs(id,mycontact);
            return Ok();
        }
        [HttpDelete]
        public ActionResult DeleteContactUs(int id)
        {
            var mycontact = _contactTbl.GetContactUsTbl(id);
            _contactTbl.DeleteContactUs(id);
            return Ok();

        }



    }
}
