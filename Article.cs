using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structures.Enums;

namespace Structures
{
    internal struct Article
    {
        private int articleID;
        private string articleName;
        private double articlePrice;

        public ArticleType articleType;
    }
}
