using System.Globalization;
using Web.Model;

namespace Web.Service
{
    public class EntryService : ServiceBase
    {
        public object Any(Entry request)
        {
            var trackedData = UserSession.GetTrackedData(request.Time.Date) ?? new TrackedData { Goal = 300 };
            trackedData.Total += request.Amount;

            UserSession.SetTrackedDate(request.Time, trackedData);
            return new EntryResponse { Id = 1 };
        }
    }

    public class TrackedData
    {
        public int Total { get; set; }

        public int Goal { get; set; }
    }
}