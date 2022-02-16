using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting.Chain
{
    public class ManyNamesHandler : GreetingHandler
    {
        protected override string Greet(params string[] names)
        {
            string result = "Hello, ";
            for (int i = 0; i < names.Length -2; i++)
            {
                result += $"{names[i]}, ";
            }
            result += $"{names[names.Length-2]} and {names[names.Length-1]}.";
            return result;
        }

        public override string Handle(params string[] names)
        {
            if (names.Length > 2)
                return Greet(names);
            else return Next.Handle(names);
        }  
    }
}
