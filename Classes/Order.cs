using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Order
    {
        public Order()
        {
            _no++;
            No = _no;
        }
        private int _no;
        public int No { get; set; }
        public int ProductCount { get; set; }
        public int TotalAmount { get; set; }
        public string CreatedAt { get; set; }

    }
}
