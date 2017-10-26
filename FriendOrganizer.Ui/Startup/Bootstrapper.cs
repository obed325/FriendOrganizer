using Autofac;
using FriendOrganizer.Ui.Data;
using FriendOrganizer.Ui.ViewModel;

namespace FriendOrganizer.Ui.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<FriendDataService>().As<IFriendDataService> ();

            return builder.Build();
        }
    }
}
