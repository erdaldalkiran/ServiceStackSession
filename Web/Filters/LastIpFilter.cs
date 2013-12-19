namespace Web.Filters
{
    using ServiceStack;
    using ServiceStack.Caching;
    using ServiceStack.Web;
    using Model;

    public class LastIpFilter : ResponseFilterAttribute
    {
        public ICacheClient Cache { get; set; }

        public override void Execute(IRequest req, IResponse res, object responseDto)
        {
            var status = responseDto as StatusResponse;

            if (status != null)
            {
                status.Message += "Last Ip: " + Cache.Get<string>("lastIp");
            }
        }
    }
}