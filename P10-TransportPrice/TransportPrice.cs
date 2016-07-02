using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class TransportPrice
    {
        static void Main(string[] args)
        {
        double distance = double.Parse(Console.ReadLine());
        string tariff = Console.ReadLine();
        double farePrice = 0;
        double taxiFare = 0;
        double busFare = 0;
        double trainFare = 0;
        switch (tariff)
        {
            case "day":
                taxiFare = distance * 0.79 + 0.7;
                break;
            case "night":
                taxiFare = distance * 0.9 + 0.7;
                break;
        }
        if (distance<20)
        {
            Console.WriteLine(taxiFare);
        }
        else if(distance>=20 && distance < 100)
        {            
            busFare = distance * 0.09;
            Console.WriteLine(Math.Min(taxiFare,busFare));
        }
        else
        {            
            busFare = distance * 0.09;
            trainFare = distance * 0.06;
            farePrice = Math.Min(taxiFare, busFare);
            farePrice = Math.Min(farePrice, trainFare);
            Console.WriteLine(farePrice);
        }
        }

    }

