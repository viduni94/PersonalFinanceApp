using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceApp
{
    public class ContactModel
    {
        public void SaveContact(String firstName, String lastName, int contactNo)
        {
            myFinanceDbFileEntities db = new myFinanceDbFileEntities();
            Contact contact = new Contact();
            contact.firstName = firstName;
            contact.lastName = lastName;
            contact.contactNo = contactNo;

            db.Contacts.AddObject(contact);
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
