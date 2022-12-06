using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Account
    {
        int sum;
        int percentage;
        public delegate void AccountStateHandlerDelegate(string message);
        AccountStateHandlerDelegate del;
        public event AccountStateHandlerDelegate Withdrowed;
        public event AccountStateHandlerDelegate Added;

        public Account(int sum, int percentage)
        {
            this.sum = sum;
            this.percentage = percentage;
        }
        public int CurrentSum { get { return sum; } }
        public int Percentage { get { return percentage; } }

        public void Withdraw(int inputSum)
        {
            if (inputSum <= sum)
            {
                sum -= inputSum;
            }
            if (Withdrowed != null)
            {
                Withdrowed("The amount " + sum + "was withdrawn from the account");           
            }
            else if (Withdrowed != null)
            {
                Withdrowed("There isn't enough money in the account");
            }

        }
        public void Put(int inputSum)
        {
            sum += inputSum;
            //if (Added != null)
            //{
            //    Added(this, new AccountEventArgs("Received on the account " + sum, sum));
            //}
        }
        public void RegisterHandler(AccountStateHandlerDelegate inputDel) 
        {
            del = inputDel;
        }
       
    }
}
