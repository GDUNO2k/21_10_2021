using System;

namespace _20_10_2021
{
    public abstract class Observer
    {
        protected AccidentVaseData VaseData;
        public abstract void Update();
    }
}