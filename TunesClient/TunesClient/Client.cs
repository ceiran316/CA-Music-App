using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace TunesClient
{
    class Client
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly String BaseURI = "https://ca-music-app.azurewebsites.net/api/tunes/";
        //private static readonly String BaseURI = "https://localhost:5001/api/tunes/";
        static async Task RunAsync()
        {
            try
            {
                //get all tune 
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

                //get all suggested tune 
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

                //delete Tune by Title (input)
                /*serializer = new DataContractJsonSerializer(typeof(SuggestedTunes));
                Console.WriteLine("*************************delete tunes(title)*************************");
                Console.WriteLine("Please enter name of song to delete");
                var delTune = Console.ReadLine();
                HttpResponseMessage httpResponse = await client.DeleteAsync(BaseURI + "delete/" + delTune);
                httpResponse.EnsureSuccessStatusCode();
                Console.WriteLine("Song" + delTune + "deleted");
                Console.WriteLine("\n");*/

                //get tune after delete (input)
                serializer = new DataContractJsonSerializer(typeof(List<SuggestedTunes>));
                streamTask = client.GetStreamAsync(BaseURI + "allSuggested");
                var newList = serializer.ReadObject(await streamTask) as List<SuggestedTunes>;
                Console.WriteLine(" *** tunes after delete   *** ");
                foreach (var c in newList)
                {
                    Console.WriteLine(c.ToString());
                }
                Console.WriteLine("\n");

                /*MemoryStream ms = new MemoryStream();
                serializer = new DataContractJsonSerializer(typeof(List<SuggestedTunes>));

                Console.WriteLine("Title: ");
                var title = Console.ReadLine();
                Console.WriteLine("Artist: ");
                var artists = Console.ReadLine();
                Console.WriteLine("Genre: ");
                var genre = Console.ReadLine();

                SuggestedTunes st = new SuggestedTunes();
                serializer.WriteObject(ms, st);
                // read and create string content for POST
                ms.Position = 0;
                StreamReader sr = new StreamReader(ms);
                StringContent content = new StringContent(sr.ReadToEnd(), Encoding.UTF8, "application/json");

                // POST
                HttpResponseMessage httpResp = await client.PostAsync(BaseURI, content);
                httpResp.EnsureSuccessStatusCode();

                // read response if no exception
                SuggestedTunes stPost = serializer.ReadObject(await httpResponse.Content.ReadAsStreamAsync()) as SuggestedTunes;
                Console.Write("Created: " + stPost);
                Console.WriteLine("URI: " + httpResponse.Headers.Location);*/

                //get all suggested Tunes
                Console.WriteLine("*************************new added tunes*************************");
                serializer = new DataContractJsonSerializer(typeof(List<SuggestedTunes>));
                streamTask = client.GetStreamAsync(BaseURI + "allNewHardSuggested");
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
