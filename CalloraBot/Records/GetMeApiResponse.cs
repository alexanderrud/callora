using System.Text.Json.Serialization;

namespace CalloraBot.Records
{
    public record GetMeResult(
        [property: JsonPropertyName("id")] long? Id,
        [property: JsonPropertyName("is_bot")] bool? IsBot,
        [property: JsonPropertyName("first_name")] string FirstName,
        [property: JsonPropertyName("username")] string Username,
        [property: JsonPropertyName("can_join_groups")] bool? CanJoinGroups,
        [property: JsonPropertyName("can_read_all_group_messages")] bool? CanReadAllGroupMessages,
        [property: JsonPropertyName("supports_inline_queries")] bool? SupportsInlineQueries,
        [property: JsonPropertyName("can_connect_to_business")] bool? CanConnectToBusiness,
        [property: JsonPropertyName("has_main_web_app")] bool? HasMainWebApp
    );

    public record GetMeApiResponse(
        [property: JsonPropertyName("ok")] bool? Ok,
        [property: JsonPropertyName("result")] GetMeResult Result
    );
}
