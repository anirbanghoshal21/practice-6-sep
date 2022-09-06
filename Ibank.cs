using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public interface Ibank
    {
        public static int bal = 0;

        public int balance
        {
            get { return bal; }
            set { bal = value; }
        }
        public void Calculateinterest()
        {
           
        }

    }
}

