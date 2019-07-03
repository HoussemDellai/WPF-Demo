using System.Threading.Tasks;

namespace WpfDemo.Services
{
    public interface IDataService
    {
        Task<string> GetFullname();
    }
}