using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3MonLabTask3___Bond_Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int cityCode1;
            int placeCode2;
            int dayCode3;
            int timeCode4;
            int userCode5;

            Console.Write("Enter first pair of digits: ");
            cityCode1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second pair of digits: ");
            placeCode2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third pair of digits: ");
            dayCode3 = int.Parse(Console.ReadLine());

            Console.Write("Enter fourth pair of digits: ");
            timeCode4 = int.Parse(Console.ReadLine());

            userCode5 = cityCode1 + placeCode2 + dayCode3 + timeCode4;

            if (cityCode1 == 11)
                Console.Write("London ");
            else if (cityCode1 == 37)
                Console.Write("Paris ");
            else if (cityCode1 == 78) 
                Console.Write("Havanna ");
            else if (cityCode1 == 94)
                Console.Write("Moscow ");
            else
                Console.Write("Dummy code: no meeting required");


            if (placeCode2 == 19) 
                Console.Write("Town Hall ");
            else if (placeCode2 == 21)
                Console.Write("Airport ");
            else if (placeCode2 == 35)
                Console.Write("Central Railway Station ");
            else if (placeCode2 == 55)
                Console.Write("Embassy ");
            else
                Console.Write("Dummy code: no meeting required");


            if (dayCode3 == 34)
                Console.Write("Monday ");
            else if (dayCode3 == 64)
                Console.Write("Wednesday ");
            else if (dayCode3 == 90)
                Console.Write("Saturday ");
            else
                Console.Write("Dummy code: no meeting required");


            if (timeCode4 == 15)
                Console.Write("1030");
            else if (timeCode4 == 84)
                Console.Write("1445");
            else if (timeCode4 == 86)
                Console.Write("2250");
            else if (timeCode4 == 95)
                Console.Write("0020");
            else
                Console.Write("Dummy code: no meeting required");

 
            Console.ReadKey();
        }
    }
}
