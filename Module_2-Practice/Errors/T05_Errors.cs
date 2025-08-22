using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	struct Car
	{
		public string Make;
		public string Model;
		
	}

	enum Color
	{
		Red, Blue, Green
	}
	class program
	{
        static void Main(string[] args)
        {
            Car car;
            car.Make = "Toyota"; // ❌ ERROR: fields are private by default
            car.Model = "Corolla";

			/*Color myColor = "Red";*/ // ❌ ERROR: cannot assign string to enum\
			Color myColor = Color.Red;

            Console.WriteLine($"Car: {car.Make} {car.Model}, Color: {myColor}");
        }
    }
}
