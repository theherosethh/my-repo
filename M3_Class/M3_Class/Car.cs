using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace M3_Class
{
    internal class Car
    {
        public string brand;
        public string model;  //field or data type
        public int year;     //field or data type

        public void ShowInfo() //Method of Display
        {
            Console.WriteLine($"Brand: {brand}, Model: {model}, Year: {year}");
        }
    }
}
