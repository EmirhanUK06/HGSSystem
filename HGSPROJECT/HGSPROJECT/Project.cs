using HGSPROJECT.Entity;
using HGSPROJECT.OGSManagement;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGSPROJECT
{
    public class Project
    {
        public static void Main()
        {
            Car car = new Car();
            Bus bus = new Bus();
            Van van = new Van();

            Payment payment = new Payment();
            payment.Payments(123456789);
            payment.Payments(012345678);
            payment.Payments(024568123);

            Management management = new Management(payment);

            string passVehicleList = management.GetPassVehicles();

            decimal totalVallet = management.GetTotalVallet();

            string dailyTotalVallet = management.GetDailyTotalVallet();

            Console.WriteLine("\n\n");
            Console.WriteLine("Toplam hasılat: {0}", totalVallet);
            Console.WriteLine("\n\n");
            Console.WriteLine("Günlük hasılat: \n{0} \n", dailyTotalVallet);
            Console.WriteLine("Kapatmak için bir tuşa basınız.");
            Console.ReadKey();
        }
    }
}
