using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contact.Models;
using contact.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace contact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

   
    public class ContactController : ControllerBase
    {
        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }
        
        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }
    }
}
