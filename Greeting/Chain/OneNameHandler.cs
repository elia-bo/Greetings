using Greeting.Chain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    public class OneNameHandler : GreetingHandler
    {

        protected override string Greet(params string[] name)
        {
            if (ContainsUppercase(name))
                return $"HELLO, {name[0]}!";
            else return $"Hello, {name[0]}.";
        }

        
        public override string Handle(params string[] names)
        {
            if (names.Length == 1)
            {
                return Greet(names[0]);
            }
            throw new Exception("Something wrong in the chain");
        }

        
    }
}
