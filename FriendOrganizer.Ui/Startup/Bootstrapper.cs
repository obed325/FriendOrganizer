using Autofac;
using Prism.Events;
using FriendOrganizer.DataAccess;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.ViewModel;

namespace FriendOrganizer.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var Builder = new ContainerBuilder();

            Builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();

            Builder.RegisterType<FriendOrganizerDbContext>().AsSelf();

            Builder.RegisterType<MainWindow>().AsSelf();
            Builder.RegisterType<MainViewModel>().AsSelf();
            Builder.RegisterType<NavigationViewModel>().As<INavigationViewModel>();
            Builder.RegisterType<FriendDetailViewModel>().As<IFriendDetailViewModel>();

            Builder.RegisterType<LookupDataService>().AsImplementedInterfaces();
            Builder.RegisterType<FriendDataService>().As<IFriendDataService> ();

            return Builder.Build();
        }
    }
}
