using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PersonalFinanceApp
{
    public class ContactModel
    {
        public void SaveContact(String firstName, String lastName, int contactNo)
        {
            Contact contact = new Contact();
            contact.firstName = firstName;
            contact.lastName = lastName;
            contact.contactNo = contactNo;

            // Save to Database via a new thread;
            var newThread = new Thread(() => insertIntoDatabase(contact));
            newThread.IsBackground = true;
            newThread.Start();
        }

        private static void insertIntoDatabase(Contact contact)
        {
            myFinanceDbFileEntities db = new myFinanceDbFileEntities();
            db.Contacts.AddObject(contact);
            try
            {
               db.SaveChanges();
               Thread.Sleep(500);
            }
               catch (Exception)
            {
               throw new Exception();
            }
        }
    }
}
