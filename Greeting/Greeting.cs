using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greeting.Chain;

namespace Greeting
{
    public class Greeting : IGreeting
    {
        protected IGreetingHandler h1, h2, h3, h4, h5;
        public Greeting()
        {
            h1 = new NullHandler();
            h2 = new ManyNamesWithSomeUpperHandler();
            h3 = new ManyNamesHandler();
            h4 = new TwoNamesHandler();
            h5 = new OneNameHandler();

            h1.SetNext(h2);
            h2.SetNext(h3);
            h3.SetNext(h4);
            h4.SetNext(h5);
        }

        public string Greet(params string[] name)
        {
            string[] names = Validator.Validate(name);
            return Handle(names);
        }

        private string Handle(params string[] names)
        {
            return h1.Handle(names);
        }


    }
}
