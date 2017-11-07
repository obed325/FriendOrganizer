using System.Threading.Tasks;

namespace FriendOrganizer.Ui.ViewModel
{
    public interface IDetailViewModel
    {
        Task LoadAsync(int? Id);
        bool HasChanges { get; set; }
    }
}