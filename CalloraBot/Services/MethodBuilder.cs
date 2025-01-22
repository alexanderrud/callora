using CalloraBot.Enums;

namespace CalloraBot.Services
{
    public class MethodBuilder
    {
        private string _telegramBotApiUrl;
        private string _telegramBotToken;
        private Dictionary<BotMethod, string> _methodsList;

        public MethodBuilder(IConfiguration configuration)
        {
            _telegramBotApiUrl = configuration.GetValue<string>("TelegramBotApiUrl")!;
            _telegramBotToken = configuration.GetValue<string>("BotConfiguration:Token")!;

            _methodsList = new Dictionary<BotMethod, string>()
            {
                [BotMethod.GetMe] = "getMe",
                [BotMethod.GetUpdates] = "getUpdates"
            };
        }

        public string Build(BotMethod botMethod)
        {
            string targetMethod = _methodsList[botMethod];
            return _telegramBotApiUrl + _telegramBotToken + "/" + targetMethod;
        }
    }
}
