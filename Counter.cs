using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Counter
    {
        public event EventHandler ThresholdReached;

        protected virtual void OnThresholdReached(EventArgs e) 
        {
            EventHandler handler = ThresholdReached;
            handler?.Invoke(this, e);
        }
        //Func<string, int> parse = [Example(1)] (s) => int.Parse(s);
    }
}
