using System;
using System.Collections.Generic;

namespace _20_10_2021
{
    public abstract class Subject
    {
        protected List<Observer> observers;

        public abstract void AddObserver(Observer observer);

        public abstract void DeleteObserver(Observer observer);

        public abstract void Update();
    }
}