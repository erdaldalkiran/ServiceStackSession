using ServiceStack;

namespace Web.Model
{
    public class StatusResponse
    {
        public int Total { get; set; }

        public int Goal { get; set; }

        public ResponseStatus ResponseStatus { get; set; }
    }
}