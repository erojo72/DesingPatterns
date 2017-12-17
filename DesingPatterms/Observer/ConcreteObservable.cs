using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConcreteObservable : IObservable
    {
        private List<IObserver> Observers = new List<IObserver>();

        private int State { get; set; }

        public int GetState()
        {
            return State;
        }

        public void SetState(int state)
        {
            State = state;

            notifyObservers();
        }

        public void notifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.update(this,State);
            }
        }

        public void registerObserver(IObserver observer)
        {
            Observers.Add(observer);
        }
        
        public void removeObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}
