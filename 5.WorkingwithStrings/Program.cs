using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.WorkingwithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will be on line");
            Console.WriteLine("Skies are Blue \n Ross are Red \n I adore you");
            Console.WriteLine("Hi, my name is \"Charlie\"");
            

            // Declarations
            string firstname = "Charlie";
            string surname = "Sekele";
            Console.WriteLine("Hi, "+firstname + " " + surname);// the + used concatinate

            Console.WriteLine("The length of the name is " + firstname.Length);//function on string

            //change name to uppercase, change surename to lowercase
            Console.WriteLine("Name in upper case "+firstname.ToUpper());
            Console.WriteLine("Surname as lower case "+surname.ToLower ());
            Console.WriteLine("Does firstname contain he "+firstname.Contains("he"));
            Console.WriteLine("Does firstname contain he " + firstname.Contains("Ch"));
            Console.WriteLine("The first letter of the name is "+firstname[0]);
            Console.WriteLine("The index of h is " + firstname.IndexOf("h"));
            Console.WriteLine("The substring from 2 "+ surname.Substring(2));
            Console.WriteLine("The substring from 0 to 4 " + surname.Substring(0, 4));

            Console.ReadLine();

        }
    }
}
