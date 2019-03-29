using Microsoft.VisualStudio.TestTools.UnitTesting;
using TunesAPI.Data;
using TunesAPI.Controllers;
using TunesAPI;
using System.Net.Http;
using System;
using Newtonsoft.Json;

namespace TunesControllerUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        

        private readonly TunesContext _context;

        /*public UnitTest1(TunesContext context)
        {
            _context = context;
        }*/

        HttpClient client = new HttpClient();

        /*[TestMethod]
        public void TestAllSuggested()
        {
            //Arrange
            var tc1 = new TunesController();

            //Act
            var record = _context.SuggestedTunes.OrderByDescending(t => t.Count);

            //Assert
            //Assert.AreEqual(1, tc1.Id);
        }

        [TestMethod]
        public void TestGetArtist()
        {
            var controller = new TunesController(new TunesContext());
            var item = GetDemoTune();
            var result = controller.GetSongByArtist as CreatedAtRouteNegotiatedContentResult<Tunes>;


            /*
            // Arrange
            TunesController controller = new TunesController(_context);

            controller.Request = new HttpRequestMessage
            {
                RequestUri = new Uri("http://http://catunes.azurewebsites.net/")
            };
            controller.Configuration = new HttpConfiguration();
            controller.Configuration.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/Tunes/artist/Rose Royce",
                defaults: new { id = RouteParameter.Optional });

            controller.RequestContext.RouteData = new HttpRouteData(
                route: new HttpRoute(),
                values: new HttpRouteValueDictionary { { "controller", "products" } });

            // Act
            Tunes t1 = new Tunes() {IrishChart = 21, Title = "Car Wash", Artist = "Rose Royce", Genre = "Disco" };
            var response = controller.Post(t1);

            // Assert
            Assert.AreEqual("http://localhost/api/products/42", response.Headers.Location.AbsoluteUri);
            

        }*/
    }
}
