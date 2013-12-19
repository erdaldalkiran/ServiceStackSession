using Funq;
using ServiceStack;
using ServiceStack.Auth;
using ServiceStack.Caching;
using Web.Model;
using Web.Service;

namespace Web
{
    public class ProteinTrackerAppHost : AppHostBase
    {
        public ProteinTrackerAppHost()
            : base("Protein Tracker", typeof(EntryService).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            Plugins.Add(new AuthFeature(() => new CustomUserSession(), 
                new IAuthProvider[]
                    {
                        new BasicAuthProvider(), 
                    }));

            container.Register<ICacheClient>(new MemoryCacheClient());
            var userRepo = new InMemoryAuthRepository();
            container.Register<IUserAuthRepository>(userRepo);

            string hash;
            string salt;
            new SaltedHash().GetHashAndSaltString("password", out hash, out salt);

            userRepo.CreateUserAuth(new UserAuth
            {
                Id = 1,
                DisplayName = "Erdal",
                Email = "erdalkiran@gmail.com",
                UserName = "erdalkiran",
                FirstName = "Erdal",
                LastName = "Dalkıran",
                PasswordHash = hash,
                Salt = salt
            }, "password");
        }
    }
}