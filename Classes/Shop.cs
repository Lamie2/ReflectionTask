using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Shop
    {
        List<Order> Orders = new List<Order>();
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        public int GetOrdersAvg()
        {
            int sum = 0;
            foreach (var item in Orders)
            {
                sum += item.TotalAmount;
            }
            return sum / Orders.Count;
        }

        public void RemoveOrderByNo(int no)
        {
            foreach (var item in Orders)
            {
                Orders.RemoveAll(x => x.No == no);
            }
        }

        public List<Order> FilterOrderByPrice(int min, int max)
        {
            return Orders.FindAll(x => x.TotalAmount > min && x.TotalAmount < max);           
        }
         
        //public int GetOrdersAvg(DateTime time)
        //{
            
        //}

    }
}
