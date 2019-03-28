using Microsoft.VisualStudio.TestTools.UnitTesting;
using TunesAPI.Data;
using TunesAPI.Controllers;
using TunesAPI;

namespace TunesControllerUnitTests
{
    [TestClass]
    public class UnitTest1
    {

        private readonly TunesContext _context;

        /*[TestMethod]
        public void TestAllSuggested()
        {
            //Arrange
            TunesController tc1 = new TunesController(_context);

            //Act
            var record = _context.SuggestedTunes.OrderByDescending(t => t.Count);

            //Assert
            Assert.AreEqual(1, tc1.Id);
        }*/
    }
}
