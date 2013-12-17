using System;
using ServiceStack;
using Web.Model;

namespace Client
{
    class Program
    {
        static void Main()
        {
            var amount = -1;

            while (amount != 0)
            {
                amount = int.Parse(Console.ReadLine());

                var client = new JsonServiceClient("http://localhost:5841");
                var response = client.Send<EntryResponse>(new Entry { Amount = amount, Time = DateTime.Now });

                Console.WriteLine("Response: {0}", response);
            }
        }
    }
}
