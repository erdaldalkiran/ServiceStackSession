using System;
using System.Collections.Generic;
using ServiceStack;
using ServiceStack.Auth;
using ServiceStack.Web;
using Web.Service;

namespace Web.Model
{
    public class CustomUserSession : AuthUserSession
    {
        public Dictionary<string, TrackedData> TrackedDatas { get; set; }

        public override void OnAuthenticated(IServiceBase authService, IAuthSession session, IAuthTokens tokens, Dictionary<string, string> authInfo)
        {
            
            base.OnAuthenticated(authService, session, tokens, authInfo);

            authService.SaveSession(session);
        }

        public TrackedData GetTrackedData(DateTime date)
        {
            if (TrackedDatas == null)
                TrackedDatas = new Dictionary<string, TrackedData>();
            TrackedData trackedData = null;

            return TrackedDatas.TryGetValue(date.ToString("yyyy-MM-dd"), out trackedData) ? trackedData : null;
        }

        public void SetTrackedDate(DateTime time, TrackedData trackedData)
        {
            if (TrackedDatas == null)
                TrackedDatas = new Dictionary<string, TrackedData>();
            TrackedDatas[time.ToString("yyyy-MM-dd")] = trackedData;
        }
    }
}