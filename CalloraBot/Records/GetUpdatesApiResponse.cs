using System.Text.Json.Serialization;

namespace CalloraBot.Records
{
    public record Chat(
        [property: JsonPropertyName("id")] int? Id,
        [property: JsonPropertyName("first_name")] string FirstName,
        [property: JsonPropertyName("username")] string Username,
        [property: JsonPropertyName("type")] string Type
    );

    public record Entity(
        [property: JsonPropertyName("offset")] int? Offset,
        [property: JsonPropertyName("length")] int? Length,
        [property: JsonPropertyName("type")] string Type
    );

    public record From(
        [property: JsonPropertyName("id")] int? Id,
        [property: JsonPropertyName("is_bot")] bool? IsBot,
        [property: JsonPropertyName("first_name")] string FirstName,
        [property: JsonPropertyName("username")] string Username,
        [property: JsonPropertyName("language_code")] string LanguageCode
    );

    public record Message(
        [property: JsonPropertyName("message_id")] int? MessageId,
        [property: JsonPropertyName("from")] From From,
        [property: JsonPropertyName("chat")] Chat Chat,
        [property: JsonPropertyName("date")] int? Date,
        [property: JsonPropertyName("text")] string Text,
        [property: JsonPropertyName("entities")] IReadOnlyList<Entity> Entities
    );

    public record GetUpdatesResult(
        [property: JsonPropertyName("update_id")] int? UpdateId,
        [property: JsonPropertyName("message")] Message Message
    );

    public record GetUpdatesApiResponse(
        [property: JsonPropertyName("ok")] bool? Ok,
        [property: JsonPropertyName("result")] IReadOnlyList<GetUpdatesResult> Result
    );
}
