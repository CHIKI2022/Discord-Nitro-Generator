using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nitro_Gen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Title = "CHIKI GEN - Not Copy, I Think";

            Console.Write("How Enter The Number Of Codes Do You Want : ");
            int Lines = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPress Any Key To Start !");
            Console.ReadKey();

            Console.WriteLine("");

            File.WriteAllText("Codes.txt","");

            for(int i = 0; i < (Lines);i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                string nitroCode =  "discord.gift/"+ Discord.REQ.Nitro.GenCode();
                Console.WriteLine( "[ " + (i + 1) + " ] " +  nitroCode);
                File.AppendAllText("Codes.txt",(nitroCode + "\n"));

            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n Press Any Key To Exit");
            Console.ReadKey();
        }
    }
}
