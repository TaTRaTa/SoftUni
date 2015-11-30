using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1.Book_Shop
{
    class GoldenEditionBook : Book
    {
        
        public GoldenEditionBook(string title, string auther, decimal price)
            : base(title, auther, price)
        {
        }

        public override decimal Price
        {
            get { return base.Price * 1.3m; }
            protected set { base.Price = value; }
        }
    }
}
