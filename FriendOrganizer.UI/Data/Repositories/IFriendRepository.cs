using System.Collections.Generic;
using FriendOrganizer.Model;

namespace FriendOrganizer.Ui.Data.Repositories
{
    public interface IFriendRepository:IGenericRepository<Friend>
    {
        void RemovePhoneNumber(FriendPhoneNumber model);
    }
}