using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Class;

class Program
{
    static void Main(string[] args)
    {
        /*
            Object Declaration
            syntax:
                   class_name 
        */

        Car obj = new Car();
        obj.brand = "Toyota";
        obj.model = "Camary";
        obj.year = 2001;
        obj.ShowInfo();
    }

}

