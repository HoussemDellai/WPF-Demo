using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Mocks;
using WpfDemo.ViewModels;

namespace UnitTests
{
    [TestClass]
    public class ViewModelTests
    {
        [TestMethod]
        public async Task InitializeDataTest()
        {
            //Arrange
            // Could also use Mock framework
            var service = new DataServiceMock();
            var vm = new MainViewModel(service);

            // Act
            await vm.InitializeDataAsync();
            var expected = await service.GetFullname();

            // Assert
            Assert.AreEqual(expected, vm.Fullname);
        }
    }
}
