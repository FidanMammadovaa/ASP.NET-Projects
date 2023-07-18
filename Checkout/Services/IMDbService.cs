using Checkout.Models;
using Newtonsoft.Json;

namespace Checkout.Services
{
    public class IMDbService
    {
        public async Task<IMDb> GetMovieInfoAsync(string title)
        {
            HttpClient client = new();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://imdb8.p.rapidapi.com/title/find?q={title}"),
                Headers =
                {
                      { "X-RapidAPI-Key", "5d1f93e7fcmsh31cd902310f3596p15d104jsn5981f11710d4" },
                      { "X-RapidAPI-Host", "imdb8.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();

                var json = content.ToString();
                var result = JsonConvert.DeserializeObject<IMDb>(json);
                return result;
            }

        }
    }
}
