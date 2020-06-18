using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter State Code : ");
            var statecode = Console.ReadLine();
            var stcd = statecode.ToLower();
            //if(statecode == "MT" || statecode == "mt")
            //    Console.WriteLine($"State is Montana");

            // .toLower makes it case insensative but have to input variable lowercase
            switch(stcd)
            {
                case "mt": Console.WriteLine($"State is Montana"); break;
                case "az": Console.WriteLine($"State is Arizona"); break;
                case "oh": Console.WriteLine($"State is Ohio"); break;
                default: Console.WriteLine($"State code is not found"); break;
            }
        }
    }
}
