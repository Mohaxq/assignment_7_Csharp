using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign7
{
    internal class Derived1 : Base
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("message from Derived");
        }
    }
}
