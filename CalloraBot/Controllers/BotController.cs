using CalloraBot.Enums;
using CalloraBot.Records;
using CalloraBot.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CalloraBot.Controllers
{
    [ApiController]
    public class BotController(MethodBuilder methodBuilder, HttpClient httpClient) : Controller
    {
        private MethodBuilder _methodBuilder = methodBuilder;
        private HttpClient _httpClient = httpClient;

        [HttpGet("getMe")]
        public async Task<IActionResult> GetMe()
        {
            string getMeMethod = _methodBuilder.Build(BotMethod.GetMe);
            HttpResponseMessage responseMessage = await _httpClient.GetAsync(getMeMethod);

            string convertedResponse = await responseMessage.Content.ReadAsStringAsync();
            GetMeApiResponse getMeApiResponse = JsonSerializer.Deserialize<GetMeApiResponse>(convertedResponse)!;

            return Ok(new { Data = getMeApiResponse.Result });
        }

        [HttpGet("getUpdates")]
        public async Task<IActionResult> GetUpdates()
        {
            string getUpdatesMethod = _methodBuilder.Build(BotMethod.GetUpdates);
            HttpResponseMessage responseMessage = await _httpClient.GetAsync(getUpdatesMethod);

            string convertedResponse = await responseMessage.Content.ReadAsStringAsync();
            GetUpdatesApiResponse getUpdatesApiResponse = JsonSerializer.Deserialize<GetUpdatesApiResponse>(convertedResponse)!;

            return Ok(new { Data = getUpdatesApiResponse.Result.First() });
        }
    }
}
