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
        protected IGreetingHandler nullHandler, manyNamesWithSomeUpperHandler, manyNamesHandler, twoNamesHandler, oneNameHandler;
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

        public string Greet(params string[] name)
        {
            string[] names = Validator.Validate(name);
            return Handle(names);
        }

        private string Handle(params string[] names)
        {
            return nullHandler.Handle(names);
        }


    }
}
