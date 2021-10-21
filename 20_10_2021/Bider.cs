using System;

namespace _20_10_2021
{
    public class Bidder : Observer
    {
        public Bidder(AccidentVaseData vaseData)
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
            System.Console.WriteLine("Cost: $" + VaseData.Cost);
            System.Console.WriteLine("Information: " + VaseData.Infor);
            System.Console.WriteLine("Information: 111111111");
        }
    }
}