using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            //main program
            Console.WriteLine("Select Program");
            Console.WriteLine("1. water Calculator");
            Console.WriteLine("2. Oil Calculator");
            Console.WriteLine("3. classified body");
            Console.Write("Enter Choice : ");
            var input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Water for drink calculator !!");
                    Program.water();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Oil calculator !!");
                    Program.Oil();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Classified Body !!");
                    Program.classified_body();
                    break;
                default:
                    Console.WriteLine("Program is Close");
                    break;
            }
            Console.WriteLine("Please any key to end process... ");
            Console.ReadKey();
            
        }

        static void classified_body()
        {

            string classified = "";

            Console.Write("Enter my name = ");
            var name = Console.ReadLine();
            Console.Write("Enter Heigh in Centimeter = ");
            var heigh = int.Parse(Console.ReadLine());
            Console.Write("Enter Weight in kilograms = ");
            var weight = int.Parse(Console.ReadLine());

            if (heigh >= 165 && weight >= 70)
            {
                classified = "Tall and Heavy";
            }
            else if (heigh >= 165 && weight <= 70)
            {
                classified = "Tall and Light";
            }
            else if (heigh <= 165 && weight >= 70)
            {
                classified = "Short and Heavy";
            }
            else if (heigh <= 165 && weight <= 70)
            {
                classified = "Short and Light";
            }

            Console.WriteLine($"Person is classified = {classified}");
        }

        static void Oil()
        {
            Console.WriteLine("input distance ==>");
            var distance = double.Parse(Console.ReadLine());

            var resultFiore = 0.25 + ((distance - 1) / 12);
            var resultScoopyI = 0.13 + ((distance - 1) / 10);

            if (resultFiore < resultScoopyI)
            {
                Console.WriteLine("Comparison resilt ==>  True");
            }
            else
            {
                Console.WriteLine("Comparison resilt ==>  False");
            }
        }

        static void water()
        {
            /*โจทย์
                บึงแก่นนคร มีระยะทางรวม 5.7 กิโลเมตร
                ใน 1 รอบ เราจะกินน้ำ 2 ขวด 
                น้ำราคาขวดละ 7 บาท
                ถ้าเราวิ่ง โดยระบุจำนวนรอบเอง จงหาจำนวนเงินที่ต้องจ่ายค่าน้ำ*/
                
            Console.Write("Enter the number of laps in your run : ");
            var round = (int.Parse(Console.ReadLine()));

            var result = (round * 2) * 7;

            Console.WriteLine("The money to pay your water bill ==> {0}", result);

        }
    }
}
