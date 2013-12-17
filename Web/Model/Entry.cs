using System;
using ServiceStack;

namespace Web.Model
{
    [Route("/entry")]
    public class Entry : IReturn<EntryResponse>
    {
        public DateTime Time { get; set; }

        public int Amount { get; set; }
    }
}