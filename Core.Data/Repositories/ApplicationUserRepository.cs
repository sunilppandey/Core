using Core.Data.Entities;
using Core.Model.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Core.Data.Repositories
{
    public class ApplicationUserRepository : IDisposable
    {
        private ApplicationDbContext context;
        private ApplicationUserManager userManager;

        public ApplicationUserRepository()
        {
            context = DataContextFactory.GetDataContext();
            userManager = new ApplicationUserManager(new ApplicationUserStore(new ApplicationDbContext()));
        }

        public List<ApplicationUser> GetUsers()
        {
            return userManager.Users.ToList();
        }

        public Task<IdentityResult> CreateUser(ApplicationUser user, string password)
        {
            var result = userManager.CreateAsync(user, password);

            return result;
        }

        public async Task<ApplicationUser> GetUserByName(string userName)
        {
            var user = await userManager.FindByNameAsync(userName);

            return user;
        }

        public async Task<ApplicationUser> FindUser(string userName, string password)
        {
            var user = await userManager.FindAsync(userName, password);

            return user;
        }

        public void Dispose()
        {
            if (DataContextFactory.GetDataContext() != null)
            {
                DataContextFactory.GetDataContext().Dispose();
            }
        }
    }
}
