using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExamples
{
    public class Cycle
    {
        
        public string Brand { get; set; }
        public string Model { get; set; }
        public Gears Gear { get; set; }
        public int Price { get; set; }

        public Cycle(string brand,string model,Gears gear,int price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Gear = gear;
            this.Price = price;
        }       
    }


    public enum Gears
    {
        Sora,
        Claris,
        Tiagra,
        OneOFive,
        Ultgra

    }

    
}


