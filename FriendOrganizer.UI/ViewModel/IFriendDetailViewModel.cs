using System.Threading.Tasks;

namespace FriendOrganizer.Ui.ViewModel
{
    public interface IFriendDetailViewModel
    {
        Task LoadAsync(int? friendId);
        bool HasChanges { get; set; }
    }
}