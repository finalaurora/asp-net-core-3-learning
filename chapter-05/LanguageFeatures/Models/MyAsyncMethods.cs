using System.Net.Http;
using System.Threading.Tasks;
namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public static async Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var httpMessage = await client.GetAsync("http://apress.com");
            return httpMessage.Content.Headers.ContentLength;
        }
    }
}