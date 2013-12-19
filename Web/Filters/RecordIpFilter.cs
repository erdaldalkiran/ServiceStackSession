using ServiceStack;
using ServiceStack.Caching;
using ServiceStack.Web;

namespace Web.Filters
{
    public class RecordIpFilter : RequestFilterAttribute
    {
        public ICacheClient Cache { get; set; }

        public override void Execute(IRequest req, IResponse res, object requestDto)
        {
            Cache.Add("lastIp",req.UserHostAddress);
        }
    }
}