using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<FriendOrganizerDbContext> _contextCreator;

        public FriendDataService(Func<FriendOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }
        public async Task <List<Friend>> GetAllAsync()
        {
            //TODO: Load data from databases
            /* yield return new Friend { FirstName = "Zobad", LastName = "Mahmood" };
             yield return new Friend { FirstName = "Farwa", LastName = "Mahmood" };
             yield return new Friend { FirstName = "Arfa", LastName = "Mahmood" };
             */
            using (var ctx = _contextCreator())
            {
                return await ctx.Friends.AsNoTracking().ToListAsync();
            }
        }
    }
}
