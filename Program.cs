using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("---Smart Electricity Billing System---");
        Console.Write("Enter number of consumers: ");
        int N = int.Parse(Console.ReadLine());
        int domesticCount = 0;
        int commercialCount = 0;
        double totalRevenue = 0;
        double highestBill = 0;
        string highestConsumerID = "";
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine($"\nEnter data for consumer {i}");
            Console.Write("ConsumerID: ");
            string consumerID = Console.ReadLine();

            Console.Write("Units Consumed: ");
            int units = int.Parse(Console.ReadLine());

            Console.Write("Connection Type (1=Domestic, 2=Commercial): ");
            int typeCode = int.Parse(Console.ReadLine());

            if (typeCode == 1) domesticCount++;
            else commercialCount++;

            double baseCharge = 0;

            if (typeCode == 1) 
            {
                if (units <= 100)
                    baseCharge = units * 1.50;
                else if (units <= 300)
                    baseCharge = 100 * 1.50 + (units - 100) * 2.50;
                else
                    baseCharge = 100 * 1.50 + 200 * 2.50 + (units - 300) * 4.00;
            }
            else 
            {
                if (units <= 200)
                    baseCharge = units * 5.00;
                else if (units <= 500)
                    baseCharge = 200 * 5.00 + (units - 200) * 6.50;
                else
                    baseCharge = 200 * 5.00 + 300 * 6.50 + (units - 500) * 8.00;
            }

            double surcharge = baseCharge * 0.03;
            
            double penalty = 0;
            if (units > 500) penalty = 200;

            double totalBeforeDiscount = baseCharge + surcharge + penalty;

            double discount = 0;
            if (totalBeforeDiscount > 2000)
                discount = totalBeforeDiscount * 0.05;

            double finalBill = totalBeforeDiscount - discount;

            totalRevenue += finalBill;

            if (finalBill > highestBill)
            {
                highestBill = finalBill;
                highestConsumerID = consumerID;
            }

            string typeName = (typeCode == 1) ? "Domestic" : "Commercial";
            Console.WriteLine($"\nConsumerID: {consumerID}");
            Console.WriteLine($"Type: {typeName}");
            Console.WriteLine($"Units Consumed: {units}");
            Console.WriteLine($"Base Charge: {baseCharge:F2}");
            Console.WriteLine($"Surcharge: {surcharge:F2}");
            Console.WriteLine($"Penalty: {penalty:F2}");
            Console.WriteLine($"Discount: {discount:F2}");
            Console.WriteLine($"Final Bill: {finalBill:F2}");
        }

        Console.WriteLine("\n---Month-End Summary---");
        Console.WriteLine($"Total Consumers: {N}");
        Console.WriteLine($"Total Revenue: {totalRevenue:F2}");
        Console.WriteLine($"Highest Bill: {highestConsumerID} ({highestBill:F2})");
        Console.WriteLine($"Domestic Consumers: {domesticCount}");
        Console.WriteLine($"Commercial Consumers: {commercialCount}");
    }
}
