using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //creat a few Person objects
            Person person1 = new Person
            {
                FirstName = "Kirsi", LastName ="Mainio", SocialSecurityNumber = "123456789-1234"
            };
            Person person2 = new Person { FirstName = "Varus", LastName = "Mies", SocialSecurityNumber = "999999999-666A" };
            Person person3 = new Person { FirstName = "Jukka", LastName = "Sukkula", SocialSecurityNumber = "021278-199A" };

            // create a Persons object
            Persons myFriends = new Persons();

            //add person objects to persons collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // get one person from Persons collection
            Person person4 = myFriends.GetPerson(100);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            } else
            {
                Console.WriteLine("Person not found :'(");
            }

            // print collection
            myFriends.PrintCollection();

            //find person
            string sotu = "999999999-666A";
            Console.WriteLine("Find sotu : " + sotu);
            Person person5 = myFriends.FindPerson(sotu);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                //kirjotusta
                Console.WriteLine("Cant find that person :((");
            }

        }
    }
}
