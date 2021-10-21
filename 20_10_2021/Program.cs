using System;

namespace _20_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            AccidentVaseData data1 = new AccidentVaseData(100,"Old");
            Bidder bidder1 = new Bidder(data1);
            Bidder bidder2 = new Bidder(data1);
            Auctioneer auc1 = new Auctioneer(data1);
            data1.AddObserver(bidder1);
            data1.AddObserver(bidder2);
            data1.AddObserver(auc1);
            data1.ChangePride();
            System.Console.WriteLine("--------------");
            data1.DeleteObserver(bidder1);
            data1.ChangePride();
            System.Console.WriteLine("--------------");
            data1.Cost = 200;
            data1.ChangePride();
            System.Console.WriteLine("--------------");
            bidder1.changePride();
        }
    }
}
