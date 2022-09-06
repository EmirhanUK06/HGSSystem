using HGSPROJECT.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGSPROJECT.OGSManagement
{
    public class Payment
    {
        public decimal Vallet { get; set; }

        public List<long> PassVehicles { get; set; }

        public List<DailyPayment> DailyPayments { get; set; }
        public Payment()
        {
            PassVehicles = new List<long>();

            DailyPayments = new List<DailyPayment>();
        }
        public void Payments(int HgsNumber)
        {
            Car car = new Car();
            Bus bus = new Bus();
            Van van = new Van();
            //Car sınıfı için
            car.Owner = "Car Owner";
            car.HgsNumber = 123456789;
            car.Balance = 200;
            //Bus sınıfı için
            bus.Owner = "Bus Owner";
            bus.HgsNumber = 012345678;
            bus.Balance = 200;
            //Van sınıfı için
            van.Owner = "Van Owner";
            van.HgsNumber = 024568123;
            van.Balance = 200;


            if (car.HgsNumber == HgsNumber && car.Balance >= 40)
            {
                float exbalance = car.Balance;
                car.Balance -= 40;
                Text(HgsNumber, exbalance, car.Balance);
                Vallet += 40;
                car.Time = DateTime.Now;
                DailyPayments.Add(new DailyPayment()
                {
                    Time = car.Time,
                    Vallet = 40,
                });
            }
            else if (van.HgsNumber == HgsNumber && van.Balance >= 70)
            {
                float exbalance = van.Balance;
                van.Balance -= 70;
                Text(HgsNumber, exbalance, van.Balance);
                Vallet += 70;
                van.Time = DateTime.Now;
                DailyPayments.Add(new DailyPayment()
                {
                    Time = van.Time,
                    Vallet = 70,
                });
            }
            else if (bus.HgsNumber == HgsNumber && bus.Balance >= 100)
            {
                float exbalance = bus.Balance;
                bus.Balance -= 100;
                Text(HgsNumber, exbalance, bus.Balance);
                Vallet += 100;
                bus.Time = DateTime.Now;
                DailyPayments.Add(new DailyPayment()
                {
                    Time = bus.Time,
                    Vallet = 100,
                });
            }
            else
            {
                Console.WriteLine("Kaçak geçiş tespiti -> " + HgsNumber);
            }

        }

        public void Text(int HgsNumber, float exbalance, float newbalance)
        {
            Console.WriteLine("Araç geçişi -> " + HgsNumber + " Eski Bakiye: " + exbalance + " Yeni Bakiye: " + newbalance);
        }
    }
}
