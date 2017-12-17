using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConcreteObserver : IObserver
    {


        public ConcreteObserver(IObservable observable)
        {
            observable.registerObserver(this);
        }
        public void update(IObservable observable, object state)
        {
            //PUSH
            Console.WriteLine("New State : {0}",int.Parse(state.ToString()));

            //PULL
            Console.WriteLine("New State : {0}", ((ConcreteObservable) observable).GetState());
        }
    }
}
