using System;
using System.Collections.Generic;

namespace _20_10_2021
{
    public class AccidentVaseData : Subject
    {
        private int cost;
        private string infor;

        public AccidentVaseData(int cost, string infor)
        {
            this.cost = cost;
            this.infor = infor;
            observers = new List<Observer>();
        }

        public int Cost
        {
            get { return cost; }
            set 
            {
                cost = value;
            }
        }
        public string Infor
        {
            get => infor;
            set => infor = value;
        }

        public override void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public override void DeleteObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public override void Update()
        {
            foreach(Observer observer in observers)
            {
                observer.Update();
            }
        }

        public void ChangePride()
        {
            Update();
        }

        public override string ToString()
        {
            return "Cost: " + cost + " Information: " + infor;
        }
    }
}