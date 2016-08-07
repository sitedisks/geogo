namespace geogo.test
{
    using geogo.domain.database;
    using geogo.service.Interface;
    using geogo.service.Service;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [TestClass]
    public class ServiceTest
    {
        IDBAccessService _srv = new DBAccessService();

        [TestMethod]
        public async Task TestAllPins()
        {
            IList<tbPin> pins = await _srv.GetAllPins();
            Assert.IsNotNull(pins);
        }
    }
}
