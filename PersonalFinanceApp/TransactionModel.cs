using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalFinanceApp
{
    public class TransactionModel
    {
        public void SaveTransaction(List<Transaction> transactionList)
        {
            myFinanceDbFileEntities db = new myFinanceDbFileEntities();

            foreach (Transaction tx in transactionList)
            {
                var userQuery = from id in db.Users select id;
                var userRow = userQuery.ToList();

                //var contactQuery = (from c in db.Contacts where c.Id == tx.ContactId select c).FirstOrDefault<Contact>(); 

                Transaction newTransaction = new Transaction();
                newTransaction.date = tx.date;
                newTransaction.amount = tx.amount;
                newTransaction.type = tx.type;
                newTransaction.occurrence = tx.occurrence;
                newTransaction.description = tx.description;
                newTransaction.UserId = userRow[0].Id;
                db.Transactions.AddObject(newTransaction);
            }
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception();
            }
        }
    }
}
