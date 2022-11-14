using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_Datenbank.Model
{
    public class Invoice
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Location Location { get; set; }
        public string Country { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalNetto { get; set; }
        public decimal TotalBrutto { get; set; }

    }
}
