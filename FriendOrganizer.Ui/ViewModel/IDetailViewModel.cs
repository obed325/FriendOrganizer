using System.Threading.Tasks;

namespace FriendOrganizer.Ui.ViewModel
{
    public interface IDetailViewModel
    {
        Task LoadAsync(int id);
        bool HasChanges { get; }
        int Id { get; }
    }
}