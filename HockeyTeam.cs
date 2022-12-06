using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public class HockeyTeam
    {
        private string name;
        private int founded;

        public HockeyTeam(string name, int founded)
        {
            this.name = name;
            this.founded = founded;
        }
        public string Name { get => name; }
        public int Founded { get => founded; }
    }
}
