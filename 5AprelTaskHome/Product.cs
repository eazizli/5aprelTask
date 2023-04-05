using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5AprelTaskHome
{
    internal class Product
    {
        public readonly string CreatDate;
        
        public string Name { get; set; }
        public string Description { get; set; }
        private int _price;
        public int Price

        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
       public Product(int price,string name,string description, string creatdate)
        {
            this.Price = price;
            this.Name = name;   
            this.Description = description; 
            this.CreatDate = creatdate; 
        }

        protected internal void GetDetails()
        {
            Console.WriteLine($"{Price} {Name} {Description} {CreatDate}");

        }
    }
}
