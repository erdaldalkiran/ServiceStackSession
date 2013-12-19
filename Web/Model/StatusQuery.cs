using ServiceStack;

namespace Web.Model
{
    using System;

    [Route("/status")]
    [Authenticate]
    public class StatusQuery : IReturn<StatusResponse>
    {
        public DateTime Date { get; set; }
    }
}