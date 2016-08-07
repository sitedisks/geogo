namespace geogo.test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using geogo.service;
    using geogo.Models;
    using geogo.service.Service;
    using System.Threading.Tasks;

    [TestClass]
    public class ServiceTest
    {
        IDBAccessService _srv = new DBAccessService();

        [TestMethod]
        public async Task TestAllPins()
        {
            var pins = await _srv.GetAllPins();
            Assert.IsNotNull(pins);
        }
    }
}
