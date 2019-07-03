using System.Threading.Tasks;

namespace WpfDemo.Services
{
    public class DataService : IDataService
    {
        public async Task<string> GetFullname()
        {
            await Task.Delay(1000);
            return "Houssem";
        }
    }
}