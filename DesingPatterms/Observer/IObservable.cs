﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IObservable
    {
        void registerObserver(IObserver observer);

        void removeObserver(IObserver observer);

        void notifyObservers();
    }
}
