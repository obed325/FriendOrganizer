using Autofac;
using Prism.Events;
using FriendOrganizer.DataAccess;
using FriendOrganizer.Ui.Data.Lookups;
using FriendOrganizer.Ui.Data.Repositories;
using FriendOrganizer.Ui.ViewModel;
using FriendOrganizer.Ui.Data;
using FriendOrganizer.Ui.View.Services;

namespace FriendOrganizer.Ui.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();

            builder.RegisterType<FriendOrganizerDbContext>().AsSelf();

            builder.RegisterType<MainWindow>().AsSelf();

            builder.RegisterType<MessageDialogService>().As<IMessageDialogService>();

            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<NavigationViewModel>().As<INavigationViewModel>();
            builder.RegisterType<FriendDetailViewModel>().As<IFriendDetailViewModel>();

            builder.RegisterType<LookupDataService>().AsImplementedInterfaces();
            builder.RegisterType<FriendRepository>().As<IFriendRepository> ();

            return builder.Build();
        }
    }
}
