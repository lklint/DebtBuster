using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebtBuster.Core
{
    public class Debt
    {
        public decimal Interest { get; set; }
        public DateTime TermEnd { get; set; }
        public DateTime TermStart { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
