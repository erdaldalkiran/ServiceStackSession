using System;

namespace Web.Service
{
    using Model;

    public class StatusService : ServiceBase
    {
        public object Any(StatusQuery request)
        {
            throw new NotImplementedException("Test");
            var trackedData = UserSession.GetTrackedData(request.Date) ?? new TrackedData { Goal = 300, Total = 0 };
            return new StatusResponse { Goal = trackedData.Goal, Total = trackedData.Total };
        }
    }
}