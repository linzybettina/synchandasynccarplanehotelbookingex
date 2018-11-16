using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace serialway
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw= Stopwatch.StartNew();
            int CarId = BookCar();
            int HotelId = BookHotel();
            int PlanId = BookPlane();
            Console.WriteLine("Finished in {0} sec", sw.ElapsedMilliseconds / 1000.00);
            Console.ReadLine();
         }
        static Random rand = new Random();

        private static int BookPlane()
        {
            Console.WriteLine("Booking Plane...");
            Thread.Sleep(5000);
            Console.WriteLine("Done with plane...");
            return rand.Next(100);
        }

        private static int BookHotel()
        {
            Console.WriteLine("Booking Hotel...");
            Thread.Sleep(8000);
            Console.WriteLine("Done with Hotel...");
            return rand.Next(100);

        }

        private static int BookCar()
        {
            Console.WriteLine("Booking Car...");
            Thread.Sleep(3000);
            Console.WriteLine("Done with Car...");
            return rand.Next(100);
        }
    }
}
