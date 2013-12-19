namespace Web.Service
{
    using ServiceStack;
    using Model;

    public abstract class ServiceBase : ServiceStack.Service
    {
        protected CustomUserSession UserSession
        {
            get
            {
                var baseSession = base.SessionAs<AuthUserSession>();
                var session = base.SessionAs<CustomUserSession>();

                return session;
            }
        }

    }
}