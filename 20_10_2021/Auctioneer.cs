using System;

namespace _20_10_2021
{
    public class Auctioneer : Observer
    {
        public Auctioneer(Subject vaseData)
        {
            VaseData = vaseData;
        }
        public override void Update()
        {
            System.Console.WriteLine("Update Information complete! Auctioneer");
            System.Console.WriteLine(VaseData.ToString());
        }
    }
}