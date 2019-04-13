using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Phonebook
{


    class PhonebookIterator : IIterator
    {
        Hashtable adressBook = new Hashtable();
        int personalId = 0;
        private IPhonebook user;


        //Constructor
        public PhonebookIterator(IPhonebook adressBook)
        {
            personalId= 0;
        }

        /**
            Accessing the first item in the list.
         */
        public object FirstItem
        {
            get
            {
                personalId = 0;
                return adressBook[personalId];
            }
        }

        /**
            Accessing the next item in the list.
         */
        public object NextItem
        {
            get
            {
                personalId += 1;

                if (IsDone == false)
                {
                    return adressBook[personalId];
                }
                else
                {
                    return null;
                }
            }
        }

        /**
            Accessing the current item in the list.
         */
        public object CurrentItem
        {
            get
            {
                return adressBook[personalId];
            }
        }

        /**
            Reaching the end of the list.
         */
        public bool IsDone
        {
            get
            {
                if (personalId < adressBook.Count)
                {
                    return false;
                }
                return true;
            }
        }
    }
}