using System;
using System.Linq;

namespace Lession1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Input Coin bath*/
            Console.Write("input coin 10 bath ==> : ");
            var coin10 = (int.Parse(Console.ReadLine()) * 10);
            Console.Write("input coin 5 bath ==> : ");
            var coin5 = (int.Parse(Console.ReadLine()) * 5);
            Console.Write("input coin 2 bath ==> : ");
            var coin2 = (int.Parse(Console.ReadLine()) * 2);
            Console.Write("input coin 1 bath ==> : ");
            var coin1 = (int.Parse(Console.ReadLine()) * 1);

            /*Input Coin satang*/
            Console.Write("input coin 50 bath ==> : ");
            var coin50s = (int.Parse(Console.ReadLine()) * 0.50);
            Console.Write("input coin 25 bath ==> : ");
            var coin25s = (int.Parse(Console.ReadLine()) * 0.25);

            /*Calculate coin*/
            var sum = coin1 + coin2 + coin5 + coin10 + coin25s + coin50s;

            /*Split bath and satang*/
            var bath = sum.ToString().Split('.').First();
            var satang = sum.ToString("0.00").Split('.').Last();

            /*Output result*/
            Console.WriteLine($"Total money ==> {bath} bath {satang} Satang");

            Console.WriteLine("Please any key to end program...");
            Console.ReadKey();
        }
    }
}
