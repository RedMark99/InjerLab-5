using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjenerLab5
{
    class History
    {
        internal String Operation;
        internal DateTime Date;
        internal int Amount;

        public History(String Operation, DateTime Date, int Amount) 
        {
            this.Operation = Operation;
            this.Date = Date;
            this.Amount = Amount;
        }
    }
}
