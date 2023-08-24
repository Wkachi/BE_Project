
using ContactUsCore;
using ContactUsDb.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace ContactUsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactUsController : ControllerBase
    {



        public ContactUsController(ContactUsRepository contactUsRepository)
            {
                _contactUsRepository = contactUsRepository;
            }

        public ContactUsRepository Post_contactUsRepository()
        {
            return _contactUsRepository;
        }

        [HttpGet(Name = "GetContactUs")]
        public IEnumerable<ContactUs> Get()
        {
            var contactUs = _contactUsRepository.GetAll();
            return (IEnumerable<ContactUs>)contactUs;
        }

        public ContactUsRepository Get_contactUsRepository()
        {
            return _contactUsRepository;
        }


        //[HttpPost(Name = "Create-Contact")]
        //public IActionResult CreateContact(string firstName, string lastName, string phoneNumber, string message, ContactUsRepository _contactUsRepository)
        //{
        //    var contactUs = new ContactUs
        //    {
        //        FirstName = firstName,
        //        LastName = lastName,
        //        PhoneNumber = phoneNumber,
        //        Message = message
        //    };
        //      _contactUsRepository.Add(contactUs);
        //      return Ok(contactUs.FirstName);
        //}



        private readonly ContactUsRepository _contactUsRepository;


    }
}