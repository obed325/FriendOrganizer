using System.Threading.Tasks;
using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.Ui.Data.Repositories
{
    public interface IMeetingRepository : IGenericRepository<Meeting>
    {
        Task<List<Friend>> GetAllFriendsAsync();
    }
}