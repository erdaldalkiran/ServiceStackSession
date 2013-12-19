using System;
using ServiceStack;
using Web.Filters;

namespace Web.Model
{
    [Route("/entry", "POST")]
    [Route("/entry/{Amount}/{Time}", "POST")]
    [RecordIpFilter]
    public class Entry : IReturn<EntryResponse>
    {
        public DateTime Time { get; set; }

        public int Amount { get; set; }
    }
}