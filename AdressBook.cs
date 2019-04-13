using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Phonebook
{
    class AdressBook:IPhonebook

    {
        public Hashtable adressBook = new Hashtable();

        public object Current => throw new NotImplementedException();

        public void CreateUser(User user)


        {

            if (!adressBook.Contains(user.PersonalId))
                //Console.WriteLine("This personalid already exists!");
                adressBook.Add(user.PersonalId, user);
            Console.WriteLine("User {0} added succesfully: " + user);

        }
        public User RetrieveByPersonalId(User user)
        {
            if (!adressBook.Contains(user.PersonalId))
                Console.WriteLine("This user doesn't exist!");
            Console.WriteLine(user);
            return (user);
        }
        public void UpdateUser(User user)
        {
            if (!adressBook.Contains(user.PersonalId))
                Console.WriteLine("This user already exists!");
            Console.WriteLine(user);
        }
        public void DeleteUser(User user)
        {
            if (!adressBook.Contains(user.PersonalId))
                Console.WriteLine("This user does not exist!");
            adressBook.Remove(user.PersonalId);
            Console.WriteLine("user {0} has been deleted" + user.PersonalId);
        }




        public List<User> SearchByPersonalId(User user)
        {
            List<User> userList = new List<User>();
            foreach(User u in adressBook.Values)
            {
                if (user.PersonalId == u.PersonalId)
                    userList.Add(u);
            }
            return userList;
        }
        // getting access to iterator
        public IIterator GetIterator()
        {
            return new PhonebookIterator(this);
        }


    }
}
