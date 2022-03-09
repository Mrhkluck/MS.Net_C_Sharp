using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ConsoleDemoApp.LinqExp
{
    internal class HashTableDemo
    {
        static void Main(string[] args)
        {
           Hashtable persons = new Hashtable();
            persons.Add("Rashid", 8343344342);
            persons.Add("Mrhk", 8343344341);
            persons.Add("Lucy", 8343344342);
            persons.Add("Lucky", 8343344343);
            persons.Add("Humayun", 8343344344);
            persons.Add("Aamir", 8343344345);
            persons.Add("Khan", 8343344345);
            //  persons.Add("Aamir", 8343344345);
            //persons.Add(null, 8343344346);// key cannot be null and cannot have duplicate but value can be same

            //for iterator we can use foreach or enumerator
            Console.WriteLine("Person Data using Foreach and DictionaryEntry");
            //foreach(string person in persons)
            foreach (DictionaryEntry person in persons)
            {
                Console.WriteLine(person.Key+"=>"+person.Value);
            }

            Console.WriteLine("Person Data using Iterator");

            IDictionaryEnumerator iterator= persons.GetEnumerator();
            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Key+"=>"+iterator.Value);
            }

            //Getting keys we can only access key or value either one but in Dictionary we can access both
            ICollection names= persons.Keys;
            IEnumerator keys= names.GetEnumerator();
            Console.WriteLine("Names are: ");
            while (keys.MoveNext())
            {
                Console.WriteLine(keys.Current);
            }

        }
    }
}
