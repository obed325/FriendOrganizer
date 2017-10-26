using System.Collections.Generic;
using FriendOrganizer.Model;

namespace FriendOrganizer.Ui.Data
{
    public interface IFriendDataService
    {
        IEnumerable<Friend> GetAll();
    }
}