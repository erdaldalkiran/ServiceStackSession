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

            var client = new JsonServiceClient("http://localhost:5841") { UserName = "erdalkiran", Password = "password" };
            while (amount != 0)
            {
                amount = int.Parse(Console.ReadLine());

                var response = client.SendAsync(new Entry { Amount = amount, Time = DateTime.Now });

                response.ContinueWith(x => Console.WriteLine("Response: {0}", x.Result.Id));
            }

            try
            {
                var statusResponse = client.Patch(new StatusQuery { Date = DateTime.Now });
                Console.WriteLine("{0} / {1}", statusResponse.Total, statusResponse.Goal);

                Console.WriteLine("{0}", statusResponse.Message);
            }
            catch (WebServiceException exception)
            {
                Console.WriteLine(exception.ErrorMessage);
                Console.ReadLine();
            }


            Console.ReadKey();
        }
    }
}
