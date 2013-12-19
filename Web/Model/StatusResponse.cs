using ServiceStack;
using Web.Filters;

namespace Web.Model
{
    [LastIpFilter(ApplyTo = ApplyTo.Patch)]
    public class StatusResponse
    {
        public int Total { get; set; }

        public int Goal { get; set; }

        public string Message { get; set; }

        public ResponseStatus ResponseStatus { get; set; }
    }
}