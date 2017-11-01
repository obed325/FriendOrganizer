using System.Collections.Generic;
using System.Threading.Tasks;
using FriendOrganizer.Model;

namespace FriendOrganizer.Ui.Data
{
    public interface IFriendLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetFriendLookupAsync();
    }
}