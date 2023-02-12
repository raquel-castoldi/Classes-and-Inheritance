﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Classes_And_Inheritance;

namespace Classes_And_Appliances
{
    internal class Program
    {
        static void Main(string[] args)
        {

                // Method that allows customer to purchase an appliance
                List<Appliance> appliances = ReadAppliancesFromFile("appliances.txt");

                Console.WriteLine("Enter the item number of an appliance: ");
                long itemNumber = long.Parse(Console.ReadLine());

                var foundAppliance = appliances.FirstOrDefault(a => a.ItemNumber == itemNumber);
                if (foundAppliance == null)
                {
                    Console.WriteLine("No appliance found with that item number.");
                    return;
                }

                foundAppliance.Checkout();
                WriteAppliancesToFile("appliances.txt", appliances);


                // Method to search for brand

                Console.WriteLine("Enter the brand of the appliances you want to display: ");
                string brand = Console.ReadLine();

                bool found = false;
                foreach (Appliance appliance in appliances)
                {
                    if (appliance.Brand.ToLower() == brand.ToLower())
                    {
                        Console.WriteLine(appliance.ToString());
                        found = true;
                        break;
                    }
                }
                if (found)
                { }
                else
                {
                    Console.WriteLine("No appliances brand found.");
                }

         
                // Method that displays number of random appliances

                Console.WriteLine("Enter number of appliances: ");
                int Quantity = int.Parse(Console.ReadLine());

        }  // main


        //Method that parses txt file into a list
        static Appliance CreateAppliance(string line)
        {
            Appliance a = null;
            if (line[0] == '1')
            {
                a = Refrigerator.Parse(line);
            }
            else if (line[0] == '2')
            {
                a = Vacuum.Parse(line);
            }
            else if (line[0] == '3')

            {
                a = Microwave.Parse(line);
            }
            else if (line[0] >= '4' && line[0] <= '5')

            {
                a = Dishwasher.Parse(line);
            }
            return a;
        } // CreateAppliance

        static Appliance Quantity(List<Appliance> appliances)
        {
            Appliance a = appliances.First();
                    foreach (Appliance appliance in appliances)
            {
                if (appliance.Quantity == Quantity)
                {
                    a = appliance;
                        }
                return a;
            }

            // Method to reset txt file
        } // Quantity


    } // class Program
} // namespace