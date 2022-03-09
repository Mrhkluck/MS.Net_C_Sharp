using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.LinqExp
{
    class State
    {
        public int Id { get; set; } 
        public string StateName { get; set; }   
    }
    class City
    {
        public int Id { get; set; }
        public int CityStateId { get; set; }
        public string CityName { get; set; }
    }

    internal class StateCity
    {
        static void Main(string[] args)
        {


            IList<City> cities = new List<City>()
         {
            new City(){Id=1,CityStateId=1,CityName="Agra"},
            new City(){Id=2,CityStateId=1,CityName="Lucknow"},
            new City(){Id=8,CityStateId=2,CityName="Bhopal"},
            new City(){Id=4,CityStateId=2,CityName="Jabalpur"},
            new City(){Id=5,CityStateId=3,CityName="Bhagalpur"},
            new City(){Id=6,CityStateId=3,CityName="Kuil"}
          };

            IList<State> states = new List<State>()
           {
             new State(){Id=1,StateName="UP"},
             new State(){Id=2,StateName="MP"},
             new State(){Id=3,StateName="Bihar"}
             };

            var city = from s in states
                       join c in cities
                       on s.Id equals c.CityStateId
                       select new { c.Id, c.CityName,SID=s.Id, s.StateName };
                                                      //Alias
            Console.WriteLine("City Data");
            foreach(var c in city)
            {
                Console.WriteLine($"{c.Id}\t{c.CityName}\t{c.SID}\t{c.StateName}");
            }



            //Deferred execution

            //var city = from c in cities
            //           select c;

            //var city = from c in cities
            //           where c.CityStateId == 3
            //           select c;

            //Immediate Execution  mostly used
            //var city = cities.Where(c => c.CityStateId == 3).ToList();
            //Conversion form use here - ToList() and all

            //var city = from c in cities
            //         where c.CityStateId == 3
            //           select new {c.Id,c.CityName};
            //anonynomous type - created different types -default ka badle new field bnana ho 
            //syntex - select new {c.Id,c.CityName}

            //var city = cities.Skip(3); //Skip()

            //var city = cities.OrderBy(c=>c.Id) //OrderBy()
            //           .SkipWhile(c=>c.Id<=5); //SkipWhile()

            //var city = cities.Take(4);
            //var city = cities.TakeWhile(c => c.Id <= 8);


            //Search 
            //var city = cities.First(c=>c.Id<8);
            //Console.WriteLine($"ID:{c.Id}\tCity Name:{c.CityName}");
            //var city = cities.Single(c => c.Id == 8);
            //Console.WriteLine($"ID:{city.Id}\tCity Name:{city.CityName}");

            //var city = cities.FirstOrDefault(c => c.Id>8);
            //if(city!=null)
            //Console.WriteLine($"ID:{city.Id}\tCity Name:{city.CityName}");

            //using groupby operator
            //var stategroup = from c in cities
            //                 group c by c.CityStateId;
            //foreach (var state in stategroup)
            //{
            //    Console.WriteLine(state.Key + "=>");
            //    foreach (City c in state)
            //    {
            //        Console.WriteLine(c.Id + "=>" + c.CityStateId + "=>" + c.CityName);
            //    }
            //}



            // Console.WriteLine("Cities are:");
            //  foreach(var c in city)
            {
                //Console.WriteLine($"ID:{c.Id}\tState ID:{c.CityStateId}\tCity Name:{c.CityName}");
               // Console.WriteLine($"ID:{c.Id}\tCity Name:{c.CityName}");
            }


        }
    }
}
