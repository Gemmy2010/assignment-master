using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Phonebook
{
    class Program
    {

        public static void Main(string[] args)
        {
            Hashtable adressBook = new Hashtable();
            adressBook.Add(1, "Jemima Osoro,Gäavle,0754563254");
            adressBook.Add(2, "Sara Mimki, Mälmo, 0754546788");
            adressBook.Add(3, "Ivy Toto, Stockholm, 0754987653");

            Console.WriteLine("Hashtable");

            foreach (DictionaryEntry de in adressBook)
            {
                Console.WriteLine(de.Key + " - " + de.Value);
                Console.ReadLine();
            }

           
            
        }

    }
    
}