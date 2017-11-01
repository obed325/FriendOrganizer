using Prism.Events;
using System;
using System.Collections.Generic;


namespace FriendOrganizer.UI.Event
{
    public class AfterFriendSavedEvent : PubSubEvent<AfterFriendSavedEventArgs>
    {

    }

    public class AfterFriendSavedEventArgs
    {
        public int Id { get; set; }
        public string DispalyMember { get; set; }
    }
}
