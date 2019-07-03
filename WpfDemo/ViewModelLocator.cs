using WpfDemo.Services;
using WpfDemo.ViewModels;
using Container = SimpleInjector.Container;

namespace WpfDemo
{
    public class ViewModelLocator
    {
        private readonly Container _container;

        public MainViewModel MainViewModel => _container.GetInstance<MainViewModel>();

        public ViewModelLocator()
        {
            _container = new Container();
            _container.Register<IDataService, DataService>();
            _container.Register<MainViewModel>();
        }
    }
}
