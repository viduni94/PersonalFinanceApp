using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceApp
{
    public class EventModel
    {
        public void SaveEvent(String title, String location, DateTime date, String category, String occurrence, String user)
        {
            myFinanceDbFileEntities db = new myFinanceDbFileEntities();
            Event newEvent = new Event();

            var query = from id in db.Users select id;
            var userRow = query.ToList();

            newEvent.title = title;
            newEvent.location = location;
            newEvent.date = date;
            if (category == "Task")
            {
                newEvent.category = 1;
            }
            else
            {
                newEvent.category = 2;
            }
            newEvent.occurrence = occurrence;
            newEvent.UserId = userRow[0].Id;

            db.Events.AddObject(newEvent);
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
