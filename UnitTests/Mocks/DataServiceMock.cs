using System.Threading.Tasks;
using WpfDemo.Services;

namespace UnitTests.Mocks
{
    public class DataServiceMock : IDataService
    {
        public async Task<string> GetFullname()
        {
            return "Adam";
        }
    }
}