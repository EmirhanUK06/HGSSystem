using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGSPROJECT.OGSManagement
{
    public class Management
    {
        private Payment payment;

        public Management(Payment _payment)
        {
            payment = _payment;
        }

        public string GetPassVehicles()
        {
            string passVehicles = string.Join(",", payment.PassVehicles);

            return passVehicles;
        }

        public decimal GetTotalVallet()
        {
            return payment.Vallet;
        }

        public string GetDailyTotalVallet()
        {
            var result = payment.DailyPayments.GroupBy(x => x.Time).Select(x => x.Key.ToString("dd.MM.yyyy") + " 'de " + x.Sum(a => a.Vallet) + " TL hasılat yapıldı.");

            return string.Join("\n", result);
        }
    }
}
