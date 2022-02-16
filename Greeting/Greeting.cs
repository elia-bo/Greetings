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
        private readonly IGreetingHandler nullHandler, manyNamesWithSomeUpperHandler, manyNamesHandler, twoNamesHandler, oneNameHandler;
        public Greeting()
        {
            nullHandler = new NullHandler();
            manyNamesWithSomeUpperHandler = new ManyNamesWithSomeUpperHandler();
            manyNamesHandler = new ManyNamesHandler();
            twoNamesHandler = new TwoNamesHandler();
            oneNameHandler = new OneNameHandler();

            nullHandler.SetNext(manyNamesWithSomeUpperHandler);
            manyNamesWithSomeUpperHandler.SetNext(manyNamesHandler);
            manyNamesHandler.SetNext(twoNamesHandler);
            twoNamesHandler.SetNext(oneNameHandler);
        }

        public string Greet(params string[] name) => Handle(Validator.Validate(name));

        private string Handle(params string[] names) => nullHandler.Handle(names);
    }
}
