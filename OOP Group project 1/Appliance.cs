﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Inheritance
{
    public abstract class Appliance
    {
        public long ItemNumber { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public double Wattage { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public bool IsAvailable()
        {
            return Quantity > 0;
        }
        public void Checkout()
        {
            if (IsAvailable())
            {
               Quantity--;
               Console.WriteLine($"Appliance {ItemNumber} has been checked out.");
            }
            else
            {
                Console.WriteLine("The appliance is not available to be checked out.");
            }
        }
    
        public virtual string FormatForFile()
        {
            string[] args =
            {
                ItemNumber.ToString(),
                Brand,
                Quantity.ToString(),
                Wattage.ToString(),
                Color,
                Price.ToString()
            };
            string s = string.Join(";", args);
            return s;
        }
        public override string ToString()
        {
            string s = $"Item Number: {ItemNumber}\n"
                    + $"Brand: {Brand}\n"
                    + $"Quantity: {Quantity}\n"
                    + $"Wattage: {Wattage}\n"
                    + $"Color: {Color}\n"
                    + $"Price: {Price}\n";
            return s;
        }

        public abstract bool Matches(string option);
    }
}
