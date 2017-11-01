using System.Threading.Tasks;

namespace FriendOrganizer.Ui.Data
{
    public interface IFriendDetailViewModel
    {
        Task LoadAsync(int friendId);
    }
}