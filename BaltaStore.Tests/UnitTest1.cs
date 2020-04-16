using BaltaStore.Domain;
using BaltaStore.Domain.StoreContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer(
                "André",
                "Baltieri",
                "12345",
                "hello@balta.io", 
                "19999999",
                "Rua Lalala");
            
            var order = new Order(c);
            
        }
    }
}
