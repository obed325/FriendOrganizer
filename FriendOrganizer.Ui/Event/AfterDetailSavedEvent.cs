using Prism.Events;
using System;
using System.Collections.Generic;


namespace FriendOrganizer.Ui.Event
{
    public class AfterDetailSavedEvent :PubSubEvent<AfterDetailSavedEventArgs>
    {
    }

    public class AfterDetailSavedEventArgs
    {
        public int Id { get; set; }
        public string DisplayMember { get; set; }
        public string ViewModelName { get; set; }
    }
}
