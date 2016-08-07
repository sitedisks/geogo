namespace geogo.test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Threading.Tasks;
    using geogo.Service;
    using geogo.Interface;

    [TestClass]
    public class ServiceTest
    {
        IgeogoDbService _srv = new geogoDbService();

        [TestMethod]
        public async Task TestAllPins()
        {
            var pins = await _srv.ConnectionTest();
            Assert.IsNotNull(pins);
        }
    }
}
