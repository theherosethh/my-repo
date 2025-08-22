using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	internal class T03_Errors
	{
		 static void Main(string[] args)
        {
            var book = new { Title = "C# Basics", Author = "Saroeun", Pages = 200 }; // ❌ ERROR: missing 'new' keyword

            Console.WriteLine("Title: " + book.Title);
            Console.WriteLine("Author: " + book.Author);
            Console.WriteLine("Pages: " + book.Pages);

            //book.Pages = 250; // ❌ ERROR: cannot modify anonymous type
        }
	}
}
