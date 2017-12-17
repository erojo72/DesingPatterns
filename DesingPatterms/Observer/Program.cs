using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteObservable observable = new ConcreteObservable();
            var observer1 = new ConcreteObserver(observable);
            var observer2 = new ConcreteObserver(observable);
            var observer3 = new ConcreteObserver(observable);

            observable.SetState(1);
            observable.SetState(2);

            observable.removeObserver(observer3);

            observable.SetState(3);

            Console.ReadLine();

        }
    }
}
