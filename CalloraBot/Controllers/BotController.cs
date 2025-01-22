using CalloraBot.Enums;
using CalloraBot.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalloraBot.Controllers
{
    [ApiController]
    public class BotController(MethodBuilder methodBuilder, HttpClient httpClient) : Controller
    {
        private MethodBuilder _methodBuilder = methodBuilder;
        private HttpClient _httpClient = httpClient;

        [HttpGet("/")]
        public string Index()
        {
            return "hello";
        }

        [HttpGet("getMe")]
        public async Task<string> GetMe()
        {
            string getMeMethod = _methodBuilder.Build(BotMethod.GetMe);

            HttpResponseMessage responseMessage = await _httpClient.GetAsync(getMeMethod);
            
            return await responseMessage.Content.ReadAsStringAsync();
        }
    }
}
