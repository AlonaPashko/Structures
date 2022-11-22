using Structures.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal struct Request
    {
        private int orderID;
        private Client client;
        private DateTime orderDate;
        private List<Article> articles;
        private double ordersAmount;

        public double OrdersAmount 
        { 
            get => ordersAmount; 
            set => ordersAmount = value;
        }

        public PayType payType;
    }
}
