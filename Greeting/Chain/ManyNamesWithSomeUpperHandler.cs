using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting.Chain
{
    public class ManyNamesWithSomeUpperHandler : GreetingHandler
    {
        protected override string Greet(params string[] names)
        {
            string result = "Hello, ";
            List<string> upper = GetUppercase(names);
            List<string> lower= GetLowercase(names);
            while (lower.Count > 2)
            {
                result += $"{lower.First()}, ";
                lower.RemoveAt(0);
            }
            result += $"{lower.First()} and {lower.ElementAt(1)}.";
            foreach (var item in upper)
            {
                result += $" AND HELLO {item}!";
            }
            return result;
        }

        public override string Handle(params string[] names)
        {
            if (names.Length > 2 && ContainsUppercase(names))
                return Greet(names);
            else return Next.Handle(names);
        }

        private List<string> GetUppercase(params string[] names) => names.Where(x => isUppercase(x)).ToList();
        private List<string> GetLowercase(params string[] names) => names.Where(x => !isUppercase(x)).ToList();
    }
}
