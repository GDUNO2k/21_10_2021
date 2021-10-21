using System;

namespace _20_10_2021
{
    public class Bidder : Observer
    {
        public Bidder(Subject vaseData)
        {
            VaseData = vaseData;
        }

        public void changePride()
        {
            VaseData.Update();
        }
        public override void Update()
        {
            System.Console.WriteLine("Update information done! Bidder");
            System.Console.WriteLine(VaseData.ToString());
        }
    }
}