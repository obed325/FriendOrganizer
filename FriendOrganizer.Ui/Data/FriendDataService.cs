using FriendOrganizer.Model;
using System.Collections.Generic;


namespace FriendOrganizer.Ui.Data
{
    public class FriendDataService : IFriendDataService
    {

        public IEnumerable<Friend> GetAll()
        {
            //todo: Load data from real database
            yield return new Friend { FirstName = "Tomas", LastName = "Gebel", Email = "tomasagebel@fubar.com"};
            yield return new Friend { FirstName = "Börje", LastName = "Lundin", Email = "rattensriddare@fubar.com" };
            yield return new Friend { FirstName = "Quick", LastName = "Dirty", Email = "quickanddirty@fubar.com" };
            yield return new Friend { FirstName = "Rune-Örjan", LastName = "Örjansson", Email = "runeörjan@fubar.com" };
        }
    }
}
