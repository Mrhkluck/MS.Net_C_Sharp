using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day7
{
    //Implementation of IComparable interface
    class Product :IComparable<Product>
    {
        //data field
        int _Pid;
        string _Name;
        float _Price;
        string _Brand;

        //properties
        public int Pid { get => _Pid; set => _Pid = value;}

        public string Name { get => _Name; set => _Name = value; }

        public float Price { get => _Price; set => _Price = value; }

        public string Brand { get => _Brand; set => _Brand = value; }

        public int CompareTo(Product other)
        {
            //return this._Pid.CompareTo(other._Pid); // will get ascending order of data >1,<1,==0
            return other._Pid.CompareTo(this._Pid); //dscending order

        }
         //public int Pid
        //{
        //    //explicit Properties
        //    get => _Pid;
        //    set => _Pid = value;
        //}

        //overriding ToStrieng() Method to Display
        public override string ToString()
        {
            return $"Id:{_Pid}\tName:{_Name}\tBrand:{_Brand}\tPrice:{_Price}";
        }
        
    }
    class SortByNameComparer : IComparer<Product>
    {
        public int Compare(Product x,Product y)
        {
            return x.Name.CompareTo(y.Name); // no access on data field so we use properties. Name properties value cpmparison
        }
    }
    class SortByPriceComparer : IComparer
    {
        bool sortBy;
        public SortByPriceComparer(bool sortBy = false)
        {
            this.sortBy = sortBy;   
        }
        public int Compare(dynamic x, dynamic y)
        {
            if(!sortBy)
                return x.Price.CompareTo(y.Price); // Price properties value cpmparison
            else
                return x.Price.CompareTo(y.Price);
        }
    }

    //class SortByPriceCompare : IComparer //older form
    //{
    //    public int Compare(object x, object y)
    //    {
    //        return((Product)x).Price.CompareTo(((Product)y).Price);
    //    }
    //}


    internal class ArrayDemo4
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[] // to get non primitive datatype
            {
                new Product(){Pid =101,Name="Soap",Brand="Beardo",Price=18.0f},
                new Product(){Pid =108, Name="Mobile",Brand ="Poco",Price=20000.0f},
                new Product(){Pid=103, Name="Laptop",Brand="Rog Strix z",Price=60000.0f},
                new Product(){Pid=107,Name="Pen",Brand="Parker",Price=100.0f}
            };
            Console.WriteLine("Product Details");
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            Array.Sort(products);//will sort data by id

            Console.WriteLine("Sorted Products Details");
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            Array.Sort(products,new SortByNameComparer());//will sort data by Name //
            Console.WriteLine("Product Detail by name Display");
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            //Array.Sort(products, new SortByNameComparer());//will sort data by Name //
            Array.Sort(products, new SortByPriceComparer(true));//will sort data by Price in desc
            Console.WriteLine("Product Detail by Price Display");
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
