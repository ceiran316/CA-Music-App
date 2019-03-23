using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace TunesClient
{
    class Client
    {
        private static readonly HttpClient client = new HttpClient();
        //private static readonly String BaseURI = "https://ca-music-app.azurewebsites.net/api/tunes/";
        private static readonly String BaseURI = "https://localhost:5001/api/tunes/";
        static async Task RunAsync()
        {
            try
            {
                //get all customer ordered by county
                Console.WriteLine("*************************all tunes*************************");
                var serializer = new DataContractJsonSerializer(typeof(List<Tunes>));
                var streamTask = client.GetStreamAsync(BaseURI + "all");
                var tunes = serializer.ReadObject(await streamTask) as List<Tunes>;
                Console.WriteLine(" *** Return all tunes  *** ");
                foreach (var t in tunes)
                {
                    Console.WriteLine(t.ToString());
                }
                Console.WriteLine("\n");

                //get all customer ordered by county
                Console.WriteLine("*************************all suggested tunes*************************");
                serializer = new DataContractJsonSerializer(typeof(List<SuggestedTunes>));
                streamTask = client.GetStreamAsync(BaseURI + "allSuggested");
                var suggested = serializer.ReadObject(await streamTask) as List<SuggestedTunes>;
                Console.WriteLine(" *** Return all tunes  *** ");
                foreach (var t in suggested)
                {
                    Console.WriteLine(t.ToString());
                }
                Console.WriteLine("\n");

                //get all customer ordered by county
                Console.WriteLine("*************************new added tunes*************************");
                serializer = new DataContractJsonSerializer(typeof(List<SuggestedTunes>));
                streamTask = client.GetStreamAsync(BaseURI + "allNewSuggested");
                var newS = serializer.ReadObject(await streamTask) as List<SuggestedTunes>;
                Console.WriteLine(" *** Return all tunes  *** ");
                foreach (var t in newS)
                {
                    Console.WriteLine(t.ToString());
                }
                Console.WriteLine("\n");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            RunAsync().Wait();
            client.Dispose();
            Console.ReadLine();
        }
    }

}
