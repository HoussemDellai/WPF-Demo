using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using WpfDemo.Services;

namespace WpfDemo.ViewModels
{
    public class MainViewModelMock : INotifyPropertyChanged
    {
        //private readonly IDataService _dataService;
        private string _fullname;
        private string _jobTitle;

        public string Fullname
        {
            get => _fullname;
            set
            {
                _fullname = value;
                OnPropertyChanged();
            }
        }

        public string JobTitle
        {
            get => _jobTitle;
            set
            {
                _jobTitle = value;
                OnPropertyChanged();
            }
        }

        public MainViewModelMock()
        {
            Fullname = "Adam";
        }

        //public MainViewModel(IDataService dataService)
        //{
        //    _dataService = dataService;

        //    InitializeDataAsync();
        //}

        //public async Task InitializeDataAsync()
        //{
        //    var fullname = await _dataService.GetFullname();
        //    Fullname = fullname;
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}