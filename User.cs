using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class User:IEnumerable
    {
        private Hashtable adressBook = new Hashtable();
        public int personalid;
        public string firstname;
        public string lastname;
        public string adress;
        public string phonenumber;

        public int PersonalId
        {
            get { return personalid; }
            set { personalid = value; }
        }

        public string FirstName

        {

            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public string PhoneNumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }
        // constructor

        public User(int personalId, string firstName, string lastName, string adress, string phoneNumber)


        {
            this.PersonalId = personalId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
        }

        public User()
        {
        }

        public override string ToString()

        {
            return "PersonalId : " + this.PersonalId +  " " + this.FirstName + " " + this.LastName + " " + this.Adress + " " + this.PhoneNumber;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)adressBook).GetEnumerator();
        }
    }

}
